# Stack:
- Net 9, C# 13
- Clean Architect
- EF Core, Microsoft SQL Server
- Because we are using Central Package Management so if wanna add a new package please add into Directory.Packages.props with <PackageVersion Include="{PackageName}" Version="{PackageVersion}" /> and into {project_name}.csproj <PackageReference Include="{PackageName}"/>
- Uses MediatR for CQRS and request/response handling.
- Uses Microsoft.EntityFrameworkCore for ORM and database access.
- Uses Microsoft.IdentityModel.Tokens and System.IdentityModel.Tokens.Jwt for JWT authentication.
- Uses OpenAPI (Swashbuckle/Minimal APIs) for API documentation.
- Custom utilities for JWT token generation and password hashing/verification.