using Microsoft.Extensions.DependencyInjection;

namespace ClickUpApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddClickUpClient(this IServiceCollection services)
        {
            services.AddHttpClient<IClickUpClient, ClickUpClient>();
            return services;
        }
    }
}
