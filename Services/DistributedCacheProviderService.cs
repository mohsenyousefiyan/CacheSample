using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utilities;

namespace Services
{
    public class DistributedCacheProviderService : ICacheProviderService
    {
        private readonly IDistributedCache cache;

        public DistributedCacheProviderService(IDistributedCache cache )
        {
            this.cache = cache;
        }

        public Task DeleteAsync(string nameSpace, string keyName, CancellationToken token = default(CancellationToken))
            => cache.RemoveAsync(GetFullKeyName(nameSpace, keyName), token);

        public async Task<T> GetAsync<T>(string nameSpace, string keyName, CancellationToken token = default(CancellationToken))
        {
            var value = await cache.GetStringAsync(GetFullKeyName(nameSpace, keyName), token);
            if (value != null)
                return SerializerHelper.DeSerialize<T>(value);
            return default(T);
        }

        public Task SetAsync<T>(string nameSpace, string keyName, T value, TimeSpan? expierTime = null, CancellationToken token = default(CancellationToken))
        {
            var serializedValue = SerializerHelper.SerializeObject(value);
            DistributedCacheEntryOptions entryOptions = new DistributedCacheEntryOptions();
            if (expierTime != null)
                entryOptions.SetAbsoluteExpiration(expierTime.Value);

            return cache.SetStringAsync(GetFullKeyName(nameSpace, keyName), serializedValue, entryOptions, token);
        }


        public void Delete(string nameSpace, string keyName)
            => cache.Remove(GetFullKeyName(nameSpace, keyName));

        public T Get<T>(string nameSpace, string keyName)
        {
            var value = cache.GetString(GetFullKeyName(nameSpace, keyName));
            if (value != null)
                return SerializerHelper.DeSerialize<T>(value);
            return default(T);
        }

        public void Set<T>(string nameSpace, string keyName, T value, TimeSpan? expierTime = null)
        {
            var serializedValue = SerializerHelper.SerializeObject(value);
            DistributedCacheEntryOptions entryOptions = new DistributedCacheEntryOptions();
            if (expierTime != null)
                entryOptions.SetAbsoluteExpiration(expierTime.Value);

            cache.SetString(GetFullKeyName(nameSpace, keyName), serializedValue, entryOptions);
        }

        private string GetFullKeyName(string nameSpace, string keyName) => nameSpace + ":" + keyName;

    }
}
