using System;
using System.Collections.Generic;
using System.Timers;
using Chatr.Console.Enums;

namespace Chatr.Console
{
    public class BotTimerConfig
    {
        public int Interval { get; set; }
        public int MinInterval { get; set; }
        public int MaxInterval { get; set; }
        public ICollection<string> Commands { get; set; }
        public string Type { get; set; }
    }
}
