using ClickUpApi.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClickUpApi
{
    public class ClickUpClient(HttpClient httpClient, string personalApiToken) : IClickUpClient
    {
        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

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
            request.Headers.Add("Authorization", personalApiToken);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Models.Task>(content, _jsonOptions);
        }

        public async Task<Models.Task> GetTaskAsync(string taskId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.clickup.com/api/v2/task/{taskId}");
            request.Headers.Add("Authorization", personalApiToken);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var x = JsonSerializer.Deserialize<Models.Task>(content, _jsonOptions);
            return x;
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
            request.Headers.Add("Authorization", personalApiToken);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Models.Task>(content, _jsonOptions);
        }

        public async System.Threading.Tasks.Task DeleteTaskAsync(string taskId)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"https://api.clickup.com/api/v2/task/{taskId}");
            request.Headers.Add("Authorization", personalApiToken);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }

        public async Task<User> GetAuthorizedUserAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.clickup.com/api/v2/user");
            request.Headers.Add("Authorization", personalApiToken);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<User>(content, _jsonOptions);
        }

        public async Task<Team[]> GetAuthorizedTeamsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.clickup.com/api/v2/team");
            request.Headers.Add("Authorization", personalApiToken);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var jsonDocument = JsonDocument.Parse(content);
            return JsonSerializer.Deserialize<Team[]>(jsonDocument.RootElement.GetProperty("teams").ToString(), _jsonOptions);
        }
    }
}

