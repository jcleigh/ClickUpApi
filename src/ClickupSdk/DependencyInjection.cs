using Microsoft.Extensions.DependencyInjection;

namespace ClickupSdk
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddClickupClient(this IServiceCollection services)
        {
            services.AddHttpClient<IClickupClient, ClickupClient>();
            return services;
        }
    }
}
