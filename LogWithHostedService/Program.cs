
using LogWithHostedService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

Host.CreateDefaultBuilder(args)
    .ConfigureServices((ctx, services) => 
    {
        services.AddHostedService<SampleMainService>();

    })
    .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
                .WriteTo.Console())
    .Build()
    .Run();
