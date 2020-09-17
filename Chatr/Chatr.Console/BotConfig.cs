namespace Chatr.Console
{
    using System.Collections.Generic;

    internal class BotConfig
    {
        public ICollection<string> Destinations { get; set; }

        public int MaxConnections { get; set; }

        public string Name { get; set; }

        public ICollection<string> Sources { get; set; }

        public string Token { get; set; }
    }
}