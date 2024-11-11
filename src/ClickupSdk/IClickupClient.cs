using System.Threading.Tasks;

namespace ClickupSdk
{
    public interface IClickupClient
    {
        Task<string> AuthenticateAsync(string clientId, string clientSecret, string code);
        Task<string> CreateTaskAsync(string listId, string taskName, string taskDescription);
        Task<string> GetTaskAsync(string taskId);
        Task<string> UpdateTaskAsync(string taskId, string taskName, string taskDescription);
        Task DeleteTaskAsync(string taskId);
        Task<string> GetAuthorizedUserAsync();
        Task<string> GetAuthorizedTeamsAsync();
    }
}
