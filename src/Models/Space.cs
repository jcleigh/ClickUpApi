namespace ClickUpApi.Models
{
    public class Space
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public bool Private { get; set; }
        public bool AdminCanManage { get; set; }
        public bool MultipleAssignees { get; set; }
        public Features Features { get; set; }
    }

    public class Features
    {
        public DueDates DueDates { get; set; }
        public TimeTracking TimeTracking { get; set; }
        public Tags Tags { get; set; }
        public TimeEstimates TimeEstimates { get; set; }
        public Checklists Checklists { get; set; }
        public CustomFields CustomFields { get; set; }
        public RemapDependencies RemapDependencies { get; set; }
        public DependencyWarning DependencyWarning { get; set; }
        public Portfolios Portfolios { get; set; }
    }

    public class DueDates
    {
        public bool Enabled { get; set; }
        public bool StartDate { get; set; }
        public bool RemapDueDates { get; set; }
        public bool RemapClosedDueDate { get; set; }
    }

    public class TimeTracking
    {
        public bool Enabled { get; set; }
    }

    public class Tags
    {
        public bool Enabled { get; set; }
    }

    public class TimeEstimates
    {
        public bool Enabled { get; set; }
    }

    public class Checklists
    {
        public bool Enabled { get; set; }
    }

    public class CustomFields
    {
        public bool Enabled { get; set; }
    }

    public class RemapDependencies
    {
        public bool Enabled { get; set; }
    }

    public class DependencyWarning
    {
        public bool Enabled { get; set; }
    }

    public class Portfolios
    {
        public bool Enabled { get; set; }
    }
}
