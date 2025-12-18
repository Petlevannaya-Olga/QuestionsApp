using Microsoft.Extensions.DependencyInjection;
using QuestionsApp.Application.Database;
using QuestionsApp.Application.Questions;

namespace QuestionsApp.Infrastructure.Postgres;

public static class DependencyInjection
{
    public static IServiceCollection AddPostgresInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<ISqlConnectionFactory, SqlConnectionFactory>();
        services.AddScoped<IQuestionRepository, QuestionsSqlRepository>();
        return services;
    }
}