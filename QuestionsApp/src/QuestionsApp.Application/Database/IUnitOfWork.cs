using System.Data;

namespace QuestionsApp.Application.Database;

public interface IUnitOfWork
{
    Task<IDbTransaction> BeginTransactionAsync(CancellationToken cancellationToken);
}