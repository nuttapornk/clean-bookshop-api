# Clean Architecture with .NET Core: Getting Started
- ref : https://github.com/jasontaylordev/CleanArchitecture
- ref : https://jasontaylor.dev/clean-architecture-getting-started/

## Technologies
Aside from .NET Core, numerous technologies are used within this solution including:
- CQRS with MediatR
- PipelineBehavior
- Validation with FluentValidation
- Object-Object Mapping with AutoMapper
- AutoMapper
- Paging with ReflectionIT.Mvc.Paging
- Data access with Entity Framework Core
- Web API using ASP.NET Core
- Automated testing with xUnit.net, Moq, and Shouldly
- Scaffolding database first
- Add migration


## Function
- Memory cache with Redis
    - Hyperion
- Event-based Microservices: Message Bus with Kafka
- Csv Helper
- S3 File with minio
- AppSetting.json on AWS 
- AppSetting.json dynamic on create container
- Middleware
    - MiddlewareExtentions
    - ValidateHeaders
    - ValidateToken
- ApiFilerException


## CI/CD
- github workflow
    - Code quality scan with sonarqube
    - Dotnet build test,publish
    - Docker build and push docker hub
    - CD wiht GoCD
