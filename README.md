# Clickup SDK for .NET

This SDK allows you to interact with the Clickup API using .NET 8. It provides methods for authentication, creating tasks, and other API interactions.

## Installation

To install the Clickup SDK, you can use the NuGet package manager:

```sh
dotnet add package ClickupSdk
```

## Usage

First, you need to register the ClickupClient with the Dependency Injection container in your `Startup.cs` or `Program.cs` file:

```csharp
using ClickupSdk;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddClickupClient();
    }
}
```

Then, you can inject the `IClickupClient` interface into your classes and use it to interact with the Clickup API:

```csharp
using ClickupSdk;

public class MyService
{
    private readonly IClickupClient _clickupClient;

    public MyService(IClickupClient clickupClient)
    {
        _clickupClient = clickupClient;
    }

    public async Task<string> AuthenticateAsync(string clientId, string clientSecret, string code)
    {
        return await _clickupClient.AuthenticateAsync(clientId, clientSecret, code);
    }

    public async Task<string> CreateTaskAsync(string listId, string taskName, string taskDescription)
    {
        return await _clickupClient.CreateTaskAsync(listId, taskName, taskDescription);
    }

    // Add other methods for API interactions as needed
}
```

## Examples

### Authentication

```csharp
var accessToken = await _clickupClient.AuthenticateAsync("your_client_id", "your_client_secret", "your_code");
```

### Creating a Task

```csharp
var taskId = await _clickupClient.CreateTaskAsync("your_list_id", "Task Name", "Task Description");
```

## Testing

To run the tests for the Clickup SDK, you can use the following command:

```sh
dotnet test
```

## GitHub Actions

This repository includes a GitHub Actions workflow to build, test, and publish the Clickup SDK. The workflow is triggered on push and pull request events.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License.
