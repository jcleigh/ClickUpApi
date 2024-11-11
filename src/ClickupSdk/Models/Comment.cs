namespace ClickupSdk.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string CommentText { get; set; }
        public string Assignee { get; set; }
        public bool NotifyAll { get; set; }
        public bool Resolved { get; set; }
    }
}
