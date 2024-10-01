using NUnit.Framework;
using System;
using System.IO;

namespace Assignment6.Tests
{
    [TestFixture]
    public class AccountTests
    {
        private Account _account;
        private StringWriter _stringWriter;

        [SetUp]
        public void SetUp()
        {
            _account = new Account("John Doe");
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            _stringWriter.Dispose();
            Console.SetOut(Console.Out);
        }

        [Test]
        public void Constructor_InitializesAccountHolderCorrectly()
        {
            // Act
            _account.DisplayAccountInfo();
            var result = _stringWriter.ToString().Replace("\r\n", "\n"); // Normalize line endings

            // Assert
            StringAssert.Contains("Account Holder: John Doe", result);
        }

        [Test]
        public void Deposit_IncreasesAmountCorrectly()
        {
            // Act
            _account.Deposit(100.0);
            _account.DisplayAccountInfo();
            var result = _stringWriter.ToString().Replace("\r\n", "\n"); // Normalize line endings

            // Assert
            StringAssert.Contains("Amount: 100", result);
        }

        [Test]
        public void LogTransaction_PrintsCorrectMessage()
        {
            // Act
            _account.Deposit(100.0);
            var result = _stringWriter.ToString().Replace("\r\n", "\n"); // Normalize line endings

            // Assert
            StringAssert.Contains("Deposit successful.", result);
        }

        [Test]
        public void DisplayAccountInfo_PrintsCorrectInfo()
        {
            // Arrange
            _account.Deposit(100.0);

            // Act
            _account.DisplayAccountInfo();
            var result = _stringWriter.ToString().Replace("\r\n", "\n"); // Normalize line endings

            // Assert
            StringAssert.Contains("Account Holder: John Doe", result);
            StringAssert.Contains("Amount: 100", result);
        }
    }
}


