namespace Chatr.Forms
{
    using System;
    using System.Windows.Forms;

    using Chatr.Core;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IHost host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddLogging(builder =>
                {
                    builder.AddEventLog(settings =>
                    {
                        settings.SourceName = context.Configuration["Logging:EventLog:SourceName"];
                    });
                });

                services.AddSingleton<Bot>();

                services.AddSingleton<DiscordBot>();

                services.AddSingleton<MainForm>();
            }).Build();

            var mainForm = host.Services.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }
    }
}