namespace Shared;

public record Error
{
    /// <summary>
    /// Код ошибки
    /// </summary>
    public string Code { get; }

    /// <summary>
    /// Сообщение об ошибке
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Тип ошибки
    /// </summary>
    public ErrorType Type { get; }

    public static Error None => new Error(string.Empty, string.Empty, ErrorType.FAILURE);

    /// <summary>
    /// Поле, в котором произошла ошибка
    /// </summary>
    public string? InvalidField { get; }

    private Error(string code, string message, ErrorType type, string? invalidField = null)
    {
        Code = code;
        Message = message;
        Type = type;
        InvalidField = invalidField;
    }

    public static Error NotFound(string? code, string message, Guid? id)
        => new Error(code ?? "record.not.found", message, ErrorType.NOT_FOUND);

    public static Error Validation(string? code, string message, string? invalidField = null)
        => new Error(code ?? "value.is.invalid", message, ErrorType.VALIDATION, invalidField);

    public static Error Conflict(string? code, string message)
        => new Error(code ?? "value.is.conflict", message, ErrorType.CONFLICT);

    public static Error Failure(string? code, string message)
        => new Error(code ?? "failure", message, ErrorType.FAILURE);

    public Failure ToFailure() => this;
}

public enum ErrorType
{
    /// <summary>
    /// Ошибка валидации
    /// </summary>
    VALIDATION,

    /// <summary>
    /// Элемент не найден
    /// </summary>
    NOT_FOUND,

    /// <summary>
    /// Общая ошибка
    /// </summary>
    FAILURE,

    /// <summary>
    /// Конфликт
    /// </summary>
    CONFLICT,
}