using StrongInject;

namespace StrongInjectSample
{
    [Register(typeof(SampleApplication))]
    [Register(typeof(SampleService), Scope.SingleInstance, typeof(ISampleService))]
    internal partial class SampleContainer : IContainer<SampleApplication>
    {
    }
}