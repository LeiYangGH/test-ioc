using Autofac;
using System;

namespace UseAutoFac
{
    class Program
    {
        private static IContainer Container { get; set; }
        static IA ia;
        static B b;
        static C c;

        static void Main(string[] args)
        {

            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<A>().As<IA>();
            builder.RegisterType<B>().As<B>();
            builder.RegisterType<C>().As<C>();

            Container = builder.Build();
            using (var scope = Container.BeginLifetimeScope())
            {
                ia = scope.Resolve<IA>();
                ia.Fa();
                b = scope.Resolve<B>();
                b.Fb();
                c = scope.Resolve<C>();
                c.Fc();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
