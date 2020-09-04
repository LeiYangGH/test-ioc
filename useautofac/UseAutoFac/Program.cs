using Autofac;
using System;

namespace UseAutoFac
{
    class Program
    {
        private static IContainer Container { get; set; }
        static IA ia;

        static void Main(string[] args)
        {

            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<A>().As<IA>();

            Container = builder.Build();
            using (var scope = Container.BeginLifetimeScope())
            {
                ia = scope.Resolve<IA>();
                ia.Fa();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
