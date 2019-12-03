using System;

namespace LSP.Wrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Rectangle square = new Square();

            WorkWithRectangle(rectangle);
            WorkWithRectangle(square);
        }

        static void WorkWithRectangle(Rectangle rectangle)
        {
            rectangle.Heigth = 2;
            rectangle.Width = 3;
            Console.WriteLine(rectangle.Area());
        }
    }
}
