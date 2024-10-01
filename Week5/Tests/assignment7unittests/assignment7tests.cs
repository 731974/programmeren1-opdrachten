using NUnit.Framework;

namespace Assignment7.Tests
{
    [TestFixture]
    public class ProductTests
    {
        private Product _product;

        [SetUp]
        public void SetUp()
        {
            _product = new Product(100.0, "Test Product");
        }

        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Assert
            Assert.AreEqual(100.0, _product.Price);
            Assert.AreEqual("Test Product", _product.Name);
        }

        [Test]
        public void PriceProperty_SetterDoesNotAllowNegativeValues()
        {
            // Act
            typeof(Product).GetProperty("Price").SetValue(_product, -50.0);

            // Assert
            Assert.AreEqual(100.0, _product.Price);
        }

        [Test]
        public void PriceProperty_SetterAllowsPositiveValues()
        {
            // Act
            typeof(Product).GetProperty("Price").SetValue(_product, 150.0);

            // Assert
            Assert.AreEqual(150.0, _product.Price);
        }

        [Test]
        public void NameProperty_GetterSetter_WorksCorrectly()
        {
            // Act
            _product.Name = "New Product Name";

            // Assert
            Assert.AreEqual("New Product Name", _product.Name);
        }
    }
}



