using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class GoalTests
    {
        [Fact]
        public void Goal_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var goal = new Goal();
            var expectedId = "test_id";

            // Act
            goal.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, goal.Id);
        }

        [Fact]
        public void Goal_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var goal = new Goal();
            var expectedName = "test_name";

            // Act
            goal.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, goal.Name);
        }

        [Fact]
        public void Goal_DueDateProperty_ShouldGetAndSet()
        {
            // Arrange
            var goal = new Goal();
            var expectedDueDate = 1234567890L;

            // Act
            goal.DueDate = expectedDueDate;

            // Assert
            Assert.Equal(expectedDueDate, goal.DueDate);
        }

        [Fact]
        public void Goal_DescriptionProperty_ShouldGetAndSet()
        {
            // Arrange
            var goal = new Goal();
            var expectedDescription = "test_description";

            // Act
            goal.Description = expectedDescription;

            // Assert
            Assert.Equal(expectedDescription, goal.Description);
        }

        [Fact]
        public void Goal_MultipleOwnersProperty_ShouldGetAndSet()
        {
            // Arrange
            var goal = new Goal();
            var expectedMultipleOwners = true;

            // Act
            goal.MultipleOwners = expectedMultipleOwners;

            // Assert
            Assert.Equal(expectedMultipleOwners, goal.MultipleOwners);
        }

        [Fact]
        public void Goal_OwnersProperty_ShouldGetAndSet()
        {
            // Arrange
            var goal = new Goal();
            var expectedOwners = new int[] { 1, 2, 3 };

            // Act
            goal.Owners = expectedOwners;

            // Assert
            Assert.Equal(expectedOwners, goal.Owners);
        }

        [Fact]
        public void Goal_ColorProperty_ShouldGetAndSet()
        {
            // Arrange
            var goal = new Goal();
            var expectedColor = "#FFFFFF";

            // Act
            goal.Color = expectedColor;

            // Assert
            Assert.Equal(expectedColor, goal.Color);
        }
    }
}
