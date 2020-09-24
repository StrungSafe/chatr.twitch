namespace Chatr.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Chatr.Console.BotTimers;

    using Microsoft.Extensions.Logging;

    using TwitchLib.Client.Interfaces;

    public static class BotTimerHandlerFactory
    {
        public static void Create(List<BotTimerHandler> timerHandlers, ICollection<BotTimerConfig> timerConfigs,
                                  ITwitchClient client, string channel, ILogger logger)
        {
            foreach (BotTimerConfig timerConfig in timerConfigs ?? Enumerable.Empty<BotTimerConfig>())
            {
                try
                {
                    timerHandlers.Add(new BotTimerHandler(client, channel, timerConfig));
                }
                catch (NullReferenceException e)
                {
                    logger.LogError(e, $"{e.Message} Timer may not be a valid IBotTimer");
                }
                catch (MissingMethodException e)
                {
                    logger.LogWarning(e, "Timer could not be made");
                }
            }
        }
    }
}