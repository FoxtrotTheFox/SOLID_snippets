
namespace LSP.Wrong
{
    public class Square : Rectangle
    {
        public override int Heigth { get => base.Heigth; set  { base.Heigth = value; base.Width = value; } }
        public override int Width { get => base.Width; set { base.Width = value; base.Heigth = value; } }
    }
}
