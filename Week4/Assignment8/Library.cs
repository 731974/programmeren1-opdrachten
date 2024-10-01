using Assignment4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class Library
    {

        public Book[] books;
        public int maxCapacity, currentBookIndex;


        public Library(int capacity)
        {
            books = new Book[capacity];
            maxCapacity = capacity;
            currentBookIndex = 0;
        }

        public void AddBook(Book book)
        {
            if (currentBookIndex < maxCapacity)
            {
                books[currentBookIndex] = book;
                currentBookIndex++;
            } 
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }
        }

       public void DisplayBooks()
        {
            Console.WriteLine("Books in library:");
            foreach (Book book in books) {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }
    }
}
