[![.NET](https://github.com/abdelrazekrizk/azure-pilot-genesis/actions/workflows/dotnet.yml/badge.svg)](https://github.com/abdelrazekrizk/azure-pilot-genesis/actions/workflows/dotnet.yml)![NuGet Version](https://img.shields.io/nuget/v/dotnetenv)
![NuGet Version](https://img.shields.io/nuget/v/octokit)


# CopilotGenesis
## Overview
**CopilotGenesis** is a GitHub extension integrated with Azure services.<p>It acts as a professional assistant specialized in Azure services, providing valuable insights and support to users through GitHub.<p> The extension is built using a .NET Web API and leverages GitHub's Octokit library for interacting with GitHub APIs.

## Features
Azure Resource Management: Retrieves and displays a list of Azure resources.

## How did we solve the problem?
We integrated Azure services with GitHub using a .NET Web API and the Octokit library to provide seamless interaction and resource management.

GitHub Integration: Uses GitHub tokens for authentication and interaction.

Secure Configuration: Environment variables managed via a .env file to securely handle sensitive information.

## Project Structure


```markdown
azure-pilot-genesis
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

## Dependency

- ```python
DotNetEnv
```

```console
dotnet add package DotNetEnv

```
- ```python
Octokit
```

```console
dotnet add package Octokit
```

## Setup Instructions
- **Build the Project:**
```console
dotnet build
```
-
```console
dotnet run
```
