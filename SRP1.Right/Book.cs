using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Right
{
    public class Book
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
}
