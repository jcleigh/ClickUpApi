using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class CustomFieldTests
    {
        [Fact]
        public void CustomField_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var customField = new CustomField();
            var expectedId = "test_id";

            // Act
            customField.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, customField.Id);
        }

        [Fact]
        public void CustomField_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var customField = new CustomField();
            var expectedName = "test_name";

            // Act
            customField.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, customField.Name);
        }

        [Fact]
        public void CustomField_TypeProperty_ShouldGetAndSet()
        {
            // Arrange
            var customField = new CustomField();
            var expectedType = "test_type";

            // Act
            customField.Type = expectedType;

            // Assert
            Assert.Equal(expectedType, customField.Type);
        }

        [Fact]
        public void CustomField_TypeConfigProperty_ShouldGetAndSet()
        {
            // Arrange
            var customField = new CustomField();
            var expectedTypeConfig = new { key = "value" };

            // Act
            customField.TypeConfig = expectedTypeConfig;

            // Assert
            Assert.Equal(expectedTypeConfig, customField.TypeConfig);
        }

        [Fact]
        public void CustomField_DateCreatedProperty_ShouldGetAndSet()
        {
            // Arrange
            var customField = new CustomField();
            var expectedDateCreated = 1234567890L;

            // Act
            customField.DateCreated = expectedDateCreated;

            // Assert
            Assert.Equal(expectedDateCreated, customField.DateCreated);
        }

        [Fact]
        public void CustomField_HideFromGuestsProperty_ShouldGetAndSet()
        {
            // Arrange
            var customField = new CustomField();
            var expectedHideFromGuests = true;

            // Act
            customField.HideFromGuests = expectedHideFromGuests;

            // Assert
            Assert.Equal(expectedHideFromGuests, customField.HideFromGuests);
        }

        [Fact]
        public void CustomField_RequiredProperty_ShouldGetAndSet()
        {
            // Arrange
            var customField = new CustomField();
            var expectedRequired = true;

            // Act
            customField.Required = expectedRequired;

            // Assert
            Assert.Equal(expectedRequired, customField.Required);
        }
    }
}
