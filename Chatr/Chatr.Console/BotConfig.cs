namespace Chatr.Console
{
    using System.Collections.Generic;

    internal class BotConfig
    {
        public string Channel { get; set; }

        public ICollection<string> Destinations { get; set; }

        public ICollection<string> IgnoreChatFrom { get; set; }

        public ICollection<string> IgnoreCommandFrom { get; set; }

        public int MaxConnections { get; set; }

        public string Name { get; set; }

        public ICollection<string> Sources { get; set; }

        public string Token { get; set; }
    }
}