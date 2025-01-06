using Microsoft.AspNetCore.Mvc;
using Octokit;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Copilot!");

// Make sure you change the App Name below
string yourGitHubAppName = "CopilotGenesis"; // Replace with your actual extension name
string githubCopilotCompletionsUrl = "https://api.githubcopilot.com/chat/completions";

app.MapPost("/agent", async (
    [FromHeader(Name = "X-GitHub-Token")] string githubToken,
    [FromBody] Request userRequest) =>
{
    var octokitClient = new GitHubClient(new Octokit.ProductHeaderValue(yourGitHubAppName))
    {
        Credentials = new Credentials(githubToken)
    };

    var user = await octokitClient.User.Current();

     // Insert special system messages
    userRequest.Messages.Insert(0, new Message
    {
        Role = "system",
        Content = "Welcome to CopilotGenesis! As a specialized assistant, I am here to help you with all your Azure service needs and questions. How can I assist you today?"
    });

    userRequest.Messages.Insert(0, new Message
    {
        Role = "system",
        Content = "You are a professional assistant specializing in Azure services, providing valuable insights and support to users."
    });

    // Use HttpClient to communicate back to Copilot
    var httpClient = new HttpClient();
    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", githubToken);
    userRequest.Stream = true;

    // Use Copilot's LLM to generate a response to the user's messages
    var copilotLLMResponse = await httpClient.PostAsJsonAsync(githubCopilotCompletionsUrl, userRequest);

    // Stream the response straight back to the user
    var responseStream = await copilotLLMResponse.Content.ReadAsStreamAsync();
    return Results.Stream(responseStream, "application/json");
});

// Callback endpoint for GitHub App installation
app.MapGet("/callback", () => "You may close this tab and return to GitHub.com (where you should refresh the page and start a fresh chat). If you're using VS Code or Visual Studio, return there.");

app.Run();