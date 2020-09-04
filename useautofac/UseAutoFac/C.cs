using System;
using System.Collections.Generic;
using System.Text;

namespace UseAutoFac
{
    public class C
    {
        public C(Func<IA, B> factory)
        {
            Console.WriteLine("C ctor");
            Console.WriteLine(factory);
        }
        public void Fc()
        {
            Console.WriteLine("Fc");
        }
    }
}
