using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class GuestTests
    {
        [Fact]
        public void Guest_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var guest = new Guest();
            var expectedId = "test_id";

            // Act
            guest.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, guest.Id);
        }

        [Fact]
        public void Guest_EmailProperty_ShouldGetAndSet()
        {
            // Arrange
            var guest = new Guest();
            var expectedEmail = "test_email";

            // Act
            guest.Email = expectedEmail;

            // Assert
            Assert.Equal(expectedEmail, guest.Email);
        }

        [Fact]
        public void Guest_CanEditTagsProperty_ShouldGetAndSet()
        {
            // Arrange
            var guest = new Guest();
            var expectedCanEditTags = true;

            // Act
            guest.CanEditTags = expectedCanEditTags;

            // Assert
            Assert.Equal(expectedCanEditTags, guest.CanEditTags);
        }

        [Fact]
        public void Guest_CanSeeTimeEstimatedProperty_ShouldGetAndSet()
        {
            // Arrange
            var guest = new Guest();
            var expectedCanSeeTimeEstimated = true;

            // Act
            guest.CanSeeTimeEstimated = expectedCanSeeTimeEstimated;

            // Assert
            Assert.Equal(expectedCanSeeTimeEstimated, guest.CanSeeTimeEstimated);
        }

        [Fact]
        public void Guest_CanSeeTimeSpentProperty_ShouldGetAndSet()
        {
            // Arrange
            var guest = new Guest();
            var expectedCanSeeTimeSpent = true;

            // Act
            guest.CanSeeTimeSpent = expectedCanSeeTimeSpent;

            // Assert
            Assert.Equal(expectedCanSeeTimeSpent, guest.CanSeeTimeSpent);
        }

        [Fact]
        public void Guest_CanCreateViewsProperty_ShouldGetAndSet()
        {
            // Arrange
            var guest = new Guest();
            var expectedCanCreateViews = true;

            // Act
            guest.CanCreateViews = expectedCanCreateViews;

            // Assert
            Assert.Equal(expectedCanCreateViews, guest.CanCreateViews);
        }

        [Fact]
        public void Guest_CustomRoleIdProperty_ShouldGetAndSet()
        {
            // Arrange
            var guest = new Guest();
            var expectedCustomRoleId = 12345;

            // Act
            guest.CustomRoleId = expectedCustomRoleId;

            // Assert
            Assert.Equal(expectedCustomRoleId, guest.CustomRoleId);
        }
    }
}
