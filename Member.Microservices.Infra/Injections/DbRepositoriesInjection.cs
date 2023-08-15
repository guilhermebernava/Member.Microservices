using Member.Microservices.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Member.Microservices.Infra.Injections;

public static class DbRepositoriesInjection
{
    public static IServiceCollection AddContextAndRepositories(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Singleton);
        return services;
    }
}