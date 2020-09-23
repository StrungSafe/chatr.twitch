using System;
using System.Timers;
using Chatr.Console.Contracts;
using TwitchLib.Client.Interfaces;

namespace Chatr.Console.BotTimers
{
    public class BotTimerHandler : IDisposable
    {
        private readonly IBotTimer _botTimer;

        private Timer timer;

        private readonly ITwitchClient client;

        private readonly string channel;

        private bool disposed;

        public BotTimerHandler(ITwitchClient client, string channel, BotTimerConfig config)
        {
            this.client = client;
            this.channel = channel;

            var type = Type.GetType($"Chatr.Console.BotTimers.{config.Type}");
            _botTimer = Activator.CreateInstance(type, config) as IBotTimer;

            timer = _botTimer.Build();
            timer.Elapsed += OnTimeElapsed;
        }

        private void OnTimeElapsed(object sender, EventArgs e)
        {
            string command = string.Empty;
            if (_botTimer is RandomTimer)
            {
                command = _botTimer.OnTimeElapsed(() => 
                {
                    timer.Dispose();
                    timer = _botTimer.Build();
                    timer.Elapsed += OnTimeElapsed;
                });
            }
            else
            {
                command = _botTimer.OnTimeElapsed();
            }
            SendMessage(command);
        }

        private void SendMessage(string commandMessage)
        {
            client.SendMessage(channel, commandMessage);
        }

        public void Dispose()
        {
            if (!disposed && timer != null)
            {
                timer.Dispose();
            }
            disposed = true;
            timer = null;
        }
    }
}
