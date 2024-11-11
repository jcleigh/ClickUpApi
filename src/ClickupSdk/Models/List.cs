namespace ClickupSdk.Models
{
    public class List
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public long DueDate { get; set; }
        public bool DueDateTime { get; set; }
        public int Priority { get; set; }
        public string Assignee { get; set; }
        public string Status { get; set; }
    }
}
