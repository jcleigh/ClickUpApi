using Xunit;
using ClickupSdk.Models;

namespace ClickupSdk.Tests.Models
{
    public class FolderTests
    {
        [Fact]
        public void Folder_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var folder = new Folder();
            var expectedId = "test_id";

            // Act
            folder.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, folder.Id);
        }

        [Fact]
        public void Folder_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var folder = new Folder();
            var expectedName = "test_name";

            // Act
            folder.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, folder.Name);
        }

        [Fact]
        public void Folder_HiddenProperty_ShouldGetAndSet()
        {
            // Arrange
            var folder = new Folder();
            var expectedHidden = true;

            // Act
            folder.Hidden = expectedHidden;

            // Assert
            Assert.Equal(expectedHidden, folder.Hidden);
        }

        [Fact]
        public void Folder_ArchivedProperty_ShouldGetAndSet()
        {
            // Arrange
            var folder = new Folder();
            var expectedArchived = true;

            // Act
            folder.Archived = expectedArchived;

            // Assert
            Assert.Equal(expectedArchived, folder.Archived);
        }

        [Fact]
        public void Folder_ListsProperty_ShouldGetAndSet()
        {
            // Arrange
            var folder = new Folder();
            var expectedLists = new List[]
            {
                new List { Id = "list1", Name = "List 1" },
                new List { Id = "list2", Name = "List 2" }
            };

            // Act
            folder.Lists = expectedLists;

            // Assert
            Assert.Equal(expectedLists, folder.Lists);
        }
    }
}
