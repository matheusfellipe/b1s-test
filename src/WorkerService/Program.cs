using Infra.B1SLayer;
using WorkerService;
using WorkerService.Services;


var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddServices();
        services.AddB1SLayer(config);
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
