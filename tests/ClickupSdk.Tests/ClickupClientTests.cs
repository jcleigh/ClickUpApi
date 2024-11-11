using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using Xunit;

namespace ClickupSdk.Tests
{
    public class ClickupClientTests
    {
        private readonly Mock<HttpMessageHandler> _httpMessageHandlerMock;
        private readonly HttpClient _httpClient;
        private readonly ClickupClient _clickupClient;

        public ClickupClientTests()
        {
            _httpMessageHandlerMock = new Mock<HttpMessageHandler>();
            _httpClient = new HttpClient(_httpMessageHandlerMock.Object);
            _clickupClient = new ClickupClient(_httpClient);
        }

        [Fact]
        public async Task AuthenticateAsync_ReturnsAccessToken()
        {
            // Arrange
            var clientId = "test_client_id";
            var clientSecret = "test_client_secret";
            var code = "test_code";
            var expectedAccessToken = "test_access_token";

            _httpMessageHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent($"{{\"access_token\": \"{expectedAccessToken}\"}}")
                });

            // Act
            var accessToken = await _clickupClient.AuthenticateAsync(clientId, clientSecret, code);

            // Assert
            Assert.Equal(expectedAccessToken, accessToken);
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
            var taskId = await _clickupClient.CreateTaskAsync(listId, taskName, taskDescription);

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
            var taskName = await _clickupClient.GetTaskAsync(taskId);

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
            var updatedTaskId = await _clickupClient.UpdateTaskAsync(taskId, taskName, taskDescription);

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
            await _clickupClient.DeleteTaskAsync(taskId);

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
            var username = await _clickupClient.GetAuthorizedUserAsync();

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
            var teams = await _clickupClient.GetAuthorizedTeamsAsync();

            // Assert
            Assert.Equal(expectedTeams, teams);
        }
    }
}
