namespace Chatr.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using TwitchLib.Client;
    using TwitchLib.Client.Enums;
    using TwitchLib.Client.Events;
    using TwitchLib.Client.Interfaces;
    using TwitchLib.Client.Models;

    public class Bot : IHostedService
    {
        private const char commandIdentifier = '!';

        private readonly ILogger logger;

        private readonly List<BotTimerHandler> timerHandlers;

        private ITwitchClient client;

        private bool disposed;

        public Bot(BotConfig config, ILogger<Bot> logger)
        {
            Config = config;
            this.logger = logger;
            timerHandlers = new List<BotTimerHandler>();
        }

        public Bot(IOptions<BotConfig> config, ILogger<Bot> logger)
            : this(config.Value, logger)
        {
        }

        public BotConfig Config { get; set; }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(Bot),
                    "This class is already disposed of, create a new instance first");
            }

            string username = Config.Name;
            string token = Config.Token;
            string channel = Config.Channel;
            ICollection<string> sources = Get(Config.Sources);
            ICollection<string> destinations = Get(Config.Destinations);
            ICollection<BotTimerConfig> timerConfigs = Config.Timers;

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

            if (ShouldIgnore(Config.IgnoreCommandFrom, onChatCommandReceivedArgs.Command.ChatMessage,
                out string username))
            {
                logger.LogDebug($"Ignoring command from {username}");
                return;
            }

            if (string.Equals(onChatCommandReceivedArgs.Command.ChatMessage.Channel, Config.Channel))
            {
                logger.LogDebug("Received a command we want to handle");
                client.SendMessage(Config.Channel, "beep boop");
            }
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs onMessageReceivedArgs)
        {
            if (ShouldIgnore(Config.IgnoreChatFrom, onMessageReceivedArgs.ChatMessage, out string username))
            {
                logger.LogDebug($"Ignoring message from {username}");
                return;
            }

            if (Config.Sources.Contains(onMessageReceivedArgs.ChatMessage.Channel)
                || Config.Channel == onMessageReceivedArgs.ChatMessage.Channel)
            {
                if (onMessageReceivedArgs.ChatMessage.Message.StartsWith(char.ToString(commandIdentifier))
                    && !Config.KeepCommandsSynced)
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
            Echo(Config.Channel, chatMessage);
            Echo(Config.Destinations, chatMessage);
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
            return values.Take(Config.MaxConnections).ToList();
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