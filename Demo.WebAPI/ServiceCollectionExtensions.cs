using Demo.Application;
using Demo.Infrastructure;

namespace Demo.WebAPI
{

    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddWebAPIServices(this IServiceCollection services)
        {
            services.AddControllers();
            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddHttpContextAccessor();

            services.AddApplicationServices();
            services.AddInfrastructureServices();

            return services;
        }

    }

}
