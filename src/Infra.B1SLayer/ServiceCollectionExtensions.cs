using B1SLayer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.B1SLayer
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddB1SLayer(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddSingleton(serviceLayer =>
            new Dictionary<string, SLConnection>()
            {
                { "KEY1", new SLConnection(configuration["SapServiceLayer:Url"], "BASE1", configuration["SapServiceLayer:UserName"],  configuration["SapServiceLayer:PassWord"]) },
                 { "KEY2", new SLConnection(configuration["SapServiceLayer:Url"],  "BASE2", configuration["SapServiceLayer:UserName"],  configuration["SapServiceLayer:PassWord"]) }

            });

            return services;
        }
    }
}
