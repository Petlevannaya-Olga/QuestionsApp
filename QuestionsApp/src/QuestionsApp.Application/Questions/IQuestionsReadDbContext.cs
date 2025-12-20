using QuestionsApp.Domain.Questions;

namespace QuestionsApp.Application.Questions;

public interface IQuestionsReadDbContext
{
    IQueryable<Question> ReadQuestions { get; }
}