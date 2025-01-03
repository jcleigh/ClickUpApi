using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClickUpApi.Models;

namespace ClickUpApi
{
    public class ClickUpClient(HttpClient httpClient, string personalApiToken) : IClickUpClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _personalApiToken;

        public ClickUpClient(HttpClient httpClient, string personalApiToken)
        {
            _httpClient = httpClient;
            _personalApiToken = personalApiToken;
        }

        public async Task<Models.Task> CreateTaskAsync(string listId, string taskName, string taskDescription)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"https://api.clickup.com/api/v2/list/{listId}/task")
            {
                Content = new StringContent(JsonSerializer.Serialize(new
                {
                    name = taskName,
                    description = taskDescription
                }), Encoding.UTF8, "application/json")
            };
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Models.Task>(content);
        }

        public async Task<Models.Task> GetTaskAsync(string taskId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.clickup.com/api/v2/task/{taskId}");
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Models.Task>(content);
        }

        public async Task<Models.Task> UpdateTaskAsync(string taskId, string taskName, string taskDescription)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, $"https://api.clickup.com/api/v2/task/{taskId}")
            {
                Content = new StringContent(JsonSerializer.Serialize(new
                {
                    name = taskName,
                    description = taskDescription
                }), Encoding.UTF8, "application/json")
            };
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Models.Task>(content);
        }

        public async Task DeleteTaskAsync(string taskId)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"https://api.clickup.com/api/v2/task/{taskId}");
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }

        public async Task<Models.User> GetAuthorizedUserAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.clickup.com/api/v2/user");
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Models.User>(content);
        }

        public async Task<Models.Team[]> GetAuthorizedTeamsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.clickup.com/api/v2/team");
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var jsonDocument = JsonDocument.Parse(content);
            return JsonSerializer.Deserialize<Models.Team[]>(jsonDocument.RootElement.GetProperty("teams").ToString());
        }
    }
}
