using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Demo.Application
{

    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }

    }

}
