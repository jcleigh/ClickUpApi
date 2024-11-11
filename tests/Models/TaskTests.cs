using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class TaskTests
    {
        [Fact]
        public void Task_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedId = "test_id";

            // Act
            task.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, task.Id);
        }

        [Fact]
        public void Task_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedName = "test_name";

            // Act
            task.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, task.Name);
        }

        [Fact]
        public void Task_DescriptionProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedDescription = "test_description";

            // Act
            task.Description = expectedDescription;

            // Assert
            Assert.Equal(expectedDescription, task.Description);
        }

        [Fact]
        public void Task_StatusProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedStatus = "test_status";

            // Act
            task.Status = expectedStatus;

            // Assert
            Assert.Equal(expectedStatus, task.Status);
        }

        [Fact]
        public void Task_PriorityProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedPriority = 1;

            // Act
            task.Priority = expectedPriority;

            // Assert
            Assert.Equal(expectedPriority, task.Priority);
        }

        [Fact]
        public void Task_DueDateProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedDueDate = 1234567890L;

            // Act
            task.DueDate = expectedDueDate;

            // Assert
            Assert.Equal(expectedDueDate, task.DueDate);
        }

        [Fact]
        public void Task_DueDateTimeProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedDueDateTime = true;

            // Act
            task.DueDateTime = expectedDueDateTime;

            // Assert
            Assert.Equal(expectedDueDateTime, task.DueDateTime);
        }

        [Fact]
        public void Task_StartDateProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedStartDate = 1234567890L;

            // Act
            task.StartDate = expectedStartDate;

            // Assert
            Assert.Equal(expectedStartDate, task.StartDate);
        }

        [Fact]
        public void Task_StartDateTimeProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedStartDateTime = true;

            // Act
            task.StartDateTime = expectedStartDateTime;

            // Assert
            Assert.Equal(expectedStartDateTime, task.StartDateTime);
        }

        [Fact]
        public void Task_NotifyAllProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedNotifyAll = true;

            // Act
            task.NotifyAll = expectedNotifyAll;

            // Assert
            Assert.Equal(expectedNotifyAll, task.NotifyAll);
        }

        [Fact]
        public void Task_ParentProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedParent = "test_parent";

            // Act
            task.Parent = expectedParent;

            // Assert
            Assert.Equal(expectedParent, task.Parent);
        }

        [Fact]
        public void Task_LinksToProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedLinksTo = "test_links_to";

            // Act
            task.LinksTo = expectedLinksTo;

            // Assert
            Assert.Equal(expectedLinksTo, task.LinksTo);
        }

        [Fact]
        public void Task_CustomFieldsProperty_ShouldGetAndSet()
        {
            // Arrange
            var task = new Task();
            var expectedCustomFields = new CustomField[]
            {
                    new CustomField { Id = "field1" },
                    new CustomField { Id = "field2" }
            };

            // Act
            task.CustomFields = expectedCustomFields;

            // Assert
            Assert.Equal(expectedCustomFields, task.CustomFields);
        }
    }
}
