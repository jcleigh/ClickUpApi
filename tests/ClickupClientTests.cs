using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using Xunit;

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
            var expectedTaskId = "test_task_id";

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"id\": \"{expectedTaskId}\"}}")
                });

            // Act
            var taskId = await _clickUpClient.CreateTaskAsync(listId, taskName, taskDescription);

            // Assert
            Assert.Equal(expectedTaskId, taskId);
        }

        [Fact]
        public async Task GetTaskAsync_ReturnsTaskName()
        {
            // Arrange
            var taskId = "test_task_id";
            var expectedTaskName = "test_task_name";

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"name\": \"{expectedTaskName}\"}}")
                });

            // Act
            var taskName = await _clickUpClient.GetTaskAsync(taskId);

            // Assert
            Assert.Equal(expectedTaskName, taskName);
        }

        [Fact]
        public async Task UpdateTaskAsync_ReturnsUpdatedTaskId()
        {
            // Arrange
            var taskId = "test_task_id";
            var taskName = "updated_task_name";
            var taskDescription = "updated_task_description";
            var expectedTaskId = "test_task_id";

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"id\": \"{expectedTaskId}\"}}")
                });

            // Act
            var updatedTaskId = await _clickUpClient.UpdateTaskAsync(taskId, taskName, taskDescription);

            // Assert
            Assert.Equal(expectedTaskId, updatedTaskId);
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
            var expectedUsername = "test_username";

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"username\": \"{expectedUsername}\"}}")
                });

            // Act
            var username = await _clickUpClient.GetAuthorizedUserAsync();

            // Assert
            Assert.Equal(expectedUsername, username);
        }

        [Fact]
        public async Task GetAuthorizedTeamsAsync_ReturnsTeams()
        {
            // Arrange
            var expectedTeams = "[{\"id\": \"team1\"}, {\"id\": \"team2\"}]";

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"teams\": {expectedTeams}}}")
                });

            // Act
            var teams = await _clickUpClient.GetAuthorizedTeamsAsync();

            // Assert
            Assert.Equal(expectedTeams, teams);
        }
    }
}
