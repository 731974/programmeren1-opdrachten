// ProgramTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment5.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Constructor_ValidInput_PropertiesAreSet()
        {
            // Arrange
            string name = "John Doe";
            int age = 30;

            // Act
            var person = new Person(name, age);

            // Assert
            Assert.AreEqual(name, person.Name);
            Assert.AreEqual(age, person.Age);
        }

        [Test]
        public void DisplayPersonInfo_ValidInput_DisplaysCorrectInfo()
        {
            // Arrange
            string name = "John Doe";
            int age = 30;
            var person = new Person(name, age);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            person.DisplayPersonInfo();

            // Assert
            var output = stringWriter.ToString();
            Assert.IsTrue(output.Contains($"Name: {name}"));
            Assert.IsTrue(output.Contains($"Age: {age}"));
        }
        [Test]
        public void PrintPersonArray_ValidInput_DisplaysCorrectInfo()
        {
            // Arrange
            var persons = new Person[]
            {
                new Person("John Doe", 30),
                new Person("Jane Smith", 25),
                new Person("Alice Johnson", 40)
            };

            var program = new Program();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.PrintPersonArray(persons);

            // Assert
            var output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Displaying all persons:"));
            Assert.IsTrue(output.Contains("Person 1"));
            Assert.IsTrue(output.Contains("Name: John Doe"));
            Assert.IsTrue(output.Contains("Age: 30"));
            Assert.IsTrue(output.Contains("Person 2"));
            Assert.IsTrue(output.Contains("Name: Jane Smith"));
            Assert.IsTrue(output.Contains("Age: 25"));
            Assert.IsTrue(output.Contains("Person 3"));
            Assert.IsTrue(output.Contains("Name: Alice Johnson"));
            Assert.IsTrue(output.Contains("Age: 40"));
        }
    }
}
