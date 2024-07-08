using Microsoft.AspNetCore.Identity;
using UserManagementSystem.Models.DbConfig;
using UserManagementSystem.Models.Entities;
using UserManagementSystem.Services.Implementations;
using UserManagementSystem.Validators;

namespace UserManagementSystem.Extensions
{
    public static class StartupExtensions
    {
        public static void AddIdentityWithExt(this IServiceCollection services)
        {

            services.Configure<DataProtectionTokenProviderOptions>(options =>
            {
                options.TokenLifespan = TimeSpan.FromMinutes(10);
            });

            services.AddIdentity<FupiUser, IdentityRole>(Opt =>
            {
                Opt.User.RequireUniqueEmail = true;
                Opt.Password.RequiredUniqueChars = 0;
                Opt.Password.RequireNonAlphanumeric = false;
                Opt.Password.RequiredLength = 8;
                Opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                Opt.Lockout.MaxFailedAccessAttempts = 10;

            }).AddUserManager<CustomUserManager>().AddPasswordValidator<CustomPasswordValidator>().AddEntityFrameworkStores<FupiContext>().AddDefaultTokenProviders();
        }

    }
}
