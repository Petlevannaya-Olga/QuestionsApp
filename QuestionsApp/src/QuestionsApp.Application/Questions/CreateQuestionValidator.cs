using FluentValidation;
using QuestionsApp.Contracts.Questions;

namespace QuestionsApp.Application.Questions;

public class CreateQuestionValidator : AbstractValidator<CreateQuestionDto>
{
    public CreateQuestionValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .MaximumLength(500)
            .WithMessage("Заголовок слишком длинный");

        RuleFor(x => x.Text)
            .NotEmpty()
            .MaximumLength(5000)
            .WithMessage("Текст слишком длинный");

        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage("User id невалидный");
    }
}