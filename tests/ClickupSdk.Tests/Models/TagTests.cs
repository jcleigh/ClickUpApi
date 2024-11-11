using Xunit;
using ClickupSdk.Models;

namespace ClickupSdk.Tests.Models
{
    public class TagTests
    {
        [Fact]
        public void Tag_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var tag = new Tag();
            var expectedName = "test_name";

            // Act
            tag.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, tag.Name);
        }

        [Fact]
        public void Tag_TagFgProperty_ShouldGetAndSet()
        {
            // Arrange
            var tag = new Tag();
            var expectedTagFg = "#ffffff";

            // Act
            tag.TagFg = expectedTagFg;

            // Assert
            Assert.Equal(expectedTagFg, tag.TagFg);
        }

        [Fact]
        public void Tag_TagBgProperty_ShouldGetAndSet()
        {
            // Arrange
            var tag = new Tag();
            var expectedTagBg = "#000000";

            // Act
            tag.TagBg = expectedTagBg;

            // Assert
            Assert.Equal(expectedTagBg, tag.TagBg);
        }
    }
}
