using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Wrong2
{
    public class ToyDuck : Duck
    {
        bool HasBatteries { get; set; }

        public override void Quack()
        {
            if (HasBatteries)
                Console.WriteLine("Quack!");
            else
                throw new Exception("Need batteries to work");
        }
    }
}
