using QuestionsApp.Application.Abstractions;
using QuestionsApp.Contracts.Questions;

namespace QuestionsApp.Application.Questions.Features.CreateQuestion;

public record CreateQuestionCommand(CreateQuestionDto Dto) : ICommand;