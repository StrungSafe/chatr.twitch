namespace Chatr.Console.Contracts
{
    using System;
    using System.Timers;

    public interface IBotTimer
    {
        Timer Build();

        string OnTimeElapsed(Action extraActionToPerform = null);
    }
}