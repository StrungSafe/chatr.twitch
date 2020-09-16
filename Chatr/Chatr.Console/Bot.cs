namespace Chatr.Console
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Hosting;

    using TwitchLib.Client;
    using TwitchLib.Client.Events;
    using TwitchLib.Client.Models;
    using TwitchLib.Communication.Clients;
    using TwitchLib.Communication.Models;

    internal class Bot : IHostedService
    {

        private TwitchClient client;

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var username = "";
            var token = "";
            var channel = "";
            
            ConnectionCredentials credentials = new ConnectionCredentials(username, token);
            var clientOptions = new ClientOptions
                                {
                                    MessagesAllowedInPeriod = 750,
                                    ThrottlingPeriod = TimeSpan.FromSeconds(30)
                                };
            WebSocketClient customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);
            client.Initialize(credentials, channel);

            client.OnLog += Client_OnLog;
            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnWhisperReceived += Client_OnWhisperReceived;
            client.OnNewSubscriber += Client_OnNewSubscriber;
            client.OnConnected += Client_OnConnected;

            client.Connect();

            await Task.Delay(0);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            client.OnLog -= Client_OnLog;
            client.OnJoinedChannel -= Client_OnJoinedChannel;
            client.OnMessageReceived -= Client_OnMessageReceived;
            client.OnWhisperReceived -= Client_OnWhisperReceived;
            client.OnNewSubscriber -= Client_OnNewSubscriber;
            client.OnConnected -= Client_OnConnected;

            client.Disconnect();

            client = null;
            await Task.Delay(0);
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
        }

        private void Client_OnWhisperReceived(object sender, OnWhisperReceivedArgs e)
        {
        }

        private void Client_OnNewSubscriber(object sender, OnNewSubscriberArgs e)
        {
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {
        }

        
    }
}