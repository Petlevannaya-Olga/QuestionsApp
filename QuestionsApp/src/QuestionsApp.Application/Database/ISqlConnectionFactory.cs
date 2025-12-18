using System.Data;

namespace QuestionsApp.Application.Database;

public interface ISqlConnectionFactory
{
    IDbConnection Create();
}