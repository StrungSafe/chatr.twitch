namespace Chatr.Console
{
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
            string channel = config.Channel;

            var credentials = new ConnectionCredentials(username, token);
            client = new TwitchClient(protocol: ClientProtocol.TCP);

            client.OnMessageReceived += Client_OnMessageReceived;

            client.Initialize(credentials, channel);

            logger.LogInformation("Twitch client connecting");

            client.Connect();

            logger.LogInformation("Twitch client connected");

            client.JoinChannel(channel);

            await Task.Delay(0);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            client.Disconnect();

            client.OnMessageReceived -= Client_OnMessageReceived;

            client = null;

            await Task.Delay(0);
        }

        public void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            logger.LogInformation("Message received! {channel} {message}", e.ChatMessage.Channel,
                e.ChatMessage.Message);
        }
    }
}