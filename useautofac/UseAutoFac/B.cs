using System;
using System.Collections.Generic;
using System.Text;

namespace UseAutoFac
{
    public class B
    {
        private IA ia;
        public B(IA ia)
        {
            ia.Fa();
            Console.WriteLine("B ctor");
        }

        //public static B CreateB(IA ia)
        //{
        //    return new B(ia);
        //}

        public void Fb()
        {
            Console.WriteLine("Fb");
        }
    }
}
