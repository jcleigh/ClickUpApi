using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

        public async Task<string> CreateTaskAsync(string listId, string taskName, string taskDescription)
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
            var jsonDocument = JsonDocument.Parse(content);
            return jsonDocument.RootElement.GetProperty("id").GetString();
        }

        public async Task<string> GetTaskAsync(string taskId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.clickup.com/api/v2/task/{taskId}");
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var jsonDocument = JsonDocument.Parse(content);
            return jsonDocument.RootElement.GetProperty("name").GetString();
        }

        public async Task<string> UpdateTaskAsync(string taskId, string taskName, string taskDescription)
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
            var jsonDocument = JsonDocument.Parse(content);
            return jsonDocument.RootElement.GetProperty("id").GetString();
        }

        public async Task DeleteTaskAsync(string taskId)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"https://api.clickup.com/api/v2/task/{taskId}");
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }

        public async Task<string> GetAuthorizedUserAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.clickup.com/api/v2/user");
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var jsonDocument = JsonDocument.Parse(content);
            return jsonDocument.RootElement.GetProperty("username").GetString();
        }

        public async Task<string> GetAuthorizedTeamsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.clickup.com/api/v2/team");
            request.Headers.Add("Authorization", _personalApiToken);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var jsonDocument = JsonDocument.Parse(content);
            return jsonDocument.RootElement.GetProperty("teams").ToString();
        }
    }
}
