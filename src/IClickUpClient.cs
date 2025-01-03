using System.Threading.Tasks;

namespace ClickUpApi
{
    public interface IClickUpClient
    {
        Task<string> CreateTaskAsync(string listId, string taskName, string taskDescription);
        Task<string> GetTaskAsync(string taskId);
        Task<string> UpdateTaskAsync(string taskId, string taskName, string taskDescription);
        Task DeleteTaskAsync(string taskId);
        Task<string> GetAuthorizedUserAsync();
        Task<string> GetAuthorizedTeamsAsync();
    }
}
