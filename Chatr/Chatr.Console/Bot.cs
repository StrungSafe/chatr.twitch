namespace Chatr.Console
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Options;

    using TwitchLib.Client;
    using TwitchLib.Client.Events;
    using TwitchLib.Client.Models;
    using TwitchLib.Communication.Clients;
    using TwitchLib.Communication.Models;

    internal class Bot : IHostedService
    {
        private readonly BotConfig config;

        private TwitchClient client;

        public Bot(IOptions<BotConfig> config)
        {
            this.config = config.Value;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            string username = config.Username;
            string token = config.Token;
            string channel = config.Channel;

            var credentials = new ConnectionCredentials(username, token);
            var clientOptions = new ClientOptions
                                {
                                    MessagesAllowedInPeriod = 750, ThrottlingPeriod = TimeSpan.FromSeconds(30)
                                };
            var customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);
            client.Initialize(credentials, channel);

            client.OnMessageReceived += Client_OnMessageReceived;

            client.Connect();
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

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
        }
    }
}