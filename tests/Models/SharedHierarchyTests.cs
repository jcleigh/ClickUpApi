using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class SharedHierarchyTests
    {
        [Fact]
        public void SharedHierarchy_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var sharedHierarchy = new SharedHierarchy();
            var expectedId = "test_id";

            // Act
            sharedHierarchy.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, sharedHierarchy.Id);
        }

        [Fact]
        public void SharedHierarchy_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var sharedHierarchy = new SharedHierarchy();
            var expectedName = "test_name";

            // Act
            sharedHierarchy.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, sharedHierarchy.Name);
        }

        [Fact]
        public void SharedHierarchy_TypeProperty_ShouldGetAndSet()
        {
            // Arrange
            var sharedHierarchy = new SharedHierarchy();
            var expectedType = "test_type";

            // Act
            sharedHierarchy.Type = expectedType;

            // Assert
            Assert.Equal(expectedType, sharedHierarchy.Type);
        }

        [Fact]
        public void SharedHierarchy_HiddenProperty_ShouldGetAndSet()
        {
            // Arrange
            var sharedHierarchy = new SharedHierarchy();
            var expectedHidden = true;

            // Act
            sharedHierarchy.Hidden = expectedHidden;

            // Assert
            Assert.Equal(expectedHidden, sharedHierarchy.Hidden);
        }

        [Fact]
        public void SharedHierarchy_ArchivedProperty_ShouldGetAndSet()
        {
            // Arrange
            var sharedHierarchy = new SharedHierarchy();
            var expectedArchived = true;

            // Act
            sharedHierarchy.Archived = expectedArchived;

            // Assert
            Assert.Equal(expectedArchived, sharedHierarchy.Archived);
        }

        [Fact]
        public void SharedHierarchy_ListsProperty_ShouldGetAndSet()
        {
            // Arrange
            var sharedHierarchy = new SharedHierarchy();
            var expectedLists = new List[]
            {
                new List { Id = "list1", Name = "List 1" },
                new List { Id = "list2", Name = "List 2" }
            };

            // Act
            sharedHierarchy.Lists = expectedLists;

            // Assert
            Assert.Equal(expectedLists, sharedHierarchy.Lists);
        }

        [Fact]
        public void SharedHierarchy_FoldersProperty_ShouldGetAndSet()
        {
            // Arrange
            var sharedHierarchy = new SharedHierarchy();
            var expectedFolders = new Folder[]
            {
                new Folder { Id = "folder1", Name = "Folder 1" },
                new Folder { Id = "folder2", Name = "Folder 2" }
            };

            // Act
            sharedHierarchy.Folders = expectedFolders;

            // Assert
            Assert.Equal(expectedFolders, sharedHierarchy.Folders);
        }

        [Fact]
        public void SharedHierarchy_SpacesProperty_ShouldGetAndSet()
        {
            // Arrange
            var sharedHierarchy = new SharedHierarchy();
            var expectedSpaces = new Space[]
            {
                new Space { Id = "space1", Name = "Space 1" },
                new Space { Id = "space2", Name = "Space 2" }
            };

            // Act
            sharedHierarchy.Spaces = expectedSpaces;

            // Assert
            Assert.Equal(expectedSpaces, sharedHierarchy.Spaces);
        }
    }
}
