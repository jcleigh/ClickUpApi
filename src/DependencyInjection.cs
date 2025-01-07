using Microsoft.Extensions.DependencyInjection;

namespace ClickUpApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddClickUpClient(this IServiceCollection services, string personalApiToken)
        {
            services.AddHttpClient<IClickUpClient, ClickUpClient>(client => new ClickUpClient(client, personalApiToken));
            return services;
        }
    }
}
