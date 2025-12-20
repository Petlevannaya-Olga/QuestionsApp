using Microsoft.EntityFrameworkCore;
using QuestionsApp.Application.Questions;
using QuestionsApp.Domain.Questions;

namespace QuestionsApp.Infrastructure.Postgres;

public class QuestionsReadDbContext : DbContext, IQuestionsReadDbContext
{
    public DbSet<Question> Questions { get; set; }

    public IQueryable<Question> ReadQuestions => Questions.AsNoTracking().AsQueryable();
}