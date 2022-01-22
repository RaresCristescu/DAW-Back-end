using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using proiect.Data;
using proiect.Models;
using proiect.Repositories.DatabaseRepository;
using proiect.Services.DemoService;

namespace proiect
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "proiect", Version = "v1" });
            });
            services.AddDbContext<ProiectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //repositories

            //created each time they are requested
            services.AddTransient<IDatabaseRepository, DatabaseRepository>();
            //They are created on the first request
            //services.AddSingleton<IDatabaseRepository, DatabaseRepository>();
            //Created once per client request (per http request)
            //services.AddScoped<IDatabaseRepository, DatabaseRepository>();

            //services
            services.AddTransient<IDemoService, DemoService>();
            //services.AddDbContext<ProiectContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "proiect v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
