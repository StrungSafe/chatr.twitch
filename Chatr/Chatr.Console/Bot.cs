﻿namespace Chatr.Console
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

    internal class Bot : IHostedService
    {
        private readonly BotConfig config;

        private readonly ILogger logger;

        private ITwitchClient client;

        private bool disposed;

        public Bot(IOptions<BotConfig> config, ILogger<Bot> logger)
        {
            this.config = config.Value;
            this.logger = logger;
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
            logger.LogInformation("Bot disposing");
            disposed = true;

            if (client.IsConnected)
            {
                logger.LogInformation("Twitch client disconnecting");
                client.Disconnect();
                logger.LogInformation("Twitch client disconnected");
            }

            client.OnMessageReceived -= Client_OnMessageReceived;

            client = null;

            logger.LogInformation("Bot disposed");

            await Task.Delay(0);
        }

        public void Client_OnMessageReceived(object sender, OnMessageReceivedArgs onMessageReceivedArgs)
        {
            if (config.Sources.Contains(onMessageReceivedArgs.ChatMessage.Channel))
            {
                logger.LogDebug("Echo message from channel: {channel} message: {message}",
                    onMessageReceivedArgs.ChatMessage.Channel, onMessageReceivedArgs.ChatMessage.Message);
                Echo(config.Destinations, onMessageReceivedArgs.ChatMessage);
                return;
            }

            logger.LogDebug("Nothing to echo");
        }

        private void ConnectToChannels(ICollection<string> channels)
        {
            foreach (string channel in channels ?? Enumerable.Empty<string>())
            {
                logger.LogInformation("Joining channel {channel}", channel);
                client.JoinChannel(channel);
                logger.LogInformation("Channel {channel} joined", channel);
            }
        }

        private void Echo(ICollection<string> channels, ChatMessage chatMessage)
        {
            foreach (string channel in channels)
            {
                Echo(channel, chatMessage);
            }
        }

        private void Echo(string channel, ChatMessage chatMessage)
        {
            JoinedChannel joined = client.GetJoinedChannel(channel);

            client.SendMessage(joined, chatMessage.Message);
        }
    }
}