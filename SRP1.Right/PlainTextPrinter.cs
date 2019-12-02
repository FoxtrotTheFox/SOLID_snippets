using System;
using System.Collections.Generic;
using System.Text;

namespace SRP1.Right
{
    class PlainTextPrinter : IPrinter
    {
        public void PrintPage(string pageContent)
        {
            Console.WriteLine(pageContent);
        }

    }

}
