namespace QuestionsApp.Domain.Comments;

public class Comment
{
    /// <summary>
    /// Идентификатор комментария, PK
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Идентификатор пользователя, который оставил комментарий
    /// </summary>
    public required Guid UserId { get; set; }
    
    /// <summary>
    /// Родительский комментарий
    /// </summary>
    public Comment? Parent { get; set; }

    /// <summary>
    /// Список дочерних комментариев
    /// </summary>
    public List<Comment> Children { get; set; } = [];

    /// <summary>
    /// Сущность, для которой оставили комментарий
    /// </summary>
    public required Guid EntityId { get; set; }
}