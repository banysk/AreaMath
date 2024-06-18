using AreaMath.SDK.Objects;

namespace AreaMath.SDK.Figures;

/// <summary>
/// Геометрическая фигура
/// </summary>
public abstract class Figure
{
    /// <summary>
    /// Получить площадь
    /// </summary>
    public virtual AreaCalculationResult GetArea()
    {
        throw new NotImplementedException();
    }
}
