namespace Chatr.Console
{
    using System.Collections.Generic;

    internal class BotConfig
    {
        public string Channel { get; set; }

        public ICollection<string> Destinations { get; set; } = new List<string>();

        public ICollection<string> IgnoreChatFrom { get; set; } = new List<string>();

        public ICollection<string> IgnoreCommandFrom { get; set; } = new List<string>();

        public int MaxConnections { get; set; }

        public string Name { get; set; }

        public ICollection<string> Sources { get; set; } = new List<string>();

        public string Token { get; set; }
    }
}