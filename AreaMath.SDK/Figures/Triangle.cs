using AreaMath.SDK.Objects;

namespace AreaMath.SDK.Figures;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : Figure
{
    /// <summary>
    /// Стороны
    /// </summary>
    public double[] Sides { get; private set; }

    /// <inheritdoc cref="Triangle"/>
    /// <remarks>Принимает неограниченное количество параметров, но использует первые 3</remarks>
    public Triangle(params double[] sides) : base()
    {
        var takenSides = sides.Take(3).ToArray();
        if (takenSides.Length != 3)
            throw new ArgumentOutOfRangeException(nameof(sides), takenSides, "Некорректное количество сторон");

        if (takenSides[0] >= takenSides[1] + takenSides[2] ||
            takenSides[1] >= takenSides[0] + takenSides[2] ||
            takenSides[2] >= takenSides[0] + takenSides[1] ||
            takenSides.Any(s => s <= 0))
            throw new ArgumentOutOfRangeException(nameof(sides), takenSides, "Некорректные значения сторон");

        Sides = takenSides;
    }

    /// <inheritdoc cref="Figure.GetArea"/>
    public override AreaCalculationResult GetArea()
    {
        var halfPerimeter = Sides.Sum() / 2;

        var area = Math.Sqrt(
            Sides.Aggregate(halfPerimeter, (composition, side) => composition * (halfPerimeter - side))
        );

        var orderedSides = Sides.OrderByDescending(s => s).ToArray();

        var hasRightAngle = 
            Math.Pow(orderedSides[0], 2) == Math.Pow(orderedSides[1], 2) + Math.Pow(orderedSides[2], 2);

        var calculationDetails = new AreaCalculationDetails[] {
            new AreaCalculationDetails("hasRightAngle", "Является прямоугольным", hasRightAngle)
        };

        return new AreaCalculationResult(area, calculationDetails);
    }
}
