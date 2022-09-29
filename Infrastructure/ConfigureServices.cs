using Application;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace GeoDistance.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IDistanceFactory, DistanceFactory>();

            return services;
        }
    }
}
