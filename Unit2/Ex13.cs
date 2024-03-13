using System;

namespace Unit2
{
    public struct Book
    {
        public string BookName;
        public string BookAuthor;
        
        public Book(string BookName, string BookAuthor)
        {

            this.BookName = BookName;
            this.BookAuthor = BookAuthor;
        }

        public void ShowBookInfo()
        {
            Console.WriteLine("Name: {0}", this.BookName);
            Console.WriteLine("Author: {0}", this.BookAuthor);
        }
    
    }
}