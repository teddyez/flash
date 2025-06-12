# Solution Folder Structure

This document describes the purpose of each folder in the solution, following Clean Architecture principles.

---

## NetSolution.Domain

- **Entities/**  
  Contains core business entities and aggregates.

- **ValueObjects/**  
  Holds value objects that represent concepts with equality based on their properties.

- **Enums/**  
  Stores enumeration types used throughout the domain.

- **Interfaces/**  
  Domain-level abstractions, such as repository or service contracts.

- **Events/**  
  Domain events representing important business occurrences.

- **Exceptions/**  
  Custom exception types related to domain logic.

- **Specifications/**  
  Encapsulates business rules and query logic.

---

## NetSolution.Application

- **Interfaces/**  
  Application service abstractions and contracts.

- **DTOs/**  
  Data Transfer Objects for communication between layers.

- **Features/**  
  Organizes use cases (commands, queries, handlers) by feature.

- **Common/**  
  Shared application logic, helpers, or base classes.

- **Services/**  
  Application-specific services and logic.

- **Validators/**  
  Classes for validating commands, queries, and DTOs.

- **Exceptions/**  
  Application-layer specific exceptions.

---

## NetSolution.Infrastructure

- **Persistence/**  
  Data access implementation, including database context and configuration.

  - **Configurations/**  
    Entity Framework or ORM mapping configurations.

  - **Migrations/**  
    Database migration scripts and files.

- **Repositories/**  
  Concrete implementations of repository interfaces.

- **Services/**  
  Infrastructure-level services (e.g., email, file storage).

- **Identity/**  
  Authentication and authorization infrastructure.

- **External/**  
  Integrations with external systems or APIs.

- **Seed/**  
  Data seeding logic for initializing the database.

---

## NetSolution.API

- **Controllers/**  
  API endpoints for handling HTTP requests.

- **Models/**  
  API-specific models, such as request/response objects.

- **Filters/**  
  Action filters, exception filters, and other ASP.NET Core filters.

- **Middlewares/**  
  Custom middleware components for request/response processing.

- **Extensions/**  
  Extension methods for configuring services or middleware.

- **Properties/**  
  Project metadata (e.g., launchSettings.json).

- **wwwroot/**  
  Static web assets (CSS, JS, images, etc.).

- **appsettings.json / appsettings.Development.json**  
  Application configuration files.
---

## Common Files and Folders in Each Project

- **DependencyInjection.cs**  
  Contains extension methods or logic for registering services and dependencies for the project.

- **Program.cs** (API project only)  
  Entry point for the ASP.NET Core application.

