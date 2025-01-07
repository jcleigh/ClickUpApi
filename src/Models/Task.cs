using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClickUpApi.Models
{
    public class Task
    {
        public bool Archived { get; set; }
        public List<Assignee> Assignees { get; set; }
        public List<Attachment> Attachments { get; set; }
        public List<object> Checklists { get; set; }
        public Creator Creator { get; set; }
        public List<CustomField> CustomFields { get; set; }
        public string CustomId { get; set; }
        public int? CustomItemId { get; set; }
        public object DateClosed { get; set; }
        public string DateCreated { get; set; }
        public object DateDone { get; set; }
        public string DateUpdated { get; set; }
        public List<object> Dependencies { get; set; }
        public string Description { get; set; }
        public object DueDate { get; set; }
        public Folder Folder { get; set; }
        public List<object> GroupAssignees { get; set; }
        public string Id { get; set; }
        public List<object> LinkedTasks { get; set; }
        public List List { get; set; }
        public List<Location> Locations { get; set; }
        public string Name { get; set; }
        public string Orderindex { get; set; }
        public string Parent { get; set; }
        public string PermissionLevel { get; set; }
        public double? Points { get; set; }
        [JsonPropertyName("priority")]
        public PriorityInfo Priority { get; set; }
        public Project Project { get; set; }
        public Sharing Sharing { get; set; }
        public Space Space { get; set; }
        public string StartDate { get; set; }
        [JsonPropertyName("status")]
        public StatusInfo Status { get; set; }
        public List<string> Tags { get; set; }
        public string TeamId { get; set; }
        public string TextContent { get; set; }
        public string TimeEstimate { get; set; }
        public string TimeSpent { get; set; }
        public string TopLevelParent { get; set; }
        public string Url { get; set; }
        public List<Watcher> Watchers { get; set; }
    }

    public class Assignee
    {
        public string Color { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string Initials { get; set; }
        public string ProfilePicture { get; set; }
        public string Username { get; set; }
    }

    public class Attachment
    {
        public string Date { get; set; }
        public bool Deleted { get; set; }
        public object EmailData { get; set; }
        public string Extension { get; set; }
        public bool Hidden { get; set; }
        public string Id { get; set; }
        public bool IsFolder { get; set; }
        public string Mimetype { get; set; }
        public string Orientation { get; set; }
        public string ParentId { get; set; }
        public int ResolvedComments { get; set; }
        public int Size { get; set; }
        public int Source { get; set; }
        public string ThumbnailLarge { get; set; }
        public string ThumbnailMedium { get; set; }
        public string ThumbnailSmall { get; set; }
        public string Title { get; set; }
        public int TotalComments { get; set; }
        public int Type { get; set; }
        public string Url { get; set; }
        public string UrlWHost { get; set; }
        public string UrlWQuery { get; set; }
        public User User { get; set; }
    }

    public class Creator
    {
        public string Color { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string ProfilePicture { get; set; }
        public string Username { get; set; }
    }

    public class Location
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class PriorityInfo
    {
        public string Color { get; set; }
        public string Id { get; set; }
        public string Orderindex { get; set; }
        public string Priority { get; set; }
    }

    public class Project
    {
        public bool Access { get; set; }
        public bool Hidden { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Sharing
    {
        public bool Public { get; set; }
        public List<string> PublicFields { get; set; }
        public object PublicShareExpiresOn { get; set; }
        public bool SeoOptimized { get; set; }
        public object Token { get; set; }
    }

    public class StatusInfo
    {
        public string Color { get; set; }
        public string Id { get; set; }
        public int Orderindex { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }

    public class Watcher
    {
        public string Color { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string Initials { get; set; }
        public string ProfilePicture { get; set; }
        public string Username { get; set; }
    }
}
