using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class TeamTests
    {
        [Fact]
        public void Team_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedId = "test_id";

            // Act
            team.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, team.Id);
        }

        [Fact]
        public void Team_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedName = "test_name";

            // Act
            team.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, team.Name);
        }

        [Fact]
        public void Team_ColorProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedColor = "test_color";

            // Act
            team.Color = expectedColor;

            // Assert
            Assert.Equal(expectedColor, team.Color);
        }

        [Fact]
        public void Team_AvatarProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedAvatar = "test_avatar";

            // Act
            team.Avatar = expectedAvatar;

            // Assert
            Assert.Equal(expectedAvatar, team.Avatar);
        }

        [Fact]
        public void Team_IsAdminProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedIsAdmin = true;

            // Act
            team.IsAdmin = expectedIsAdmin;

            // Assert
            Assert.Equal(expectedIsAdmin, team.IsAdmin);
        }

        [Fact]
        public void Team_IsOwnerProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedIsOwner = true;

            // Act
            team.IsOwner = expectedIsOwner;

            // Assert
            Assert.Equal(expectedIsOwner, team.IsOwner);
        }

        [Fact]
        public void Team_IsGuestProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedIsGuest = true;

            // Act
            team.IsGuest = expectedIsGuest;

            // Assert
            Assert.Equal(expectedIsGuest, team.IsGuest);
        }

        [Fact]
        public void Team_IsMemberProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedIsMember = true;

            // Act
            team.IsMember = expectedIsMember;

            // Assert
            Assert.Equal(expectedIsMember, team.IsMember);
        }

        [Fact]
        public void Team_IsPendingProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedIsPending = true;

            // Act
            team.IsPending = expectedIsPending;

            // Assert
            Assert.Equal(expectedIsPending, team.IsPending);
        }

        [Fact]
        public void Team_IsExternalProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedIsExternal = true;

            // Act
            team.IsExternal = expectedIsExternal;

            // Assert
            Assert.Equal(expectedIsExternal, team.IsExternal);
        }

        [Fact]
        public void Team_IsDeletedProperty_ShouldGetAndSet()
        {
            // Arrange
            var team = new Team();
            var expectedIsDeleted = true;

            // Act
            team.IsDeleted = expectedIsDeleted;

            // Assert
            Assert.Equal(expectedIsDeleted, team.IsDeleted);
        }
    }
}
