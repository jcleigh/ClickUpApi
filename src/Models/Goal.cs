namespace ClickUpApi.Models
{
    public class Goal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public long DueDate { get; set; }
        public string Description { get; set; }
        public bool MultipleOwners { get; set; }
        public int[] Owners { get; set; }
        public string Color { get; set; }
    }
}
