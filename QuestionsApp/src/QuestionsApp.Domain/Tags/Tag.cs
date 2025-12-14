namespace QuestionsApp.Domain.Tags;

public class Tag
{
    /// <summary>
    /// Идентификатор тега
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Название тега
    /// </summary>
    public required string Name { get; set; }
}