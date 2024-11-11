using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class SpaceTests
    {
        [Fact]
        public void Space_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var space = new Space();
            var expectedId = "test_id";

            // Act
            space.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, space.Id);
        }

        [Fact]
        public void Space_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var space = new Space();
            var expectedName = "test_name";

            // Act
            space.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, space.Name);
        }

        [Fact]
        public void Space_ColorProperty_ShouldGetAndSet()
        {
            // Arrange
            var space = new Space();
            var expectedColor = "test_color";

            // Act
            space.Color = expectedColor;

            // Assert
            Assert.Equal(expectedColor, space.Color);
        }

        [Fact]
        public void Space_PrivateProperty_ShouldGetAndSet()
        {
            // Arrange
            var space = new Space();
            var expectedPrivate = true;

            // Act
            space.Private = expectedPrivate;

            // Assert
            Assert.Equal(expectedPrivate, space.Private);
        }

        [Fact]
        public void Space_AdminCanManageProperty_ShouldGetAndSet()
        {
            // Arrange
            var space = new Space();
            var expectedAdminCanManage = true;

            // Act
            space.AdminCanManage = expectedAdminCanManage;

            // Assert
            Assert.Equal(expectedAdminCanManage, space.AdminCanManage);
        }

        [Fact]
        public void Space_MultipleAssigneesProperty_ShouldGetAndSet()
        {
            // Arrange
            var space = new Space();
            var expectedMultipleAssignees = true;

            // Act
            space.MultipleAssignees = expectedMultipleAssignees;

            // Assert
            Assert.Equal(expectedMultipleAssignees, space.MultipleAssignees);
        }

        [Fact]
        public void Space_FeaturesProperty_ShouldGetAndSet()
        {
            // Arrange
            var space = new Space();
            var expectedFeatures = new Features
            {
                DueDates = new DueDates { Enabled = true, StartDate = false, RemapDueDates = true, RemapClosedDueDate = false },
                TimeTracking = new TimeTracking { Enabled = false },
                Tags = new Tags { Enabled = true },
                TimeEstimates = new TimeEstimates { Enabled = true },
                Checklists = new Checklists { Enabled = true },
                CustomFields = new CustomFields { Enabled = true },
                RemapDependencies = new RemapDependencies { Enabled = true },
                DependencyWarning = new DependencyWarning { Enabled = true },
                Portfolios = new Portfolios { Enabled = true }
            };

            // Act
            space.Features = expectedFeatures;

            // Assert
            Assert.Equal(expectedFeatures, space.Features);
        }

        [Fact]
        public void Features_DueDatesProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedDueDates = new DueDates { Enabled = true, StartDate = false, RemapDueDates = true, RemapClosedDueDate = false };

            // Act
            features.DueDates = expectedDueDates;

            // Assert
            Assert.Equal(expectedDueDates, features.DueDates);
        }

        [Fact]
        public void Features_TimeTrackingProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedTimeTracking = new TimeTracking { Enabled = true };

            // Act
            features.TimeTracking = expectedTimeTracking;

            // Assert
            Assert.Equal(expectedTimeTracking, features.TimeTracking);
        }

        [Fact]
        public void Features_TagsProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedTags = new Tags { Enabled = true };

            // Act
            features.Tags = expectedTags;

            // Assert
            Assert.Equal(expectedTags, features.Tags);
        }

        [Fact]
        public void Features_TimeEstimatesProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedTimeEstimates = new TimeEstimates { Enabled = true };

            // Act
            features.TimeEstimates = expectedTimeEstimates;

            // Assert
            Assert.Equal(expectedTimeEstimates, features.TimeEstimates);
        }

        [Fact]
        public void Features_ChecklistsProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedChecklists = new Checklists { Enabled = true };

            // Act
            features.Checklists = expectedChecklists;

            // Assert
            Assert.Equal(expectedChecklists, features.Checklists);
        }

        [Fact]
        public void Features_CustomFieldsProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedCustomFields = new CustomFields { Enabled = true };

            // Act
            features.CustomFields = expectedCustomFields;

            // Assert
            Assert.Equal(expectedCustomFields, features.CustomFields);
        }

        [Fact]
        public void Features_RemapDependenciesProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedRemapDependencies = new RemapDependencies { Enabled = true };

            // Act
            features.RemapDependencies = expectedRemapDependencies;

            // Assert
            Assert.Equal(expectedRemapDependencies, features.RemapDependencies);
        }

        [Fact]
        public void Features_DependencyWarningProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedDependencyWarning = new DependencyWarning { Enabled = true };

            // Act
            features.DependencyWarning = expectedDependencyWarning;

            // Assert
            Assert.Equal(expectedDependencyWarning, features.DependencyWarning);
        }

        [Fact]
        public void Features_PortfoliosProperty_ShouldGetAndSet()
        {
            // Arrange
            var features = new Features();
            var expectedPortfolios = new Portfolios { Enabled = true };

            // Act
            features.Portfolios = expectedPortfolios;

            // Assert
            Assert.Equal(expectedPortfolios, features.Portfolios);
        }
    }
}
