using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config, object JwtBearerDefaults)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthethenticationScheme).AddJWtBearer(options=>
            {
                options.TokenValidationParameters = new ValidationTokenParameters
                {
                    ValidateIssuerSigninKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(OpenApiEncoding.UTF8.GetBytes(_config["TokenKey"])),
                    ValidateIssuer = false,
                    ValidateAudience = false,    
                };
            });

            return services;
        }
    }
}