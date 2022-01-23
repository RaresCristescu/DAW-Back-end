using Microsoft.Extensions.DependencyInjection;
using proiect.Repositories.DatabaseRepository;
using proiect.Services.DemoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Utilities.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IDatabaseRepository, DatabaseRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IDemoService, DemoService>();
            return services;
        }
    }
}
