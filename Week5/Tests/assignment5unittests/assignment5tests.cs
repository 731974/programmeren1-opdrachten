using NUnit.Framework;

namespace Assignment5.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void ModifyByValue_DoesNotChangeOriginalValue()
        {
            // Arrange
            var program = new Program();
            int originalValue = 10;

            // Act
            program.ModifyByValue(originalValue);

            // Assert
            Assert.AreEqual(10, originalValue);
        }

        [Test]
        public void ModifyByReference_ChangesOriginalValue()
        {
            // Arrange
            var program = new Program();
            int originalValue = 10;

            // Act
            program.ModifyByReference(ref originalValue);

            // Assert
            Assert.AreEqual(30, originalValue);
        }
    }
}

