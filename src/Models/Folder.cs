namespace ClickUpApi.Models
{
    public class Folder
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Hidden { get; set; }
        public bool Archived { get; set; }
        public List[] Lists { get; set; }
    }
}
