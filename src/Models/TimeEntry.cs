namespace ClickUpApi.Models
{
    public class TimeEntry
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
        public long Start { get; set; }
        public long End { get; set; }
        public bool Billable { get; set; }
        public long Duration { get; set; }
        public string Assignee { get; set; }
    }
}
