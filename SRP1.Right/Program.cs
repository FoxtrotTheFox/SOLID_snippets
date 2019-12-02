using System;

namespace SRP1.Right
{
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
