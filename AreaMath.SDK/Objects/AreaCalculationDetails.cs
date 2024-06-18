namespace AreaMath.SDK.Objects;

/// <summary>
/// Дополнительная информация, полученная при вычислении площади
/// </summary>
public class AreaCalculationDetails
{
    /// <summary>
    /// Строковый идентификатор
    /// </summary>
    public string Id { get; private set; }

    /// <summary>
    /// Описание свойства
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Значение
    /// </summary>
    public object Value { get; private set; }

    /// <inheritdoc cref="AreaCalculationDetails"/>
    public AreaCalculationDetails(string id, string description, object value)
    {
        Id = id;
        Description = description;
        Value = value;
    }
}
