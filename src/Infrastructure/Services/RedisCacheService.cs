using Application.Common.Interfaces;
using Hyperion;
using Microsoft.Extensions.Caching.Distributed;

namespace Infrastructure.Services;

public class RedisCacheService : IMemoryCache
{
    private readonly IDistributedCache _cache;
    private readonly Serializer _serializer;
    public RedisCacheService(IDistributedCache cache)
    {
        _cache = cache;       
        _serializer = new Serializer(new SerializerOptions(preserveObjectReferences: true));
    }
    public async Task SetObjectAsync<T>(string key, T value, double lifeSpan = 14400, bool sliding = false)
    {
        await using var mem = new MemoryStream();
        _serializer.Serialize(value, mem);
        
        var bytes = mem.ToArray();
        DistributedCacheEntryOptions options = new();

        if (sliding)
        {
            options.SlidingExpiration = System.TimeSpan.FromSeconds(lifeSpan);
        }
        else
        {
            options.AbsoluteExpirationRelativeToNow = System.TimeSpan.FromSeconds(lifeSpan);
        }
        await _cache.SetAsync(key, bytes, options);
    }

    public async Task<T> GetObjectAsync<T>(string key)
    {
       var bytes = await _cache.GetAsync(key);
        if (bytes == null)
        {
            return default;
        }
        await using var mem = new MemoryStream(bytes);   
        return _serializer.Deserialize<T>(mem);
    }    
}
