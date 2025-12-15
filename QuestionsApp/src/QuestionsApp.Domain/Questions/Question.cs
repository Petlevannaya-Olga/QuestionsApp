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
    public string Title { get; set; }

    /// <summary>
    /// Текст вопроса
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Идентификатор пользователя, задавшего вопрос
    /// </summary>
    public Guid UserId { get; set; }

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

    /// <summary>
    /// Статус вопроса
    /// </summary>
    public QuestionStatus Status { get; set; } = QuestionStatus.OPEN;

    public Question(
        string title,
        string text,
        Guid userId,
        Guid? screenshotId,
        IEnumerable<Guid> tags)
    {
        Title = title;
        Text = text;
        UserId = userId;
        ScreenshotId = screenshotId;
        Tags = tags.ToList();
    }
}