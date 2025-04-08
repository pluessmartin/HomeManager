using CrossCutting.Utility.Configuration;
using Microsoft.Extensions.Configuration;
using Service.BoilerHeizung;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

var host = Host.CreateDefaultBuilder(args)
        .UseWindowsService(options => {
        options.ServiceName = "BoilerHeizung";
        })
                .ConfigureAppConfiguration((context, config) =>
        {
        // Clear default configuration sources.
        config.Sources.Clear();

        // Add WorkerTests 'appsettings.json'.
        config.AddJsonFile("appsettings.json");


        })
        .ConfigureServices((hostContext, services) =>
        {
            IConfiguration configuration = hostContext.Configuration;
            services.AddHostedService<Worker>();
            services.Configure<App_Settings>(configuration.GetSection(nameof(App_Settings)));
        
               })
    .ConfigureLogging(logging =>
     {
         logging.ClearProviders();
         logging.AddConsole();
     }).Build();
host.Run();
