using Microsoft.Extensions.Caching.Memory;

namespace MemoryCacheSample.Services
{
    public class CachedSampleService : ISampleService
    {
        private const int sampleKey = 0;
        private readonly ISampleService sampleService;
        private readonly IMemoryCache memoryCache;

        public CachedSampleService()
        {
        }

        public CachedSampleService(ISampleService sampleService)
        {
            this.sampleService = sampleService;
        }

        public async Task<Sample> GetSampleAsync()
        {
            return await this.memoryCache.GetOrCreateAsync(sampleKey,
                async cacheEntry =>
                {
                    cacheEntry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
                    return await this.sampleService.GetSampleAsync();
                }); // attention: not deterministic and not rellay threadsafe
            // better use lazy cache
        }
    }
}
