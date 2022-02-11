using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.Data;
using TeachMeSkills.Shchypakin.Homework_8.Helpers;
using TeachMeSkills.Shchypakin.Homework_8.Interfaces;
using TeachMeSkills.Shchypakin.Homework_8.Services;

namespace TeachMeSkills.Shchypakin.Homework_8.Extensions
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddAutoMapper(typeof(AutomapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            //services.AddDbContext<DataContext>(options =>
            //    options.UseSqlServer(config.GetConnectionString("ApplicationConnection")));

            return services;
        }
    }
}
