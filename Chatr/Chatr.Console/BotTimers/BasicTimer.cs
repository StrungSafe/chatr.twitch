using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using Chatr.Console.Contracts;
using Chatr.Console.Extensions;

namespace Chatr.Console.BotTimers
{
    public class BasicTimer : IBotTimer
    {
        private readonly int interval;
        private readonly Random random;
        private readonly ICollection<string> commands;

        public BasicTimer(BotTimerConfig config)
        {
            this.interval = config.Interval;
            this.random = new Random();
            this.commands = config.Commands;
        }

        public Timer Build()
        {
            return new Timer()
            {
                Interval = interval,
                AutoReset = true,
                Enabled = true,
            };
        }

        public string OnTimeElapsed(Action extraActionToPerform = null)
        {
            extraActionToPerform?.Invoke();
            return commands.PickRandom();
        }
    }
}
