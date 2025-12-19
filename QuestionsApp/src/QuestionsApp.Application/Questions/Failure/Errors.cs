using Shared;

namespace QuestionsApp.Application.Questions.Failure;

public partial class Errors
{
    public static class Questions
    {
        public static Error TooManyQuestions() =>
            Error.Failure(
                "too.many.questions", 
                "Пользователь не может открыть больше 3 вопросов");
    }
}