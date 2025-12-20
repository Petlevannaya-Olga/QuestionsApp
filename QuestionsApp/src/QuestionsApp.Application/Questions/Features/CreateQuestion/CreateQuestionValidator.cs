using FluentValidation;
using QuestionsApp.Contracts.Questions;

namespace QuestionsApp.Application.Questions.Features.CreateQuestion;

public class CreateQuestionValidator : AbstractValidator<CreateQuestionDto>
{
    public CreateQuestionValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Заголовок не может быть пустым")
            .MaximumLength(500)
            .WithMessage("Заголовок слишком длинный");

        RuleFor(x => x.Text)
            .NotEmpty()
            .WithMessage("Текст не может быть пустым")
            .MaximumLength(5000)
            .WithMessage("Текст слишком длинный");

        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage("User id невалидный");
    }
}