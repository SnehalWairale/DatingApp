using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interface;
using API.Services;
using Microsoft.EntityFrameworkCore;
using API.Data;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
         public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
         {
             services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options=>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultCOnnection"));

            });

            return services;
         }
    }
}