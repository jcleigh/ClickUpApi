using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class UserTests
    {
        [Fact]
        public void User_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var user = new User();
            var expectedId = "test_id";

            // Act
            user.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, user.Id);
        }

        [Fact]
        public void User_UsernameProperty_ShouldGetAndSet()
        {
            // Arrange
            var user = new User();
            var expectedUsername = "test_username";

            // Act
            user.Username = expectedUsername;

            // Assert
            Assert.Equal(expectedUsername, user.Username);
        }

        [Fact]
        public void User_EmailProperty_ShouldGetAndSet()
        {
            // Arrange
            var user = new User();
            var expectedEmail = "test_email";

            // Act
            user.Email = expectedEmail;

            // Assert
            Assert.Equal(expectedEmail, user.Email);
        }

        [Fact]
        public void User_ColorProperty_ShouldGetAndSet()
        {
            // Arrange
            var user = new User();
            var expectedColor = "test_color";

            // Act
            user.Color = expectedColor;

            // Assert
            Assert.Equal(expectedColor, user.Color);
        }

        [Fact]
        public void User_InitialsProperty_ShouldGetAndSet()
        {
            // Arrange
            var user = new User();
            var expectedInitials = "test_initials";

            // Act
            user.Initials = expectedInitials;

            // Assert
            Assert.Equal(expectedInitials, user.Initials);
        }

        [Fact]
        public void User_ProfilePictureProperty_ShouldGetAndSet()
        {
            // Arrange
            var user = new User();
            var expectedProfilePicture = "test_profile_picture";

            // Act
            user.ProfilePicture = expectedProfilePicture;

            // Assert
            Assert.Equal(expectedProfilePicture, user.ProfilePicture);
        }
    }
}
