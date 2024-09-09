using NUnit.Framework;
using Assignment3;
using System.IO;

namespace Assignment3.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private Program _program;

        [SetUp]
        public void Setup()
        {
            _program = new Program();
        }

        [TestCase(5, "The number is positive")]
        [TestCase(-3, "The number is negative")]
        [TestCase(0, "The number is zero")]
        public void CheckNumber_VariousNumbers_PrintsExpectedMessage(int number, string expected)
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                _program.CheckNumber(number);

                // Assert
                StringAssert.Contains(expected, sw.ToString(), $"For number {number}, expected '{expected}' to be part of '{sw.ToString()}'.");
            }
        }
    }
}

