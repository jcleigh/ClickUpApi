namespace ClickUpApi.Models
{
    public class Space
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public bool Private { get; set; }
        public bool AdminCanManage { get; set; }
        public bool MultipleAssignees { get; set; }
        public Features Features { get; set; }
    }
}
