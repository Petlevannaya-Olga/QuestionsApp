namespace QuestionsApp.Domain.Questions;

public class Question
{
    /// <summary>
    /// Идентификатор, PK
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Заголовок вопроса
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// Текст вопроса
    /// </summary>
    public required string Text { get; set; }

    /// <summary>
    /// Идентификатор пользователя, задавшего вопрос
    /// </summary>
    public required Guid UserId { get; set; }
    
    /// <summary>
    /// Скриншот
    /// </summary>
    public Guid? ScreenshotId { get; set; }

    /// <summary>
    /// Список ответов
    /// </summary>
    public List<Answer> Answers { get; set; } = [];

    /// <summary>
    /// Правильный ответ на вопрос, выбранный пользователем
    /// </summary>
    public Answer? Solution { get; set; }

    /// <summary>
    /// Список тегов
    /// </summary>
    public List<Guid> Tags { get; set; } = [];
}