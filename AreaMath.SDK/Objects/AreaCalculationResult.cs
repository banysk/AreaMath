namespace AreaMath.SDK.Objects;

/// <summary>
/// Результат вычисления площади
/// </summary>
public class AreaCalculationResult
{
    /// <summary>
    /// Площадь
    /// </summary>
    public double Area { get; private set; }

    /// <inheritdoc cref="AreaCalculationDetails"/>
    public IReadOnlyCollection<AreaCalculationDetails> Details { get; private set; } = new AreaCalculationDetails[0];

    /// <inheritdoc cref="AreaCalculationResult"/>
    public AreaCalculationResult(double area)
    {
        Area = area;
    }

    /// <inheritdoc cref="AreaCalculationResult"/>
    public AreaCalculationResult(double area, IReadOnlyCollection<AreaCalculationDetails> details)
    {
        Area = area;
        Details = details;
    }
}
