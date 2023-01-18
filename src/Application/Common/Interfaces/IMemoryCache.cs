using Microsoft.Extensions.Caching.Distributed;

namespace Application.Common.Interfaces
{
    public interface IMemoryCache
    {
        public Task SetObjectAsync<T>(string key, T value, double lifeSpan = 14400, bool sliding = false);

        public Task<T> GetObjectAsync<T>(string key);
    }
}
