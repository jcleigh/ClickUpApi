namespace ClickUpApi.Models
{
    public class View
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Grouping Grouping { get; set; }
        public Divide Divide { get; set; }
        public Sorting Sorting { get; set; }
        public Filters Filters { get; set; }
        public Columns Columns { get; set; }
        public TeamSidebar TeamSidebar { get; set; }
        public Settings Settings { get; set; }
    }

    public class Grouping
    {
        public string Field { get; set; }
        public int Dir { get; set; }
        public string[] Collapsed { get; set; }
        public bool Ignore { get; set; }
    }

    public class Divide
    {
        public string Field { get; set; }
        public int? Dir { get; set; }
        public string[] Collapsed { get; set; }
    }

    public class Sorting
    {
        public SortingField[] Fields { get; set; }
    }

    public class SortingField
    {
        public string Field { get; set; }
        public int Dir { get; set; }
    }

    public class Filters
    {
        public string Op { get; set; }
        public FilterField[] Fields { get; set; }
        public string Search { get; set; }
        public bool ShowClosed { get; set; }
    }

    public class FilterField
    {
        public string Field { get; set; }
        public string Op { get; set; }
        public object Value { get; set; }
    }

    public class Columns
    {
        public ColumnField[] Fields { get; set; }
    }

    public class ColumnField
    {
        public string Field { get; set; }
        public bool Visible { get; set; }
    }

    public class TeamSidebar
    {
        public string[] Assignees { get; set; }
        public bool AssignedComments { get; set; }
        public bool UnassignedTasks { get; set; }
    }

    public class Settings
    {
        public bool ShowTaskLocations { get; set; }
        public int ShowSubtasks { get; set; }
        public bool ShowSubtaskParentNames { get; set; }
        public bool ShowClosedSubtasks { get; set; }
        public bool ShowAssignees { get; set; }
        public bool ShowImages { get; set; }
        public bool? CollapseEmptyColumns { get; set; }
        public bool MeComments { get; set; }
        public bool MeSubtasks { get; set; }
        public bool MeChecklists { get; set; }
    }
}
