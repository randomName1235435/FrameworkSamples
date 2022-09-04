namespace MemoryCacheSample.Services;

public interface ISampleService
{
    Task<Sample> GetSampleAsync();
}