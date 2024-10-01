using NUnit.Framework;
using Assignment1;

namespace Assignment1.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void AgeProperty_GetterSetter_WorksCorrectly()
        {
            // Arrange
            var person = new Person(25, "John Doe");

            // Act
            person.Age = 30;
            var age = person.Age;

            // Assert
            Assert.AreEqual(30, age);
        }

        [Test]
        public void NameProperty_GetterSetter_WorksCorrectly()
        {
            // Arrange
            var person = new Person(25, "John Doe");

            // Act
            person.Name = "Jane Doe";
            var name = person.Name;

            // Assert
            Assert.AreEqual("Jane Doe", name);
        }

        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange & Act
            var person = new Person(25, "John Doe");

            // Assert
            Assert.AreEqual(25, person.Age);
            Assert.AreEqual("John Doe", person.Name);
        }
    }
}
