using NUnit.Framework;
using Assignment3;
using System;

namespace Assignment3.Tests
{
    [TestFixture]
    public class CarTests
    {
        [Test]
        public void MakeProperty_GetterSetter_WorksCorrectly()
        {
            // Arrange
            var car = new Car("Toyota", "Corolla", 2020);

            // Act
            car.Make = "Honda";
            var make = car.Make;

            // Assert
            Assert.AreEqual("Honda", make);
        }

        [Test]
        public void ModelProperty_GetterSetter_WorksCorrectly()
        {
            // Arrange
            var car = new Car("Toyota", "Corolla", 2020);

            // Act
            car.Model = "Civic";
            var model = car.Model;

            // Assert
            Assert.AreEqual("Civic", model);
        }

        [Test]
        public void YearProperty_GetterSetter_WorksCorrectly()
        {
            // Arrange
            var car = new Car("Toyota", "Corolla", 2020);

            // Act
            car.Year = 2021;
            var year = car.Year;

            // Assert
            Assert.AreEqual(2021, year);
        }

        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange & Act
            var car = new Car("Toyota", "Corolla", 2020);

            // Assert
            Assert.AreEqual("Toyota", car.Make);
            Assert.AreEqual("Corolla", car.Model);
            Assert.AreEqual(2020, car.Year);
        }

        [Test]
        public void DisplayCarInfo_PrintsCorrectInfo_CaseInsensitive()
        {
            // Arrange
            var car = new Car("Toyota", "Corolla", 2020);
            var expectedOutput = "Car details\nMake: Toyota\nModel: Corolla\nYear: 2020\n";

            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);

                // Act
                car.DisplayCarInfo();

                // Assert
                var result = sw.ToString().Replace("\r\n", "\n"); // Normalize line endings
                StringAssert.Contains(expectedOutput.ToLower(), result.ToLower());
            }
        }
    }
}

