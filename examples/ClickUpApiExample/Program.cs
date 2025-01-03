using ClickUpApi;
using Microsoft.Extensions.DependencyInjection;

// Create a new ServiceCollection
var services = new ServiceCollection();

// Add the ClickUpClient to the service collection
services.AddClickUpClient();

// Build the ServiceProvider
var serviceProvider = services.BuildServiceProvider();

// Resolve the IClickUpClient service
var clickUpClient = serviceProvider.GetRequiredService<IClickUpClient>();

// Authenticate with the ClickUp API
await clickUpClient.AuthenticateAsync("YOUR_CLIENT_ID", "YOUR_CLIENT_SECRET", "test_code");

// Fetch data using the ClickUp API
var task = await clickUpClient.GetTaskAsync("test_task_id");

Console.WriteLine(task);