using Microsoft.EntityFrameworkCore;
using QuestionsApp.Application.Questions;
using QuestionsApp.Domain.Questions;

namespace QuestionsApp.Infrastructure.Postgres;

public class QuestionsEfCoreRepository(QuestionsReadDbContext readDbContext) : IQuestionRepository
{
    public async Task<Guid> AddAsync(Question question, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
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
        return await readDbContext
            .Questions
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<int> GetOpenQuestionsByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}