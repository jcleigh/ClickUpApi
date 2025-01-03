using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using Xunit;
using ClickUpApi.Models;

namespace ClickUpApi.Tests
{
    public class ClickUpClientTests
    {
        private readonly Mock<HttpMessageHandler> _httpMessageHandlerMock;
        private readonly ClickUpClient _clickUpClient;
        private readonly string _personalApiToken = "test_personal_api_token";

        public ClickUpClientTests()
        {
            _httpMessageHandlerMock = new Mock<HttpMessageHandler>();
            var httpClient = new HttpClient(_httpMessageHandlerMock.Object);
            _clickUpClient = new ClickUpClient(httpClient, _personalApiToken);
        }

        [Fact]
        public async Task CreateTaskAsync_ReturnsTaskId()
        {
            // Arrange
            var listId = "test_list_id";
            var taskName = "test_task_name";
            var taskDescription = "test_task_description";
            var expectedTask = new Task
            {
                Id = "test_task_id",
                Name = taskName,
                Description = taskDescription
            };

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"id\": \"{expectedTask.Id}\", \"name\": \"{expectedTask.Name}\", \"description\": \"{expectedTask.Description}\"}}")
                });

            // Act
            var task = await _clickUpClient.CreateTaskAsync(listId, taskName, taskDescription);

            // Assert
            Assert.Equal(expectedTask.Id, task.Id);
            Assert.Equal(expectedTask.Name, task.Name);
            Assert.Equal(expectedTask.Description, task.Description);
        }

        [Fact]
        public async Task GetTaskAsync_ReturnsTaskName()
        {
            // Arrange
            var taskId = "test_task_id";
            var expectedTask = new Task
            {
                Id = taskId,
                Name = "test_task_name"
            };

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"id\": \"{expectedTask.Id}\", \"name\": \"{expectedTask.Name}\"}}")
                });

            // Act
            var task = await _clickUpClient.GetTaskAsync(taskId);

            // Assert
            Assert.Equal(expectedTask.Id, task.Id);
            Assert.Equal(expectedTask.Name, task.Name);
        }

        [Fact]
        public async Task UpdateTaskAsync_ReturnsUpdatedTaskId()
        {
            // Arrange
            var taskId = "test_task_id";
            var taskName = "updated_task_name";
            var taskDescription = "updated_task_description";
            var expectedTask = new Task
            {
                Id = taskId,
                Name = taskName,
                Description = taskDescription
            };

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"id\": \"{expectedTask.Id}\", \"name\": \"{expectedTask.Name}\", \"description\": \"{expectedTask.Description}\"}}")
                });

            // Act
            var updatedTask = await _clickUpClient.UpdateTaskAsync(taskId, taskName, taskDescription);

            // Assert
            Assert.Equal(expectedTask.Id, updatedTask.Id);
            Assert.Equal(expectedTask.Name, updatedTask.Name);
            Assert.Equal(expectedTask.Description, updatedTask.Description);
        }

        [Fact]
        public async Task DeleteTaskAsync_DeletesTask()
        {
            // Arrange
            var taskId = "test_task_id";

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.NoContent
                });

            // Act
            await _clickUpClient.DeleteTaskAsync(taskId);

            // Assert
            _httpMessageHandlerMock.Protected().Verify(
                "SendAsync",
                Times.Once(),
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Delete && req.RequestUri == new System.Uri($"https://api.clickup.com/api/v2/task/{taskId}")),
                ItExpr.IsAny<CancellationToken>()
            );
        }

        [Fact]
        public async Task GetAuthorizedUserAsync_ReturnsUsername()
        {
            // Arrange
            var expectedUser = new User
            {
                Id = "test_user_id",
                Username = "test_username"
            };

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"id\": \"{expectedUser.Id}\", \"username\": \"{expectedUser.Username}\"}}")
                });

            // Act
            var user = await _clickUpClient.GetAuthorizedUserAsync();

            // Assert
            Assert.Equal(expectedUser.Id, user.Id);
            Assert.Equal(expectedUser.Username, user.Username);
        }

        [Fact]
        public async Task GetAuthorizedTeamsAsync_ReturnsTeams()
        {
            // Arrange
            var expectedTeams = new[]
            {
                new Team { Id = "team1" },
                new Team { Id = "team2" }
            };

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"teams\": [{string.Join(", ", expectedTeams.Select(t => $"{{\"id\": \"{t.Id}\"}}"))}]}}")
                });

            // Act
            var teams = await _clickUpClient.GetAuthorizedTeamsAsync();

            // Assert
            Assert.Equal(expectedTeams.Length, teams.Length);
            for (int i = 0; i < expectedTeams.Length; i++)
            {
                Assert.Equal(expectedTeams[i].Id, teams[i].Id);
            }
        }
    }
}
