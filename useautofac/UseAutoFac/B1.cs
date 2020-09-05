using System;
using System.Collections.Generic;
using System.Text;

namespace UseAutoFac
{
    public class B1 : IB
    {
        public B1(A1 a1)
        {
            a1.Fa();
            Console.WriteLine("B1 ctor");
        }
        public void Fb()
        {
            Console.WriteLine("Fb1");
        }
    }
}