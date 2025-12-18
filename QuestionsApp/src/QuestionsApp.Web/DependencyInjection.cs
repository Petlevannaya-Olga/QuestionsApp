using QuestionsApp.Application;
using QuestionsApp.Infrastructure.Postgres;

namespace QuestionsApp.Web;

public static class DependencyInjection
{
    public static IServiceCollection AddProgramDependencies(this IServiceCollection services)
    {
        return services
            .AddWebDependencies()
            .AddApplication()
            .AddPostgresInfrastructure();
    }

    private static IServiceCollection AddWebDependencies(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddOpenApi();
        return services;
    }
}