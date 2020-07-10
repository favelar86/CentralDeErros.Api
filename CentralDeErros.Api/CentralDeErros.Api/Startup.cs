using CentralDeErros.Api.Data.Map;
using CentralDeErros.Api.Data.Repository;
using CentralDeErros.Api.Domain.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CentralDeErros.Api
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

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IEnvironmentRepository, EnvironmentsRepository>();
            services.AddScoped<IErrorOccurrenceRepository, ErrorOccurrenceRepository>();
            services.AddScoped<IErrorRepository, ErrorRepository>();
            services.AddScoped<ILevelRepository, LevelRepository>();
            services.AddScoped<ISituationRepository, SituationRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            services.AddDbContext<Context>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MinhaConexao")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
