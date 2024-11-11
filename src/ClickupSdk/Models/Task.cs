namespace ClickupSdk.Models
{
    public class Task
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public long DueDate { get; set; }
        public bool DueDateTime { get; set; }
        public long StartDate { get; set; }
        public bool StartDateTime { get; set; }
        public bool NotifyAll { get; set; }
        public string Parent { get; set; }
        public string LinksTo { get; set; }
        public CustomField[] CustomFields { get; set; }
    }
}
