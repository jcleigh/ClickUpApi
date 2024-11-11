namespace ClickUpApi.Models
{
    public class CustomField
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public object TypeConfig { get; set; }
        public long DateCreated { get; set; }
        public bool HideFromGuests { get; set; }
        public bool Required { get; set; }
    }
}
