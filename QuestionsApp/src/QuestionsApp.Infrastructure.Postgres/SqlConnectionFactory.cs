using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;
using QuestionsApp.Application.Database;

namespace QuestionsApp.Infrastructure.Postgres;

public class SqlConnectionFactory(IConfiguration configuration) : ISqlConnectionFactory
{
    public IDbConnection Create()
    {
        var connection = new NpgsqlConnection(configuration.GetConnectionString("Database"));
        return connection;
    }
}