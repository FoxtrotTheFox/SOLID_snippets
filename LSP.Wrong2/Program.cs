using System;

namespace LSP.Wrong2
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck toyDuck = new ToyDuck();
            Duck duck = new GenericDuck();

            duck.Quack();
            toyDuck.Quack();
        }
    }
}
