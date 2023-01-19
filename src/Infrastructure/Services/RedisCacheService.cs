using Application.Common.Interfaces;
using Domain.Entities;
using Hyperion;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace Infrastructure.Services;

public class RedisCacheService : IMemoryCache
{
    private readonly ILogger<RedisCacheService> _logger;
    private readonly IDistributedCache _cache;
    private readonly Serializer _serializer;
    private readonly string _connectionString;
    private readonly bool _alive;
    public RedisCacheService(ILogger<RedisCacheService> logger, IDistributedCache cache, IConfiguration configuration)
    {
        _logger = logger;
        _cache = cache;
        _serializer = new Serializer(new SerializerOptions(preserveObjectReferences: true));
        _connectionString = configuration.GetConnectionString("Redis")
            ?? throw new ArgumentNullException("ConnectionString:Redis");
        _alive = IsAlive();

    }
    public async Task SetObjectAsync<T>(string key, T value, double lifeSpan = 14400, bool sliding = false)
    {
        if (_alive)
        {
            await using var mem = new MemoryStream();
            _serializer.Serialize(value, mem);

            var bytes = mem.ToArray();
            DistributedCacheEntryOptions options = new();

            if (sliding)
                options.SlidingExpiration = TimeSpan.FromSeconds(lifeSpan);
            else
                options.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(lifeSpan);

            await _cache.SetAsync(key, bytes, options);
        }
    }

    public async Task<T> GetObjectAsync<T>(string key)
    {
        if (!_alive)
        {
            return default;
        }
        var bytes = await _cache.GetAsync(key);
        if (bytes == null)
        {
            return default;
        }
        await using var mem = new MemoryStream(bytes);
        return _serializer.Deserialize<T>(mem);
    }

    public async Task Remove(string key)
    {
        if (_alive)
        {
            _cache.Remove(key);
        }
    }

    private bool IsAlive()
    {
        try
        {
            ConnectionMultiplexer.Connect(_connectionString);
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);            
        }
        return false;   
    }
}
