using Microsoft.Extensions.DependencyInjection;
using proiect.Repositories.DatabaseRepository;
using proiect.Repositories.DatabaseRepository.AddressRepo;
using proiect.Repositories.DatabaseRepository.CategorieRepo;
using proiect.Repositories.DatabaseRepository.ProdusRepo;
using proiect.Services.AddressService;
using proiect.Services.CategorieServ;
using proiect.Services.DemoService;
using proiect.Services.ProdusServ;
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
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<ICategorieRepository, CategorieRepository>();
            services.AddTransient<IProdusRepository, ProdusRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IDemoService, DemoService>();
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<ICategorieService, CategorieService>();
            services.AddTransient<IProdusService, ProdusService>();
            return services;
        }
        
    }
}
