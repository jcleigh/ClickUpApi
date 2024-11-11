using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class RoleTests
    {
        [Fact]
        public void Role_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var role = new Role();
            var expectedId = "test_id";

            // Act
            role.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, role.Id);
        }

        [Fact]
        public void Role_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var role = new Role();
            var expectedName = "test_name";

            // Act
            role.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, role.Name);
        }

        [Fact]
        public void Role_ColorProperty_ShouldGetAndSet()
        {
            // Arrange
            var role = new Role();
            var expectedColor = "test_color";

            // Act
            role.Color = expectedColor;

            // Assert
            Assert.Equal(expectedColor, role.Color);
        }

        [Fact]
        public void Role_TypeProperty_ShouldGetAndSet()
        {
            // Arrange
            var role = new Role();
            var expectedType = "test_type";

            // Act
            role.Type = expectedType;

            // Assert
            Assert.Equal(expectedType, role.Type);
        }

        [Fact]
        public void Role_DescriptionProperty_ShouldGetAndSet()
        {
            // Arrange
            var role = new Role();
            var expectedDescription = "test_description";

            // Act
            role.Description = expectedDescription;

            // Assert
            Assert.Equal(expectedDescription, role.Description);
        }
    }
}
