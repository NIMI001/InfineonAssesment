using InfineonAssesment.Domain;
using InfineonAssesment.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;

namespace InfineonAssesment.Extension
{
    public static class Extension
    {
        
            public static void ConfigureAppIdentity(this IServiceCollection services)
            {
                services.AddIdentity<User, IdentityRole>(o =>
                {
                    o.Password.RequireDigit = true;
                    o.Password.RequireLowercase = true;
                    o.Password.RequireUppercase = true;
                    o.Password.RequireNonAlphanumeric = false;
                    o.Password.RequiredLength = 8;
                    o.Password.RequiredUniqueChars = 1;
                    o.User.RequireUniqueEmail = true;
                })
                    .AddEntityFrameworkStores<InfineonContext>()
                    .AddDefaultTokenProviders();
                services.AddScoped<UserManager<User>>();
            }
        
    }
}
