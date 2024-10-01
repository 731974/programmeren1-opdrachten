using NUnit.Framework;

namespace Assignment8.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void SetUp()
        {
            _account = new BankAccount("123456789", 500.0);
        }

        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Assert
            Assert.AreEqual("123456789", _account.AccountNumber);
            Assert.AreEqual(500.0, _account.Balance);
        }

        [Test]
        public void Deposit_IncreasesBalanceCorrectly()
        {
            // Act
            _account.Deposit(200.0);

            // Assert
            Assert.AreEqual(700.0, _account.Balance);
        }

        [Test]
        public void Deposit_DoesNotChangeBalanceForNegativeAmount()
        {
            // Act
            _account.Deposit(-100.0);

            // Assert
            Assert.AreEqual(500.0, _account.Balance);
        }

        [Test]
        public void Withdraw_DecreasesBalanceCorrectly()
        {
            // Act
            _account.Withdraw(100.0);

            // Assert
            Assert.AreEqual(400.0, _account.Balance);
        }

        [Test]
        public void Withdraw_DoesNotChangeBalanceForNegativeAmount()
        {
            // Act
            _account.Withdraw(-100.0);

            // Assert
            Assert.AreEqual(500.0, _account.Balance);
        }

        [Test]
        public void Withdraw_DoesNotChangeBalanceForInsufficientFunds()
        {
            // Act
            _account.Withdraw(600.0);

            // Assert
            Assert.AreEqual(500.0, _account.Balance);
        }
    }
}



