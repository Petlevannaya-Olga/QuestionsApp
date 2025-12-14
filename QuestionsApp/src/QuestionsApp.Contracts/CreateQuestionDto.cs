namespace QuestionsApp.Contracts;

public record CreateQuestionDto(string Title, string Body, Guid UserId, List<Guid> TagIds);
