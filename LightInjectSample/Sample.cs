using LightInject;

namespace LightInjectSample;

public class Sample
{
    private void SampleMethod()
    {
        var container = new ServiceContainer();

        container.Register<ISampleService, SampleService>();
        container.GetInstance<ISampleService>();
        var instance = container.GetInstance<ISampleService>();
    }
}

public interface ISampleService
{
}

public class SampleService : ISampleService
{
}