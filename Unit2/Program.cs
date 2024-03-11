using System;

namespace Unit2
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            // Info info = new Info();
            // info.MyAtk = 10;
            // info.ShowAtk();
            
            Book[] books = new Book[3];
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book($"Book{i+1}", $"Author{i+1}");
                books[i].ShowBookInfo();
            }
        }
    }
}