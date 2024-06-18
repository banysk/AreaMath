using AreaMath.SDK.Objects;

namespace AreaMath.SDK.Figures;

/// <summary>
/// Круг
/// </summary>
public class Circle : Figure
{
    /// <summary>
    /// Радиус
    /// </summary>
    public double Radius { get; private set; }

    /// <inheritdoc cref="Circle"/>
    public Circle(double raduis) : base()
    {
        if (raduis <= 0)
            throw new ArgumentOutOfRangeException(nameof(raduis), raduis, "Радиус должен быть больше 0");

        Radius = raduis;
    }

    /// <inheritdoc cref="Figure.GetArea"/>
    public override AreaCalculationResult GetArea()
    {
        var area = Math.PI * Math.Pow(Radius, 2);
        return new AreaCalculationResult(area);
    }
}
