using System;
using System.Collections.Generic;
using System.Text;

namespace UseAutoFac
{
    public class B2 : IB
    {
        public B2(A2 a2)
        {
            a2.Fa();
            Console.WriteLine("B2 ctor");
        }
        public void Fb()
        {
            Console.WriteLine("Fb2");
        }
    }
}
