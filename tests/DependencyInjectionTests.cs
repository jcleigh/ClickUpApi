using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ClickUpApi.Tests
{
    public class DependencyInjectionTests
    {
        [Fact]
        public void AddClickUpClient_RegistersIClickUpClient()
        {
            // Arrange
            var services = new ServiceCollection();
            var personalApiToken = "test-token";

            // Act
            services.AddClickUpClient(personalApiToken);
            var serviceProvider = services.BuildServiceProvider();
            var client = serviceProvider.GetService<IClickUpClient>();

            // Assert
            Assert.NotNull(client);
            Assert.IsType<ClickUpClient>(client);
        }
    }
}
