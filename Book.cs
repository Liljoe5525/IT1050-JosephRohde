using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.css
{
    class Book
    {
        private string Title;
        private string Author;
        private int Year;
        public Book(string Title, string Author, int year)
        {
            this.Title = Title;
            this.Author = Author;
        }
        public void Display()
        {
            Console.WriteLine("{0} writtenby {1}\n", Title, Author);
        }
    }

}
