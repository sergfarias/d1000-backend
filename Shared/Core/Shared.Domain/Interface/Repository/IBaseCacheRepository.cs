using System.Collections.Generic;

namespace Shared.Infrastructure.Repository
{
    public interface IBaseCacheRepository<T> where T : class
    {
        IList<dynamic> ListFromCache();
    }
}
