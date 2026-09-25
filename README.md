# MediSync API

A modern clinic appointment management system built with .NET 8 and Clean Architecture.

## Features

- Patient and doctor registration & authentication (JWT)
- Appointment scheduling and management
- Doctor availability management
- AI-powered symptom pre-evaluation
- Role-based access control (Admin, Doctor, Patient)

## Tech Stack

- **Framework:** .NET 8 / ASP.NET Core
- **Architecture:** Clean Architecture
- **ORM:** Entity Framework Core 8
- **Database:** SQL Server
- **Authentication:** JWT Bearer
- **API Docs:** Swagger / OpenAPI
- **Real-time:** SignalR

## Architecture
MediSync.Domain → Entities, interfaces, domain logic
MediSync.Application → Use cases, CQRS handlers, DTOs
MediSync.Infrastructure → EF Core, external services, repositories
MediSync.API → Controllers, middleware, program entry

## Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server 2022

### Run

```bash
git clone https://github.com/ismailumutluoglu/medisync-api.git
cd medisync-api
dotnet restore
dotnet run --project MediSync/MediSync.API
```

## License

MIT