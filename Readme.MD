# Clean Architecture with .NET Core: Getting Started
- ref: https://github.com/jasontaylordev/CleanArchitecture
- ref: https://jasontaylor.dev/clean-architecture-getting-started/
- ref: https://medium.com/dotnet-hub/clean-architecture-with-dotnet-and-dotnet-core-aspnetcore-overview-introduction-getting-started-ec922e53bb97
- ref: https://github.com/iayti/CleanArchitecture
- ref: https://medium.com/aspnetrun/microservices-architecture-on-net-3b4865eea03f
- ref: https://github.com/aspnetrun/run-aspnetcore-microservices

## Technologies
Aside from .NET Core, numerous technologies are used within this solution including:
- ✔ CQRS with MediatR
- ✔ PipelineBehavior
- ✔ Validation with FluentValidation
- Object-Object Mapping with AutoMapper
- AutoMapper
- ✔ Paging with ReflectionIT.Mvc.Paging
- ✔ Data access with Entity Framework Core
- ✔ Web API using ASP.NET Core
- Automated testing with xUnit.net, Moq, and Shouldly
- ✔ Scaffolding database first
- ✔ Add migration
- .NET Application Loging with Serilog
    - example: https://medium.com/@matias.paulo84/net-core-serilog-elasticsearch-kibana-3bd080ff4c1e
- open source database for log with ElasticSearch
- open source user interface which allows us you visualize ElasticSearch data with Kibana
- Logstash->ElasticSearch->Kibana
- HttpMessageHandlers
    - DebuggingHttpHandler
    - ElasticLogHttpMessageHandler
- 3 rd Http Request with restCharp,Refit
- Event-Driven Communication

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
- github workflow
    - Code quality scan with sonarqube
    - Dotnet build test,publish
    - Docker build and push docker hub
    - CD wiht GoCD

