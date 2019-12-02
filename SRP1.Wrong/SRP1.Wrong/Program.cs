using System;

namespace SRP1.Wrong
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void TurnPage()
        {
            Console.WriteLine("Page turned."); 
        }

        public void PrintCurrentPage()
        {
            Console.WriteLine("Current page content");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book { Title = "Clean Code", Author = "Robert C. Martin"};
            book.TurnPage();
            book.PrintCurrentPage();
        }
    }
}
