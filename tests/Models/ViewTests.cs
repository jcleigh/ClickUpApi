using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests.Models
{
    public class ViewTests
    {
        [Fact]
        public void View_IdProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedId = "test_id";

            // Act
            view.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, view.Id);
        }

        [Fact]
        public void View_NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedName = "test_name";

            // Act
            view.Name = expectedName;

            // Assert
            Assert.Equal(expectedName, view.Name);
        }

        [Fact]
        public void View_TypeProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedType = "test_type";

            // Act
            view.Type = expectedType;

            // Assert
            Assert.Equal(expectedType, view.Type);
        }

        [Fact]
        public void View_GroupingProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedGrouping = new Grouping
            {
                Field = "status",
                Dir = 1,
                Collapsed = new string[] { "collapsed1", "collapsed2" },
                Ignore = false
            };

            // Act
            view.Grouping = expectedGrouping;

            // Assert
            Assert.Equal(expectedGrouping, view.Grouping);
        }

        [Fact]
        public void View_DivideProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedDivide = new Divide
            {
                Field = "field",
                Dir = 1,
                Collapsed = new string[] { "collapsed1", "collapsed2" }
            };

            // Act
            view.Divide = expectedDivide;

            // Assert
            Assert.Equal(expectedDivide, view.Divide);
        }

        [Fact]
        public void View_SortingProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedSorting = new Sorting
            {
                Fields = new SortingField[]
                {
                    new SortingField { Field = "field1", Dir = 1 },
                    new SortingField { Field = "field2", Dir = -1 }
                }
            };

            // Act
            view.Sorting = expectedSorting;

            // Assert
            Assert.Equal(expectedSorting, view.Sorting);
        }

        [Fact]
        public void View_FiltersProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedFilters = new Filters
            {
                Op = "AND",
                Fields = new FilterField[]
                {
                    new FilterField { Field = "field1", Op = "=", Value = "value1" },
                    new FilterField { Field = "field2", Op = "!=", Value = "value2" }
                },
                Search = "search",
                ShowClosed = false
            };

            // Act
            view.Filters = expectedFilters;

            // Assert
            Assert.Equal(expectedFilters, view.Filters);
        }

        [Fact]
        public void View_ColumnsProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedColumns = new Columns
            {
                Fields = new ColumnField[]
                {
                    new ColumnField { Field = "field1", Visible = true },
                    new ColumnField { Field = "field2", Visible = false }
                }
            };

            // Act
            view.Columns = expectedColumns;

            // Assert
            Assert.Equal(expectedColumns, view.Columns);
        }

        [Fact]
        public void View_TeamSidebarProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedTeamSidebar = new TeamSidebar
            {
                Assignees = new string[] { "assignee1", "assignee2" },
                AssignedComments = false,
                UnassignedTasks = true
            };

            // Act
            view.TeamSidebar = expectedTeamSidebar;

            // Assert
            Assert.Equal(expectedTeamSidebar, view.TeamSidebar);
        }

        [Fact]
        public void View_SettingsProperty_ShouldGetAndSet()
        {
            // Arrange
            var view = new View();
            var expectedSettings = new Settings
            {
                ShowTaskLocations = false,
                ShowSubtasks = 3,
                ShowSubtaskParentNames = true,
                ShowClosedSubtasks = true,
                ShowAssignees = false,
                ShowImages = true,
                CollapseEmptyColumns = null,
                MeComments = true,
                MeSubtasks = true,
                MeChecklists = true
            };

            // Act
            view.Settings = expectedSettings;

            // Assert
            Assert.Equal(expectedSettings, view.Settings);
        }
    }
}
