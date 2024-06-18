using AreaMath.SDK;
using AreaMath.SDK.Figures;

namespace AreaMath.Unit
{
    public class TriangleTests
    {
        [Test]
        [Description("Конструктор. Некорректный входной параметр. Мало сторон")]
        public void Triangle_Ctor_IncorrectInput_SidesCount()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1.0, 2.0));
        }

        [Test]
        [Description("Конструктор. Некорректный входной параметр. Значения сторон")]
        public void Triangle_Ctor_CorrectInput_SidesValues()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0.0, 1.0, 2.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1.0, 2.0, 3.0));
        }

        [Test]
        [Description("Рассчет площади. Равносторонний")]
        public void Triangle_GetArea_Equilateral()
        {
            var circle = new Triangle(1, 1, 1);
            var areaResult = AMath.GetArea(circle);

            var area = areaResult.Area;
            var details = areaResult.Details;

            var angleDetails = details.FirstOrDefault(d => d.Id == "hasRightAngle");
            Assert.IsNotNull(angleDetails);

            Assert.That(angleDetails.Value, Is.EqualTo(false));

            var expectedArea = Math.Sqrt(1.5 * Math.Pow(0.5, 3));
            Assert.That(area, Is.EqualTo(expectedArea));
        }

        [Test]
        [Description("Рассчет площади. Прямоугольный")]
        public void Triangle_GetArea_Right()
        {
            var circle = new Triangle(3, 4, 5);
            var areaResult = AMath.GetArea(circle);

            var area = areaResult.Area;
            var details = areaResult.Details;

            var angleDetails = details.FirstOrDefault(d => d.Id == "hasRightAngle");
            Assert.IsNotNull(angleDetails);

            Assert.That(angleDetails.Value, Is.EqualTo(true));

            var expectedArea = 6;
            Assert.That(area, Is.EqualTo(expectedArea));
        }
    }
}
