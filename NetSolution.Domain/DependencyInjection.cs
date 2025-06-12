using Microsoft.Extensions.DependencyInjection;

namespace NetSolution.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            // Register domain services here if needed
            return services;
        }
    }
}