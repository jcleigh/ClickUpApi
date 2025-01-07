using ClickUpApi;
using Microsoft.Extensions.DependencyInjection;

// Replace the following values with your own
const string personalApiToken = "YOUR TOKEN HERE";
const string taskId = "YOUR TASK ID HERE";

// Create a new ServiceCollection
var services = new ServiceCollection();

// Register the API token as a configuration value
services.AddSingleton(personalApiToken);

// Add the ClickUpClient to the service collection
services.AddHttpClient<IClickUpClient, ClickUpClient>(client =>
{
    client.DefaultRequestHeaders.Add("Authorization", personalApiToken);
});

// Build the ServiceProvider
var serviceProvider = services.BuildServiceProvider();

// Resolve the IClickUpClient service
var clickUpClient = serviceProvider.GetRequiredService<IClickUpClient>();

// Fetch data using the ClickUp API
var task = await clickUpClient.GetTaskAsync(taskId);

Console.WriteLine($"Task retrieved: {task.Id} | {task.Name}");
