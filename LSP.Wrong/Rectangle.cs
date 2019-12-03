
namespace LSP.Wrong
{
    public class Rectangle
    {
        virtual public int Width { get; set; }
        virtual public int Heigth { get; set; }

        virtual public int Area() 
        { 
            return Width * Heigth; 
        }
    }
}
