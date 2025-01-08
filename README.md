[![.NET](https://github.com/abdelrazekrizk/azure-pilot-genesis/actions/workflows/dotnet.yml/badge.svg)](https://github.com/abdelrazekrizk/azure-pilot-genesis/actions/workflows/dotnet.yml)
![NuGet Version](https://img.shields.io/nuget/v/dotnetenv)
![NuGet Version](https://img.shields.io/nuget/v/octokit)

## Accelerate App Development with GitHub Copilot

<img src="./assest/full_width.png" width="1000"/>


#### Empowering the Next Generation of Developers with GitHub and Azure

# CopilotGenesis
## Overview
**CopilotGenesis** is a GitHub extension integrated with Azure services.<p>It acts as a professional assistant specialized in Azure services, providing valuable insights and support to users through GitHub.<p> The extension is built using a .NET Web API and leverages GitHub's Octokit library for interacting with GitHub APIs.

## Features
- Azure Resource Management: Retrieves and displays a list of Azure resources.
- GitHub Integration
- Secure Configuration

## How did we solve the problem?
- We integrated Azure services with GitHub using a .NET Web API and the Octokit library to provide seamless interaction and resource management.

- GitHub Integration: Uses GitHub tokens for authentication and interaction.

- Secure Configuration: Environment variables managed via a .env file to securely handle sensitive information.

## Step 1: Building the Extension
## Project Structure
```console
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
## Project Requierment:
- github account
- Visual Studio Code
- .NET SDK 8
## Setup Instructions
1. **Clone the Repository**:
   ```console
   git clone https://github.com/abdelrazekrizk/azure-pilot-genesis.git
   cd src/CopilotGenesis
   ```
## Dependency
Install Packages: open terminal using the .NET CLI to add NuGet packages
- **DotNetEnv**
```console
dotnet add package DotNetEnv --version 3.1.1
```
- **Octokit**
```console
dotnet add package Octokit --version 13.0.1
```

- **Build the Project:**
```console
dotnet build
```
- **Run the Project:**
```console
dotnet run
```


## Testing Instructions:
Testing your application is a critical step to ensure everything is working as expected.

- **Prerequisites**

Ensure the application is running:
```console
dotnet run
```

- **Testing the Root Endpoint**

Open your browser and navigate to:
```
http://localhost:5082/
```
Expected Response:

```
Hello CopilotGenesis!
```


**License**
> This project is licensed under the GNU GENERAL PUBLIC Version 3 License.