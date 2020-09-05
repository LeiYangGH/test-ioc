using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace UseAutoFac
{
    public class C
    {
        private Func<IA, IB> factory;
        public C(Func<IA, IB> factory)
        {
            Console.WriteLine("C ctor");
            Console.WriteLine(factory);
            this.factory = factory;

        }
        public void Fc()
        {
            Console.WriteLine("Fc");
            Console.WriteLine(this.factory(new A1()).GetType());

        }
    }
}
