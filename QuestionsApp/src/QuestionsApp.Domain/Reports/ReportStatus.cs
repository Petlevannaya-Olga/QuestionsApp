namespace QuestionsApp.Domain.Reports;

public enum ReportStatus
{
    /// <summary>
    /// Открыт
    /// </summary>
    OPEN,

    /// <summary>
    /// В работе
    /// </summary>
    IN_PROGRESS,

    /// <summary>
    ///  Решен
    /// </summary>
    RESOLVED,

    /// <summary>
    /// Закрыт
    /// </summary>
    DISMISSED,
}