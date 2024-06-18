using AreaMath.SDK;
using AreaMath.SDK.Figures;

namespace AreaMath.Unit
{
    public class CircleTests
    {
        [Test]
        [Description("Конструктор. Некорректный входной параметр")]
        public void Circle_Ctor_IncorrectInput()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10.0));
        }

        [Test]
        [Description("Конструктор. Корректный входной параметр")]
        public void Circle_Ctor_CorrectInput()
        {
            Assert.DoesNotThrow(() => new Circle(1));
        }

        [Test]
        [Description("Рассчет площади")]
        public void Circle_GetArea()
        {
            var circle = new Circle(1);
            var area = AMath.GetArea(circle).Area;

            Assert.That(area, Is.EqualTo(Math.PI));
        }
    }
}