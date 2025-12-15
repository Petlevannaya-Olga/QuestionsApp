namespace QuestionsApp.Domain.Reports;

public class Report
{
    /// <summary>
    /// Идентификатор жалобы
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Идентификатор пользователя, который оставил жалобу
    /// </summary>
    public required Guid UserId { get; set; }
    
    /// <summary>
    /// Идентификатор пользователя, на которого была оставлена жалоба
    /// </summary>
    public required Guid ReportedUserId { get; set; }

    /// <summary>
    /// Причина жалобы
    /// </summary>
    public required string Reason { get; set; }
    
    /// <summary>
    /// Сотрудник, который закрыл жалобу
    /// </summary>
    public Guid? ResolvedByUserId {get; set;}

    /// <summary>
    /// Статус жалобы
    /// </summary>
    public ReportStatus ReportStatus { get; set; } = ReportStatus.OPEN;
    
    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Дата обновления
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}