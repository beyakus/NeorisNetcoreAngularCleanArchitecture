using System;
using System.IO;
using NeorisNetcoreAngularCleanArchitecture.Application.Services;
using NeorisNetcoreAngularCleanArchitecture.Core.CustomEntities;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Repositories;
using NeorisNetcoreAngularCleanArchitecture.Core.Interfaces.Services;
using NeorisNetcoreAngularCleanArchitecture.Infrastructure.Data;
using NeorisNetcoreAngularCleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace NeorisNetcoreAngularCleanArchitecture.Infrastructure.Extensions
{
    public static class ServiceCollactionExtension
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<CaimanDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("CAIMANDB"));
            });
            return services;
        }

        public static IServiceCollection AddDefaultConfigurations(this IServiceCollection services,  IConfiguration Configuration)
        {
            services.Configure<PaginationConfiguration>(Configuration.GetSection("Pagination"));
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
        public static IServiceCollection AddSwagger(this IServiceCollection services, string xmlFile)
        {
             services.AddSwaggerGen(options =>{
                options.SwaggerDoc("V1", new OpenApiInfo() {Title = "Caiman API", Version = "V1"});
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
            return services;
        }
    }
}