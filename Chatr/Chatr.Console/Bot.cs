namespace Chatr.Console
{
    using System;
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
    using TwitchLib.Client.Models.Internal;
    using TwitchLib.Communication.Clients;
    using TwitchLib.Communication.Interfaces;
    using TwitchLib.Communication.Models;

    internal class Bot : IHostedService
    {
        private readonly BotConfig config;

        private ITwitchClient twitchClient;

        private readonly ILogger logger;

        private IClient client;
        public Bot(IOptions<BotConfig> config, ILogger<Bot> logger)
        {
            this.config = config.Value;
            this.logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            string username = config.Name;
            string token = config.Token;
            string channel = config.Channel;

            var credentials = new ConnectionCredentials(username, token);
            twitchClient = new TwitchClient(null, ClientProtocol.TCP);

            twitchClient.OnMessageReceived += Client_OnMessageReceived;

            twitchClient.Initialize(credentials, channel);

            logger.LogInformation("Twitch client connecting");

            twitchClient.Connect();

            logger.LogInformation("Twitch client connected");

            twitchClient.JoinChannel(channel);

            await Task.Delay(0);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            twitchClient.Disconnect();

            twitchClient.OnMessageReceived -= Client_OnMessageReceived;
            
            client.Dispose();

            twitchClient = null;
            client = null;

            await Task.Delay(0);
        }

        public void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            logger.LogInformation("Message received! {message}", e.ChatMessage.Message);
        }
    }
}