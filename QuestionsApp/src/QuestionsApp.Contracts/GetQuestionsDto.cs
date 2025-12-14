namespace QuestionsApp.Contracts;

public record GetQuestionsDto(string Search, Guid[] Tags, int Page, int Limit);