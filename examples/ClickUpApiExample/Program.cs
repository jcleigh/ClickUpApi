using ClickUpApi;
using Microsoft.Extensions.DependencyInjection;

// Create a new ServiceCollection
var services = new ServiceCollection();

// Add the ClickUpClient to the service collection
services.AddHttpClient<IClickUpClient, ClickUpClient>(client =>
{
    var personalApiToken = "YOUR_PERSONAL_API_TOKEN";
    client.DefaultRequestHeaders.Add("Authorization", personalApiToken);
});

// Build the ServiceProvider
var serviceProvider = services.BuildServiceProvider();

// Resolve the IClickUpClient service
var clickUpClient = serviceProvider.GetRequiredService<IClickUpClient>();

// Fetch data using the ClickUp API
var task = await clickUpClient.GetTaskAsync("test_task_id");

Console.WriteLine(task);
