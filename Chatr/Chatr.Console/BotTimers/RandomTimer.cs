using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using Chatr.Console.Contracts;
using Chatr.Console.Extensions;

namespace Chatr.Console.BotTimers
{
    public class RandomTimer : IBotTimer
    {
        private readonly int minIntervalValue;
        private readonly int maxIntervalValue;

        private readonly Random intervalRandomizer;

        private readonly ICollection<string> commands;

        public RandomTimer(BotTimerConfig config)
        {
            this.minIntervalValue = config.MinInterval;
            this.maxIntervalValue = config.MaxInterval;
            this.intervalRandomizer = new Random();
            this.commands = config.Commands;
        }

        public Timer Build()
        {
            if (minIntervalValue > maxIntervalValue)
            {
                throw new Exception("minIntervalValue must be less than or equal to maxInternalValue");
            }

            int randomInterval = intervalRandomizer.Next(minIntervalValue, maxIntervalValue);
            return new Timer()
            {
                Interval = randomInterval,
                AutoReset = false,
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
