namespace ClickUpApi.Models
{
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
}
