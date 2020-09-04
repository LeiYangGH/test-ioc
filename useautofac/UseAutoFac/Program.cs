using Autofac;
using System;

namespace UseAutoFac
{
    class Program
    {
        private static IContainer Container { get; set; }
        static IA ia;
        static B b;

        static void Main(string[] args)
        {

            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<A>().As<IA>();
            builder.RegisterType<B>().As<B>();

            Container = builder.Build();
            using (var scope = Container.BeginLifetimeScope())
            {
                ia = scope.Resolve<IA>();
                ia.Fa();
                b = scope.Resolve<B>();
                b.Fb();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
