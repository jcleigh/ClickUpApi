using Xunit;
using ClickupSdk.Models;

namespace ClickupSdk.Tests.Models
{
    public class ChecklistTests
    {
        [Fact]
        public void Checklist_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklist = new Checklist();
            var expectedId = "test_id";

            // Act
            checklist.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, checklist.Id);
        }

        [Fact]
        public void Checklist_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklist = new Checklist();
            var expectedName = "test_name";

            // Act
            checklist.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, checklist.Name);
        }

        [Fact]
        public void Checklist_PositionProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklist = new Checklist();
            var expectedPosition = 1;

            // Act
            checklist.Position = expectedPosition;

            // Assert
            Assert.Equal(expectedPosition, checklist.Position);
        }

        [Fact]
        public void Checklist_ItemsProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklist = new Checklist();
            var expectedItems = new ChecklistItem[]
            {
                new ChecklistItem { Id = "item1", Name = "Item 1", Position = 1, Resolved = false, Assignee = "user1" },
                new ChecklistItem { Id = "item2", Name = "Item 2", Position = 2, Resolved = true, Assignee = "user2" }
            };

            // Act
            checklist.Items = expectedItems;

            // Assert
            Assert.Equal(expectedItems, checklist.Items);
        }

        [Fact]
        public void ChecklistItem_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklistItem = new ChecklistItem();
            var expectedId = "test_id";

            // Act
            checklistItem.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, checklistItem.Id);
        }

        [Fact]
        public void ChecklistItem_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklistItem = new ChecklistItem();
            var expectedName = "test_name";

            // Act
            checklistItem.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, checklistItem.Name);
        }

        [Fact]
        public void ChecklistItem_PositionProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklistItem = new ChecklistItem();
            var expectedPosition = 1;

            // Act
            checklistItem.Position = expectedPosition;

            // Assert
            Assert.Equal(expectedPosition, checklistItem.Position);
        }

        [Fact]
        public void ChecklistItem_ResolvedProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklistItem = new ChecklistItem();
            var expectedResolved = true;

            // Act
            checklistItem.Resolved = expectedResolved;

            // Assert
            Assert.Equal(expectedResolved, checklistItem.Resolved);
        }

        [Fact]
        public void ChecklistItem_AssigneeProperty_ShouldGetAndSet()
        {
            // Arrange
            var checklistItem = new ChecklistItem();
            var expectedAssignee = "test_assignee";

            // Act
            checklistItem.Assignee = expectedAssignee;

            // Assert
            Assert.Equal(expectedAssignee, checklistItem.Assignee);
        }
    }
}
