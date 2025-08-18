using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PDFManagerV2.Infrastructure.Pdf;
using PDFManagerV2.UseCases.Interfaces;
using PDFManagerV2.UseCases.Recibos.Create;

namespace PDFManagerV2.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var mainForm = host.Services.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddTransient<MainForm>();
                    services.AddTransient<IFileStorageService, LocalStorageService>();
                    services.AddMediatR(cfg =>
                    {
                        cfg.RegisterServicesFromAssembly(typeof(CreateReciboHandler).Assembly);
                    });
                    services.AddSingleton<IAppSettings, AppSettings>();
                });
    }
}