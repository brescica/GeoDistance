# GeoDistance
A .NET 6 Web API for calculating geo coordinates distance

# Technologies and patterns
- Clean architecture
- .NET 6
- MediatR
- XUnit for Unit & integration tests
- Swagger 
----
# Instructions
- Install the latest .NET 6 SDK

- ----
# Overview
## Domain
This will contain all entities, enums, constants, helpers, types and logic specific to the domain layer.

## Application
This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example ICalculateDistance, and an implementation would be created within infrastructure.

## Infrastructure
This layer contains factory for resolving the implementation of ICalculateDistance class and classes implementing this interface.

## GeoDistance.API
This layer provides REST API endpoints. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only Program.cs should reference Infrastructure.

## GeoDistance.Tests
This layer provides unit and integrations tests.
