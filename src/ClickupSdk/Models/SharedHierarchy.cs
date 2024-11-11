namespace ClickupSdk.Models
{
    public class SharedHierarchy
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Hidden { get; set; }
        public bool Archived { get; set; }
        public List[] Lists { get; set; }
        public Folder[] Folders { get; set; }
        public Space[] Spaces { get; set; }
    }
}
