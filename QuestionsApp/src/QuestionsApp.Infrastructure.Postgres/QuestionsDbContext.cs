using Microsoft.EntityFrameworkCore;
using QuestionsApp.Domain.Questions;

namespace QuestionsApp.Infrastructure.Postgres;

public class QuestionsDbContext : DbContext
{
    public DbSet<Question> Questions { get; set; }
}