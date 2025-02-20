# WebAPP_Template.Backend

This repository provides a structured template for the backend of an ASP.NET Core Web App. It is built using .NET 8 (LTS) and follows a clean architecture approach, ensuring separation of concerns between API, application logic, domain, and infrastructure layers.

## Features
- ASP.NET Core Web API with .NET 8
- Modular project structure for scalability and maintainability
- Dependency injection and service-based architecture
- DTO-based request and response handling
- Repository pattern for data access
- Configuration and extension methods for cleaner startup

## Project Structure

```
WebAPP_Template.Backend
├───WebAPP_Template.Backend.API
│   ├───Controllers
│   └───Extensions
├───WebAPP_Template.Backend.Application
│   ├───Abstractions
│   │   └───Services
│   ├───Extensions
│   ├───Models
│   │   ├───Dtos
│   │   ├───Requests
│   │   └───Responses
│   ├───Options
│   └───Services
├───WebAPP_Template.Backend.Domain
│   └───Abstractions
│       └───Repositories
└───WebAPP_Template.Backend.Infrastructure
    ├───Configurations
    ├───Context
    └───Repositories
```

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (Recommended)

## Contributing
Feel free to fork this repository and contribute improvements. Open an issue or submit a pull request for any changes.

## License
This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.

