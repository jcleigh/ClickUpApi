using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class DependencyTests
    {
        [Fact]
        public void Dependency_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var dependency = new Dependency();
            var expectedId = "test_id";

            // Act
            dependency.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, dependency.Id);
        }

        [Fact]
        public void Dependency_DependsOnProperty_ShouldGetAndSet()
        {
            // Arrange
            var dependency = new Dependency();
            var expectedDependsOn = "test_depends_on";

            // Act
            dependency.DependsOn = expectedDependsOn;

            // Assert
            Assert.Equal(expectedDependsOn, dependency.DependsOn);
        }

        [Fact]
        public void Dependency_DependencyOfProperty_ShouldGetAndSet()
        {
            // Arrange
            var dependency = new Dependency();
            var expectedDependencyOf = "test_dependency_of";

            // Act
            dependency.DependencyOf = expectedDependencyOf;

            // Assert
            Assert.Equal(expectedDependencyOf, dependency.DependencyOf);
        }
    }
}
