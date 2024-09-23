// LibraryTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment8.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        [Test]
        public void Constructor_ValidCapacity_InitializesBooksArray()
        {
            // Arrange
            int capacity = 5;

            // Act
            var library = new Library(capacity);

            // Assert
            Assert.AreEqual(capacity, library.books.Length);
            Assert.AreEqual(0, library.currentBookIndex);
        }

        [Test]
        public void AddBook_ValidBook_AddsBookToArray()
        {
            // Arrange
            var library = new Library(3);
            var book = new Book("Title1", "Author1");

            // Act
            library.AddBook(book);

            // Assert
            Assert.AreEqual(book, library.books[0]);
            Assert.AreEqual(1, library.currentBookIndex);
        }

        [Test]
        public void AddBook_ExceedsCapacity_DisplaysMessage()
        {
            // Arrange
            var library = new Library(1);
            var book1 = new Book("Title1", "Author1");
            var book2 = new Book("Title2", "Author2");
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            library.AddBook(book1);
            library.AddBook(book2);

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.IsTrue(output.Contains("Library is full. Cannot add more books."));
        }

        [Test]
        public void DisplayBooks_ValidBooks_DisplaysCorrectInfo()
        {
            // Arrange
            var library = new Library(2);
            var book1 = new Book("Title1", "Author1");
            var book2 = new Book("Title2", "Author2");
            library.AddBook(book1);
            library.AddBook(book2);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            library.DisplayBooks();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.IsTrue(output.Contains("Title1"));
            Assert.IsTrue(output.Contains("Author1"));
            Assert.IsTrue(output.Contains("Title2"));
            Assert.IsTrue(output.Contains("Author2"));
        }
    }
}

