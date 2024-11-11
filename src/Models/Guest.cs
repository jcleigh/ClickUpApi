namespace ClickUpApi.Models
{
    public class Guest
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool CanEditTags { get; set; }
        public bool CanSeeTimeEstimated { get; set; }
        public bool CanSeeTimeSpent { get; set; }
        public bool CanCreateViews { get; set; }
        public int CustomRoleId { get; set; }
    }
}
