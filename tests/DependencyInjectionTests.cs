using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ClickUpApi.Tests
{
    public class DependencyInjectionTest
    {
        [Fact]
        public void AddClickUpClient_RegistersIClickUpClientWithHttpClient()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddClickUpClient();

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var client = serviceProvider.GetService<IClickUpClient>();
            Assert.NotNull(client);
            Assert.IsType<ClickUpClient>(client);
        }
    }
}