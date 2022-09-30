using Application.Distance.Queries.GetDistance;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IRequestHandler<GetDistanceQuery, double>, GetDistanceQueryHandler>();

            return services;
        }
    }
}
