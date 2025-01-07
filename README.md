![NuGet Version](https://img.shields.io/nuget/v/dotnetenv)
![NuGet Version](https://img.shields.io/nuget/v/octokit)


# CopilotGenesis
## Overview
**CopilotGenesis** is a GitHub extension integrated with Azure services.<p>It acts as a professional assistant specialized in Azure services, providing valuable insights and support to users through GitHub.<p> The extension is built using a .NET Web API and leverages GitHub's Octokit library for interacting with GitHub APIs.

Features
Azure Resource Management: Retrieves and displays a list of Azure resources.

GitHub Integration: Uses GitHub tokens for authentication and interaction.

Secure Configuration: Environment variables managed via a .env file to securely handle sensitive information.

## Project Structure
```console
CopilotGenesis.sln
├── LICENSE
├── README.md
├── .env
└── src
    └── CopilotGenesis
        ├── CopilotGenesis.csproj
        ├── CopilotGenesis.cs
        ├── Message.cs
        ├── Program.cs
        ├── Properties
        │   └── launchSettings.json
        ├── Request.cs
        ├── appsettings.Development.json
        ├── appsettings.json
        ├── bin
        └── new_feature.cs
```
## Setup Instructions
- **Build the Project:**
dotnet build
dotnet run
