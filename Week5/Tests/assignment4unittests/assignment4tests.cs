using NUnit.Framework;
using Assignment4;

namespace Assignment4.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void RadiusProperty_GetterSetter_WorksCorrectly()
        {
            // Arrange
            var circle = new Circle(5.0);

            // Act
            circle.Radius = 10.0;
            var radius = circle.Radius;

            // Assert
            Assert.AreEqual(10.0, radius);
        }

        [Test]
        public void AreaProperty_CalculatesCorrectly()
        {
            // Arrange
            var circle = new Circle(5.0);

            // Act
            var area = circle.Area;

            // Assert
            Assert.AreEqual(Math.PI * 5.0 * 5.0, area);
        }

        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange & Act
            var circle = new Circle(5.0);

            // Assert
            Assert.AreEqual(5.0, circle.Radius);
        }

        [Test]
        public void DisplayCircleInfo_PrintsCorrectInfo()
        {
            // Arrange
            var circle = new Circle(5.0);
            var expectedOutput = $"Radius: 5\nArea: {Math.PI * 5.0 * 5.0}\n";

            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);

                // Act
                circle.DisplayCircleInfo();

                // Assert
                var result = sw.ToString().Replace("\r\n", "\n"); // Normalize line endings
                Assert.AreEqual(expectedOutput, result);
            }
        }
    }
}

