# ClickUp API for .NET

### ** Note: This is still a work in progress! **

This library allows you to interact with the Clickup API using .NET 8. It provides methods for authentication, creating tasks, and other API interactions.

## Installation

To install the Clickup API library, you can use the NuGet package manager:

```sh
dotnet add package ClickUpApi
```

## Usage

First, you need to register the ClickupClient with the Dependency Injection container in your `Startup.cs` or `Program.cs` file:

```csharp
using ClickUpApi;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddClickUpClient();
    }
}
```

Then, you can inject the `IClickUpClient` interface into your classes and use it to interact with the Clickup API:

```csharp
using ClickUpApi;

public class MyService
{
    private readonly IClickUpClient _clickUpClient;

    public MyService(IClickUpClient clickUpClient)
    {
        _clickUpClient = clickUpClient;
    }

    public async Task<string> AuthenticateAsync(string clientId, string clientSecret, string code)
    {
        return await _clickUpClient.AuthenticateAsync(clientId, clientSecret, code);
    }

    public async Task<string> CreateTaskAsync(string listId, string taskName, string taskDescription)
    {
        return await _clickUpClient.CreateTaskAsync(listId, taskName, taskDescription);
    }

    // Add other methods for API interactions as needed
}
```

## Examples

### Authentication

```csharp
var accessToken = await _clickUpClient.AuthenticateAsync("your_client_id", "your_client_secret", "your_code");
```

### Creating a Task

```csharp
var taskId = await _clickUpClient.CreateTaskAsync("your_list_id", "Task Name", "Task Description");
```
