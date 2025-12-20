using CSharpFunctionalExtensions;
using FluentValidation;
using Microsoft.Extensions.Logging;
using QuestionsApp.Application.Abstractions;
using QuestionsApp.Application.Extensions;
using QuestionsApp.Contracts.Questions;
using QuestionsApp.Domain.Questions;

namespace QuestionsApp.Application.Questions.Features.CreateQuestion;

public class CreateQuestionHandler(
    ILogger<CreateQuestionHandler> logger,
    IQuestionRepository repository,
    IValidator<CreateQuestionDto> validator) : ICommandHandler<Guid, CreateQuestionCommand>
{
    public async Task<Result<Guid, Shared.Failure>> Handle(
        CreateQuestionCommand command,
        CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command.Dto, cancellationToken);

        if (!validationResult.IsValid)
        {
            return validationResult.ToErrors();
        }

        var questionId = Guid.NewGuid();

        var question = new Question(
            title: command.Dto.Title,
            text: command.Dto.Text,
            userId: command.Dto.UserId,
            screenshotId: null,
            tags: command.Dto.TagIds);

        await repository.AddAsync(question, cancellationToken);

        logger.LogInformation("Создан вопрос с идентификатором = {questionId}", questionId);

        return questionId;
    }
}