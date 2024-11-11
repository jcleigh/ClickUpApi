namespace ClickUpApi.Models
{
    public class Dependency
    {
        public string Id { get; set; }
        public string DependsOn { get; set; }
        public string DependencyOf { get; set; }
    }
}
