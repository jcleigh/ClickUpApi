using System.Threading.Tasks;

namespace ClickUpApi
{
    public interface IClickUpClient
    {
        Task<Models.Task> CreateTaskAsync(string listId, string taskName, string taskDescription);
        Task<Models.Task> GetTaskAsync(string taskId);
        Task<Models.Task> UpdateTaskAsync(string taskId, string taskName, string taskDescription);
        Task DeleteTaskAsync(string taskId);
        Task<Models.User> GetAuthorizedUserAsync();
        Task<Models.Team[]> GetAuthorizedTeamsAsync();
    }
}
