namespace QuestionsApp.Contracts.Questions;

public record GetQuestionsDto(string Search, Guid[] Tags, int Page, int Limit);