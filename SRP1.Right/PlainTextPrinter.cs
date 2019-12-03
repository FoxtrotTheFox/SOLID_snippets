using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Right
{
    class PlainTextPrinter : IPrinter
    {
        public void PrintPage(string pageContent)
        {
            Console.WriteLine(pageContent);
        }

    }

}
