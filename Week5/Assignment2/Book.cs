using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Book
    {
        //Automated proporties
        public  string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }
    }
}
