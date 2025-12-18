using QuestionsApp.Domain.Questions;

namespace QuestionsApp.Application.Questions;

public interface IQuestionRepository
{
    Task<Guid> AddAsync(Question question, CancellationToken cancellationToken);

    Task<Guid> SaveAsync(Question question, CancellationToken cancellationToken);

    Task<Guid> DeleteAsync(Guid id, CancellationToken cancellationToken);

    Task<Question?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    
    Task<int> GetOpenQuestionsByUserIdAsync(Guid userId, CancellationToken cancellationToken);
}