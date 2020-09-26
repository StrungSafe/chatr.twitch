namespace Chatr.Core
{
    using System.Collections.Generic;

    public class BotTimerConfig
    {
        public ICollection<string> Commands { get; set; }

        public int Interval { get; set; }

        public int MaxInterval { get; set; }

        public int MinInterval { get; set; }

        public string Type { get; set; }
    }
}