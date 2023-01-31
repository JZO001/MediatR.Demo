using Demo.Application.Common.Interfaces;
using Demo.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Infrastructure
{

    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserStore, UserStore>();
            return services;
        }

    }

}
