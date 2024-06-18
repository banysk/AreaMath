using AreaMath.SDK.Figures;
using AreaMath.SDK.Objects;

namespace AreaMath.SDK;

/// <summary>
/// Калькулятор площадей
/// </summary>
/// <remarks>
/// Сюда можно добавить рассчет площади по переданным отрезкам,
/// определять по их количеству фигуры, но пока это выходит за рамки ТЗ.
/// </remarks>
public static class AMath
{
    /// <summary>
    /// Получить площадь <see cref="Figure"/>
    /// </summary>
    public static AreaCalculationResult GetArea(Figure figure)
    {
        return figure.GetArea();
    }
}