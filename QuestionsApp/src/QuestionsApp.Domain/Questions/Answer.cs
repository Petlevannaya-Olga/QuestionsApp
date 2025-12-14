namespace QuestionsApp.Domain.Questions;

public class Answer
{
    /// <summary>
    /// Идентификатор, PK
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор пользователя, который ответил
    /// </summary>
    public required Guid UserId { get; set; }

    /// <summary>
    /// Текст ответа
    /// </summary>
    public required string Text { get; set; }

    /// <summary>
    /// Ссылка на вопрос
    /// </summary>
    public required Question Question { get; set; }
}