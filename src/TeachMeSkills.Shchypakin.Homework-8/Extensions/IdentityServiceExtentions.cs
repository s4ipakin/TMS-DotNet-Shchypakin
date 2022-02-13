using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.Data;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.Extensions
{
    public static class IdentityServiceExtentions
    {
        public static IServiceCollection AddIndentityServices(this IServiceCollection services, 
            IConfiguration config)
        {
            services.AddIdentityCore<Client>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                //opt.SignIn.RequireConfirmedPhoneNumber = true;

            })
                .AddRoles<AppRole>()
                .AddRoleManager<RoleManager<AppRole>>()
                .AddSignInManager<SignInManager<Client>>()
                .AddRoleValidator<RoleValidator<AppRole>>()
                .AddEntityFrameworkStores<DataContext>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"])),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };
                });

            return services;
        }
    }
}
