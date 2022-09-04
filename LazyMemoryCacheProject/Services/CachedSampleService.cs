using LazyCache;
using Microsoft.Extensions.Caching.Memory;

namespace LazyMemoryCacheProject.Services;

public class CachedSampleService : ISampleService
{
    private const int sampleKey = 0;
    private readonly ISampleService sampleService;
    private readonly IAppCache appCache;

    public CachedSampleService()
    {
    }

    public CachedSampleService(ISampleService sampleService, IAppCache appCache)
    {
        this.sampleService = sampleService;
        this.appCache = appCache;
    }

    public async Task<Sample> GetSampleAsync()
    {
        return await appCache.GetOrAddAsync(sampleKey.ToString(),
            async cacheEntry =>
            {
                cacheEntry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
                return await sampleService.GetSampleAsync();
            }); // is like 2x slower than dotnetframework memorycache but threadsafe
    }
}