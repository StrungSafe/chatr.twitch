using System;
using System.Timers;

namespace Chatr.Console.Contracts
{
    public interface IBotTimer
    {
        Timer Build();
        string OnTimeElapsed(Action extraActionToPerform = null);
    }
}
