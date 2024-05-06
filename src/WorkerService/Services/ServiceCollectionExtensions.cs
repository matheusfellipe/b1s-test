using Infrastructure;
using System.Reflection;

namespace WorkerService.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddTransient<IInventoryGenEntriesService, InventoryGenEntriesService>( );
            

            return services;
        }
    }
}
