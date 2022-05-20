using Autofac;
using AutofacSample;

public static class Bootstrapper
{
    internal static void Run()
    {
        var builder = new ContainerBuilder();

        builder.Register(c => new SampleClass(c.Resolve<SampleClass>()));
        builder.RegisterType<SampleClass>();
        builder.RegisterInstance(new SampleClass(null));

        var container = builder.Build();
    }
}


