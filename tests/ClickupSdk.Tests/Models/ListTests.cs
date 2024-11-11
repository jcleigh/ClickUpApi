using Xunit;
using ClickupSdk.Models;

namespace ClickupSdk.Tests.Models
{
    public class ListTests
    {
        [Fact]
        public void List_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var list = new List();
            var expectedId = "test_id";

            // Act
            list.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, list.Id);
        }

        [Fact]
        public void List_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var list = new List();
            var expectedName = "test_name";

            // Act
            list.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, list.Name);
        }

        [Fact]
        public void List_ContentProperty_ShouldGetAndSet()
        {
            // Arrange
            var list = new List();
            var expectedContent = "test_content";

            // Act
            list.Content = expectedContent;

            // Assert
            Assert.Equal(expectedContent, list.Content);
        }

        [Fact]
        public void List_DueDateProperty_ShouldGetAndSet()
        {
            // Arrange
            var list = new List();
            var expectedDueDate = 1234567890L;

            // Act
            list.DueDate = expectedDueDate;

            // Assert
            Assert.Equal(expectedDueDate, list.DueDate);
        }

        [Fact]
        public void List_DueDateTimeProperty_ShouldGetAndSet()
        {
            // Arrange
            var list = new List();
            var expectedDueDateTime = true;

            // Act
            list.DueDateTime = expectedDueDateTime;

            // Assert
            Assert.Equal(expectedDueDateTime, list.DueDateTime);
        }

        [Fact]
        public void List_PriorityProperty_ShouldGetAndSet()
        {
            // Arrange
            var list = new List();
            var expectedPriority = 1;

            // Act
            list.Priority = expectedPriority;

            // Assert
            Assert.Equal(expectedPriority, list.Priority);
        }

        [Fact]
        public void List_AssigneeProperty_ShouldGetAndSet()
        {
            // Arrange
            var list = new List();
            var expectedAssignee = "test_assignee";

            // Act
            list.Assignee = expectedAssignee;

            // Assert
            Assert.Equal(expectedAssignee, list.Assignee);
        }

        [Fact]
        public void List_StatusProperty_ShouldGetAndSet()
        {
            // Arrange
            var list = new List();
            var expectedStatus = "test_status";

            // Act
            list.Status = expectedStatus;

            // Assert
            Assert.Equal(expectedStatus, list.Status);
        }
    }
}
