using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using QuestionsApp.Application.Database;
using QuestionsApp.Application.Questions;
using QuestionsApp.Domain.Questions;

namespace QuestionsApp.Infrastructure.Postgres;

public class QuestionsSqlRepository(ISqlConnectionFactory connectionFactory) : IQuestionRepository
{
    public async Task<Guid> AddAsync(Question question, CancellationToken cancellationToken)
    {
        const string sql = """
                           INSERT INTO questions (id, title, text, user_id, screenshot_id, tags, status)
                           VALUES(@Id, @Title, @Text, @UserId, @ScreenshotId, @Tags, @Status)
                           """;

        using var connection = connectionFactory.Create();

        await connection.ExecuteAsync(sql, new
        {
            Id = question.Id,
            Title = question.Title,
            Text = question.Text,
            UserId = question.UserId,
            ScreenshotId = question.ScreenshotId,
            Tags = question.Tags.ToArray(),
            Status = question.Status,
        });

        return question.Id;
    }

    public async Task<Guid> SaveAsync(Question question, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<Guid> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<Question?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<int> GetOpenQuestionsByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}