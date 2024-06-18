using AreaMath.SDK.Figures;
using AreaMath.SDK.Objects;

namespace AreaMath.SDK.Example
{
    /// <summary>
    /// Точка (демонстрация возможности расширения)
    /// </summary>
    public class PointFigure : Figure
    {
        /// <inheritdoc cref="PointFigure"/>
        public PointFigure()
        {

        }

        /// <inheritdoc/>
        public override AreaCalculationResult GetArea()
        {
            return new AreaCalculationResult(0);
        }
    }
}
