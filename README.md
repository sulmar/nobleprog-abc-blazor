# Examples from the Blazor Application Development Training

## Introduction

Welcome to the repository with materials for the **Blazor Application Development** training.

To get started with this course, you will need the following:

1. [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0).

## Projects in `src`

The solution under `src` is split into small projects used across the training exercises.

| Project | Type | Summary |
| --- | --- | --- |
| **Domain** | Class library | Shared domain models (`Customer`, `Product`, etc.) and repository abstractions (`ICustomerRepository`, `IProductRepository`, …). |
| **Infrastructure** | Class library | Implements `Domain` with in-memory repositories and [Bogus](https://github.com/bchavez/Bogus)-based fake data for demos. Referenced by **Api**. |
| **Api** | ASP.NET Core Web API | Minimal APIs for customers and products, CORS configured for the Blazor WebAssembly host, and fake messaging. Uses **Domain** + **Infrastructure**. |
| **BlazorWebAssemblyApp** | Blazor WebAssembly | Client app referencing **Domain**; `HttpClient` calls the **Api**; includes services for customers/products and examples of cascading values and app state. |
| **BlazorServerApp** | Blazor Server | Interactive server-rendered Blazor (`.NET 9` template style): Razor components, static assets, antiforgery, and a sample `/hello` endpoint. |
| **Hello.Api** | ASP.NET Core Web API | Minimal “Hello World” API—single endpoint for the simplest Web API introduction. |
| **IdentityProvider.Api** | ASP.NET Core Web API | Authentication sample: login endpoint, JWT issuance, in-memory users, ASP.NET Core Identity password hashing, and optional BCrypt/Argon2 packages for discussion. |
| **HybridMauiApp** | .NET MAUI (Blazor hybrid) | Cross-platform app (Android, iOS, Mac Catalyst, and Windows when building on Windows) hosting Blazor UI in a `BlazorWebView`. |

## Setup

1. **Prerequisites**
   - [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) (same as in *Introduction*).
   - For **HybridMauiApp** only: install the [.NET MAUI workload](https://learn.microsoft.com/dotnet/maui/get-started/installation) (`dotnet workload install maui`) and the Android / iOS / Mac Catalyst tooling for your OS.

2. **Clone the repository**

```bash
git clone https://github.com/sulmar/nobleprog-ifm-blazor.git
cd nobleprog-ifm-blazor
```

3. **Restore and build the solution**

```bash
dotnet restore src/BlazorCourse.sln
dotnet build src/BlazorCourse.sln
```

   Open `src/BlazorCourse.sln` in Visual Studio, Rider, or VS Code if you prefer an IDE.

4. **Run a project**

   From the repo root, use `dotnet run` with the project path. HTTPS URLs come from each app’s `Properties/launchSettings.json` (defaults below).

   | When you need… | Command |
   | --- | --- |
   | **Api** + **BlazorWebAssemblyApp** together | In two terminals: `dotnet run --project src/Api/Api.csproj --launch-profile https` then `dotnet run --project src/BlazorWebAssemblyApp/BlazorWebAssemblyApp.csproj --launch-profile https`. The WASM client is configured to call the API at `https://localhost:7081`. |
   | **BlazorServerApp** | `dotnet run --project src/BlazorServerApp/BlazorServerApp.csproj --launch-profile https` |
   | **Hello.Api** | `dotnet run --project src/Hello.Api/Hello.Api.csproj` |
   | **IdentityProvider.Api** | `dotnet run --project src/IdentityProvider.Api/IdentityProvider.Api.csproj --launch-profile https` |
   | **HybridMauiApp** | `dotnet run --project src/HybridMauiApp/HybridMauiApp.csproj -f net9.0-maccatalyst` (or `-f net9.0-android`, `net9.0-ios`, etc., depending on your target). |

   **Default dev URLs:** Api `https://localhost:7081`, Blazor WebAssembly `https://localhost:7282`, Blazor Server `https://localhost:7069`, IdentityProvider.Api `https://localhost:7227`, Hello.Api `http://localhost:5202` (HTTP-only profile in `launchSettings`).