using Xunit;
using ClickupSdk.Models;

namespace ClickupSdk.Tests.Models
{
    public class TimeEntryTests
    {
        [Fact]
        public void TimeEntry_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var timeEntry = new TimeEntry();
            var expectedId = "test_id";

            // Act
            timeEntry.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, timeEntry.Id);
        }

        [Fact]
        public void TimeEntry_DescriptionProperty_ShouldGetAndSet()
        {
            // Arrange
            var timeEntry = new TimeEntry();
            var expectedDescription = "test_description";

            // Act
            timeEntry.Description = expectedDescription;

            // Assert
            Assert.Equal(expectedDescription, timeEntry.Description);
        }

        [Fact]
        public void TimeEntry_TagsProperty_ShouldGetAndSet()
        {
            // Arrange
            var timeEntry = new TimeEntry();
            var expectedTags = new string[] { "tag1", "tag2" };

            // Act
            timeEntry.Tags = expectedTags;

            // Assert
            Assert.Equal(expectedTags, timeEntry.Tags);
        }

        [Fact]
        public void TimeEntry_StartProperty_ShouldGetAndSet()
        {
            // Arrange
            var timeEntry = new TimeEntry();
            var expectedStart = 1234567890L;

            // Act
            timeEntry.Start = expectedStart;

            // Assert
            Assert.Equal(expectedStart, timeEntry.Start);
        }

        [Fact]
        public void TimeEntry_EndProperty_ShouldGetAndSet()
        {
            // Arrange
            var timeEntry = new TimeEntry();
            var expectedEnd = 1234567890L;

            // Act
            timeEntry.End = expectedEnd;

            // Assert
            Assert.Equal(expectedEnd, timeEntry.End);
        }

        [Fact]
        public void TimeEntry_BillableProperty_ShouldGetAndSet()
        {
            // Arrange
            var timeEntry = new TimeEntry();
            var expectedBillable = true;

            // Act
            timeEntry.Billable = expectedBillable;

            // Assert
            Assert.Equal(expectedBillable, timeEntry.Billable);
        }

        [Fact]
        public void TimeEntry_DurationProperty_ShouldGetAndSet()
        {
            // Arrange
            var timeEntry = new TimeEntry();
            var expectedDuration = 1234567890L;

            // Act
            timeEntry.Duration = expectedDuration;

            // Assert
            Assert.Equal(expectedDuration, timeEntry.Duration);
        }

        [Fact]
        public void TimeEntry_AssigneeProperty_ShouldGetAndSet()
        {
            // Arrange
            var timeEntry = new TimeEntry();
            var expectedAssignee = "test_assignee";

            // Act
            timeEntry.Assignee = expectedAssignee;

            // Assert
            Assert.Equal(expectedAssignee, timeEntry.Assignee);
        }
    }
}
