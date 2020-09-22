namespace Chatr.Console
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Discord;
    using Discord.WebSocket;

    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using TwitchLib.Client;
    using TwitchLib.Client.Enums;
    using TwitchLib.Client.Interfaces;
    using TwitchLib.Client.Models;

    internal class DiscordBot : IHostedService
    {
        private readonly BotConfig botConfig;

        private readonly DiscordBotConfig discordConfig;

        private readonly ILogger logger;

        private DiscordSocketClient client;

        private ITwitchClient twitchClient;

        public DiscordBot(ILogger<DiscordBot> logger, IOptions<BotConfig> botConfig,
                          IOptions<DiscordBotConfig> discordConfig)
        {
            this.logger = logger;
            this.botConfig = botConfig.Value;
            this.discordConfig = discordConfig.Value;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                client = new DiscordSocketClient();
                string token = discordConfig.Token;
                await client.LoginAsync(TokenType.Bot, token);
                await client.StartAsync();

                twitchClient = new TwitchClient(protocol: ClientProtocol.TCP);
                var credentials = new ConnectionCredentials(botConfig.Name, botConfig.Token);
                twitchClient.Initialize(credentials);
                twitchClient.Connect();
                twitchClient.JoinChannel(botConfig.Channel);

                client.MessageReceived += HandleMessageReceived;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "There was an unhandled exception during startup.");
                await StopAsync(cancellationToken);
            }
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            twitchClient.Disconnect();
            twitchClient = null;

            await client.StopAsync();
            client.Dispose();
            client = null;
        }

        private async Task HandleMessageReceived(SocketMessage rawMessage)
        {
            // Ignore system messages and messages from bots
            if (!(rawMessage is SocketUserMessage message))
            {
                return;
            }

            if (message.Source != MessageSource.User)
            {
                return;
            }

            if (message.Channel.Name == discordConfig.Channel)
            {
                SendMessage(message);
            }

            await Task.Delay(0);
        }

        private void SendMessage(SocketUserMessage message)
        {
            JoinedChannel joined = twitchClient.GetJoinedChannel(botConfig.Channel);

            string originalMessage = message.Content;
            string newMessage = originalMessage;

            string postMessage = $" - {message.Author.Username} from Discord";

            var maxLength = 400;

            if (originalMessage.Length > maxLength - postMessage.Length)
            {
                newMessage = originalMessage.Substring(0, maxLength - postMessage.Length + 3) + "...";
            }

            string newerMessage = newMessage + postMessage;

            twitchClient.SendMessage(joined, newerMessage);
        }
    }
}