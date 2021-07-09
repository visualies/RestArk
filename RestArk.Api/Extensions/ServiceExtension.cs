using Microsoft.Extensions.DependencyInjection;
using RestArk.Core;
using RestArk.Core.Services;
using RestArk.Data;
using RestArk.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestArk.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void AddConfigurations(this IServiceCollection services)
        {
            services.AddSingleton(FileReaderService.GetConfig());
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IAchievementService, AchievementService>();
            services.AddScoped<IShopService, ShopService>();
        }
    }
}