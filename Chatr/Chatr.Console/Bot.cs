namespace Chatr.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using Chatr.Console.BotTimers;

    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using TwitchLib.Client;
    using TwitchLib.Client.Enums;
    using TwitchLib.Client.Events;
    using TwitchLib.Client.Interfaces;
    using TwitchLib.Client.Models;

    internal class Bot : IHostedService
    {
        private const char commandIdentifier = '!';

        private readonly BotConfig config;

        private readonly ILogger logger;

        private readonly List<BotTimerHandler> timerHandlers;

        private ITwitchClient client;

        private bool disposed;

        public Bot(IOptions<BotConfig> config, ILogger<Bot> logger)
        {
            this.config = config.Value;
            this.logger = logger;
            timerHandlers = new List<BotTimerHandler>();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(Bot),
                    "This class is already disposed of, create a new instance first");
            }

            string username = config.Name;
            string token = config.Token;
            string channel = config.Channel;
            ICollection<string> sources = Get(config.Sources);
            ICollection<string> destinations = Get(config.Destinations);
            ICollection<BotTimerConfig> timerConfigs = config.Timers;

            logger.LogInformation("Initializing twitch client");

            client = new TwitchClient(protocol: ClientProtocol.TCP);
            var credentials = new ConnectionCredentials(username, token);
            client.Initialize(credentials);
            client.AddChatCommandIdentifier(commandIdentifier);

            logger.LogDebug("Twitch client connecting");

            client.Connect();

            logger.LogInformation("Twitch client connected");

            ConnectToChannels(channel);
            ConnectToChannels(sources);
            ConnectToChannels(destinations);

            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnChatCommandReceived += Client_OnChatCommandReceived;

            BotTimerHandlerFactory.Create(timerHandlers, timerConfigs, client, channel, logger);

            await Task.Delay(0);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Bot disposing");
            disposed = true;

            if (client.IsConnected)
            {
                logger.LogDebug("Twitch client disconnecting");
                client.Disconnect();
                logger.LogInformation("Twitch client disconnected");
            }

            client.OnMessageReceived -= Client_OnMessageReceived;

            client = null;

            foreach (BotTimerHandler timerHandler in timerHandlers)
            {
                timerHandler.Dispose();
            }

            timerHandlers.Clear();

            logger.LogInformation("Bot disposed");

            await Task.Delay(0);
        }

        private void Client_OnChatCommandReceived(object sender, OnChatCommandReceivedArgs onChatCommandReceivedArgs)
        {
            logger.LogDebug("Command received");

            if (ShouldIgnore(config.IgnoreCommandFrom, onChatCommandReceivedArgs.Command.ChatMessage,
                out string username))
            {
                logger.LogDebug($"Ignoring command from {username}");
                return;
            }

            if (string.Equals(onChatCommandReceivedArgs.Command.ChatMessage.Channel, config.Channel))
            {
                logger.LogDebug("Received a command we want to handle");
                client.SendMessage(config.Channel, "beep boop");
            }
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs onMessageReceivedArgs)
        {
            if (ShouldIgnore(config.IgnoreChatFrom, onMessageReceivedArgs.ChatMessage, out string username))
            {
                logger.LogDebug($"Ignoring message from {username}");
                return;
            }

            if (config.Sources.Contains(onMessageReceivedArgs.ChatMessage.Channel)
                || config.Channel == onMessageReceivedArgs.ChatMessage.Channel)
            {
                if (onMessageReceivedArgs.ChatMessage.Message.StartsWith(commandIdentifier)
                    && !config.KeepCommandsSynced)
                {
                    logger.LogDebug("Not going to echo command");
                    return;
                }

                logger.LogDebug("Echo message from channel: {channel} message: {message}",
                    onMessageReceivedArgs.ChatMessage.Channel, onMessageReceivedArgs.ChatMessage.Message);
                Echo(onMessageReceivedArgs.ChatMessage);
                return;
            }

            logger.LogDebug("Not going to echo");
        }

        private void ConnectToChannels(string channel)
        {
            logger.LogInformation("Joining channel {channel}", channel);
            client.JoinChannel(channel);
            logger.LogInformation("Channel {channel} joined", channel);
        }

        private void ConnectToChannels(ICollection<string> channels)
        {
            foreach (string channel in channels ?? Enumerable.Empty<string>())
            {
                ConnectToChannels(channel);
            }
        }

        private void Echo(ChatMessage chatMessage)
        {
            Echo(config.Channel, chatMessage);
            Echo(config.Destinations, chatMessage);
        }

        private void Echo(ICollection<string> channels, ChatMessage chatMessage)
        {
            foreach (string channel in channels ?? Enumerable.Empty<string>())
            {
                Echo(channel, chatMessage);
            }
        }

        private void Echo(string channel, ChatMessage chatMessage)
        {
            if (chatMessage.Channel == channel)
            {
                logger.LogDebug($"Not going to echo message back to channel {channel}");
                return;
            }

            JoinedChannel joined = client.GetJoinedChannel(channel);

            string originalMessage = chatMessage.Message;
            string newMessage = originalMessage;

            string postMessage = $" - {chatMessage.Username} from @{chatMessage.Channel}'s channel";

            var maxLength = 400;

            if (originalMessage.Length > maxLength - postMessage.Length)
            {
                newMessage = originalMessage.Substring(0, maxLength - postMessage.Length + 3) + "...";
            }

            string message = newMessage + postMessage;

            logger.LogTrace($"Going to echo message to channel {channel} {message}");

            client.SendMessage(joined, message);
        }

        private ICollection<string> Get(ICollection<string> collection)
        {
            if (collection == null)
            {
                return new List<string>(0);
            }

            return ToLower(GetWithMax(collection));
        }

        private ICollection<string> GetWithMax(ICollection<string> values)
        {
            return values.Take(config.MaxConnections).ToList();
        }

        private bool ShouldIgnore(ICollection<string> ignoreFrom, ChatMessage chatMessage, out string username)
        {
            username = chatMessage.Username;
            return ignoreFrom?.Contains(chatMessage.Username) ?? false;
        }

        private ICollection<string> ToLower(ICollection<string> collection)
        {
            return collection.Select(item => item.ToLower()).ToList();
        }
    }
}