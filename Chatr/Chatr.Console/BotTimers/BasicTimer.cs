namespace Chatr.Console.BotTimers
{
    using System;
    using System.Collections.Generic;
    using System.Timers;

    using Chatr.Console.Contracts;
    using Chatr.Console.Extensions;

    public class BasicTimer : IBotTimer
    {
        private readonly ICollection<string> commands;

        private readonly int interval;

        public BasicTimer(BotTimerConfig config)
        {
            interval = config.Interval;
            commands = config.Commands;
        }

        public Timer Build()
        {
            return new Timer { Interval = interval, AutoReset = true, Enabled = true };
        }

        public string OnTimeElapsed(Action extraActionToPerform = null)
        {
            extraActionToPerform?.Invoke();
            return commands.PickRandom();
        }
    }
}