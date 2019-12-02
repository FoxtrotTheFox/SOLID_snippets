using System;

namespace SRP1.Right
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void TurnPage()
        {
            Console.WriteLine("Page turned.");
        }

        public string GetCurrentPageContent()
        {
           return "Current page content";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book { Title = "Clean Code", Author = "Robert C. Martin" };
            book.TurnPage();

            string pageContent = book.GetCurrentPageContent();

            IPrinter plainTextPrinter = new PlainTextPrinter();
            plainTextPrinter.PrintPage(pageContent);

            IPrinter htmlPrinter = new HTMLPrinter();
            htmlPrinter.PrintPage(pageContent);
        }
    }
}
