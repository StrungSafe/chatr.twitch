using System;
using System.Collections.Generic;
using System.Text;
using Chatr.Console.BotTimers;
using Microsoft.Extensions.Logging;
using TwitchLib.Client.Interfaces;

namespace Chatr.Console
{
    public static class BotTimerHandlerFactory
    {
        public static void Create(List<BotTimerHandler> timerHandlers, ICollection<BotTimerConfig> timerConfigs, ITwitchClient client, string channel, ILogger logger)
        {
            foreach (var timerConfig in timerConfigs)
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
