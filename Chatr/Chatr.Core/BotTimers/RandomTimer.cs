namespace Chatr.Core.BotTimers
{
    using System;
    using System.Collections.Generic;
    using System.Timers;

    using Chatr.Core;
    using Chatr.Core.Contracts;
    using Chatr.Core.Extensions;

    public class RandomTimer : IBotTimer
    {
        private readonly ICollection<string> commands;

        private readonly Random intervalRandomizer;

        private readonly int maxIntervalValue;

        private readonly int minIntervalValue;

        public RandomTimer(BotTimerConfig config)
        {
            minIntervalValue = config.MinInterval;
            maxIntervalValue = config.MaxInterval;
            intervalRandomizer = new Random();
            commands = config.Commands;
        }

        public Timer Build()
        {
            if (minIntervalValue > maxIntervalValue)
            {
                throw new Exception("minIntervalValue must be less than or equal to maxInternalValue");
            }

            int randomInterval = intervalRandomizer.Next(minIntervalValue, maxIntervalValue);
            return new Timer { Interval = randomInterval, AutoReset = false, Enabled = true };
        }

        public string OnTimeElapsed(Action extraActionToPerform = null)
        {
            extraActionToPerform?.Invoke();
            return commands.PickRandom();
        }
    }
}