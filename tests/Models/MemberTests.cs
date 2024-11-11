using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class MemberTests
    {
        [Fact]
        public void Member_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var member = new Member();
            var expectedId = "test_id";

            // Act
            member.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, member.Id);
        }

        [Fact]
        public void Member_UsernameProperty_ShouldGetAndSet()
        {
            // Arrange
            var member = new Member();
            var expectedUsername = "test_username";

            // Act
            member.Username = expectedUsername;

            // Assert
            Assert.Equal(expectedUsername, member.Username);
        }

        [Fact]
        public void Member_EmailProperty_ShouldGetAndSet()
        {
            // Arrange
            var member = new Member();
            var expectedEmail = "test_email";

            // Act
            member.Email = expectedEmail;

            // Assert
            Assert.Equal(expectedEmail, member.Email);
        }

        [Fact]
        public void Member_ColorProperty_ShouldGetAndSet()
        {
            // Arrange
            var member = new Member();
            var expectedColor = "test_color";

            // Act
            member.Color = expectedColor;

            // Assert
            Assert.Equal(expectedColor, member.Color);
        }

        [Fact]
        public void Member_InitialsProperty_ShouldGetAndSet()
        {
            // Arrange
            var member = new Member();
            var expectedInitials = "test_initials";

            // Act
            member.Initials = expectedInitials;

            // Assert
            Assert.Equal(expectedInitials, member.Initials);
        }

        [Fact]
        public void Member_ProfilePictureProperty_ShouldGetAndSet()
        {
            // Arrange
            var member = new Member();
            var expectedProfilePicture = "test_profile_picture";

            // Act
            member.ProfilePicture = expectedProfilePicture;

            // Assert
            Assert.Equal(expectedProfilePicture, member.ProfilePicture);
        }
    }
}
