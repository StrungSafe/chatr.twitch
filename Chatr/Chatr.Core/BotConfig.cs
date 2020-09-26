namespace Chatr.Core
{
    using System.Collections.Generic;

    public class BotConfig
    {
        public string Channel { get; set; }

        public ICollection<string> Destinations { get; set; } = new List<string>();

        public ICollection<string> IgnoreChatFrom { get; set; } = new List<string>();

        public ICollection<string> IgnoreCommandFrom { get; set; } = new List<string>();

        public bool KeepCommandsSynced { get; set; } = true;

        public int MaxConnections { get; set; } = 6;

        public string Name { get; set; }

        public ICollection<string> Sources { get; set; } = new List<string>();

        public ICollection<BotTimerConfig> Timers { get; set; }

        public string Token { get; set; }
    }
}