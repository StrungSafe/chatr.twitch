namespace Chatr.Console
{
    using System.Collections.Generic;
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

    internal class Bot : IHostedService
    {
        private readonly BotConfig config;

        private readonly ILogger logger;

        private ITwitchClient client;

        public Bot(IOptions<BotConfig> config, ILogger<Bot> logger)
        {
            this.config = config.Value;
            this.logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            string username = config.Name;
            string token = config.Token;

            var credentials = new ConnectionCredentials(username, token);
            client = new TwitchClient(protocol: ClientProtocol.TCP);

            logger.LogInformation("Initializing twitch client");

            client.Initialize(credentials);

            logger.LogInformation("Twitch client connecting");

            client.Connect();

            logger.LogInformation("Twitch client connected");

            ConnectToChannels(config.Sources);
            ConnectToChannels(config.Destinations);

            client.OnMessageReceived += Client_OnMessageReceived;

            await Task.Delay(0);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            client.Disconnect();

            client.OnMessageReceived -= Client_OnMessageReceived;

            client = null;

            await Task.Delay(0);
        }

        public void Client_OnMessageReceived(object sender, OnMessageReceivedArgs onMessageReceivedArgs)
        {
            if (config.Sources.Contains(onMessageReceivedArgs.ChatMessage.Channel))
            {
                logger.LogDebug("Echo message from channel: {channel} message: {message}",
                    onMessageReceivedArgs.ChatMessage.Channel, onMessageReceivedArgs.ChatMessage.Message);
                return;
            }

            logger.LogDebug("Nothing to echo");
        }

        private void ConnectToChannels(ICollection<string> channels)
        {
            foreach (string channel in channels)
            {
                logger.LogInformation("Joining channel {channel}", channel);
                client.JoinChannel(channel);
                logger.LogInformation("Channel {channel} joined", channel);
            }
        }
    }
}