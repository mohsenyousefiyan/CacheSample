using System;
using System.Threading;
using System.Threading.Tasks;

namespace Services
{
    public interface ICacheProviderService
    {
        Task SetAsync<T>(string nameSpace, string keyName, T value, TimeSpan? expierTime = null, CancellationToken token = default(CancellationToken));

        Task<T> GetAsync<T>(string nameSpace, string keyName, CancellationToken token = default(CancellationToken));

        Task DeleteAsync(string nameSpace, string keyName, CancellationToken token = default(CancellationToken));

        void Set<T>(string nameSpace, string keyName, T value, TimeSpan? expierTime = null);

        T Get<T>(string nameSpace, string keyName);

        void Delete(string nameSpace, string keyName);
    }
}
