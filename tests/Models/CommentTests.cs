using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class CommentTests
    {
        [Fact]
        public void Comment_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var comment = new Comment();
            var expectedId = "test_id";

            // Act
            comment.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, comment.Id);
        }

        [Fact]
        public void Comment_CommentTextProperty_ShouldGetAndSet()
        {
            // Arrange
            var comment = new Comment();
            var expectedCommentText = "test_comment_text";

            // Act
            comment.CommentText = expectedCommentText;

            // Assert
            Assert.Equal(expectedCommentText, comment.CommentText);
        }

        [Fact]
        public void Comment_AssigneeProperty_ShouldGetAndSet()
        {
            // Arrange
            var comment = new Comment();
            var expectedAssignee = "test_assignee";

            // Act
            comment.Assignee = expectedAssignee;

            // Assert
            Assert.Equal(expectedAssignee, comment.Assignee);
        }

        [Fact]
        public void Comment_NotifyAllProperty_ShouldGetAndSet()
        {
            // Arrange
            var comment = new Comment();
            var expectedNotifyAll = true;

            // Act
            comment.NotifyAll = expectedNotifyAll;

            // Assert
            Assert.Equal(expectedNotifyAll, comment.NotifyAll);
        }

        [Fact]
        public void Comment_ResolvedProperty_ShouldGetAndSet()
        {
            // Arrange
            var comment = new Comment();
            var expectedResolved = true;

            // Act
            comment.Resolved = expectedResolved;

            // Assert
            Assert.Equal(expectedResolved, comment.Resolved);
        }
    }
}
