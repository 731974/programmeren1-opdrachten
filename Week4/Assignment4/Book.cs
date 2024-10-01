﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Book
    {
        public string Title, Author;

        public Book (string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Book information:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }
    }
}
