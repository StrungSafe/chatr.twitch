namespace Chatr.Console
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
            {
                services.AddLogging(builder =>
                {
                    builder.AddEventLog(settings =>
                    {
                        settings.SourceName = context.Configuration["Logging:EventLog:SourceName"];
                    });
                });

                services.Configure<BotConfig>(context.Configuration.GetSection(nameof(BotConfig)));
                services.AddHostedService<Bot>();
            });
        }
    }
}