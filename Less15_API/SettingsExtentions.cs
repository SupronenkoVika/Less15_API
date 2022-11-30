using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Less15_API
{
    public static class SettingsExtentions
    {
        public static IServiceCollection AddServerSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ServerSettings>(configuration.GetSection("GeneralSettings"));
            return services;
        }
    }
}
