namespace ClickupSdk.Models
{
    public class Checklist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public ChecklistItem[] Items { get; set; }
    }

    public class ChecklistItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public bool Resolved { get; set; }
        public string Assignee { get; set; }
    }
}
