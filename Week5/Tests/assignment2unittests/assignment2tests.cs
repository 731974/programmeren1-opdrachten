using NUnit.Framework;
using Assignment2;

namespace Assignment2.Tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void TitleProperty_GetterSetter_WorksCorrectly()
        {
            // Arrange
            var book = new Book("Original Title", "Author Name");

            // Act
            book.Title = "New Title";
            var title = book.Title;

            // Assert
            Assert.AreEqual("New Title", title);
        }

        [Test]
        public void AuthorProperty_GetterSetter_WorksCorrectly()
        {
            // Arrange
            var book = new Book("Book Title", "Original Author");

            // Act
            book.Author = "New Author";
            var author = book.Author;

            // Assert
            Assert.AreEqual("New Author", author);
        }

        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange & Act
            var book = new Book("Book Title", "Author Name");

            // Assert
            Assert.AreEqual("Book Title", book.Title);
            Assert.AreEqual("Author Name", book.Author);
        }
    }
}
