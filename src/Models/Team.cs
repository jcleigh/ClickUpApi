namespace ClickUpApi.Models
{
    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Avatar { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsOwner { get; set; }
        public bool IsGuest { get; set; }
        public bool IsMember { get; set; }
        public bool IsPending { get; set; }
        public bool IsExternal { get; set; }
        public bool IsDeleted { get; set; }
    }
}
