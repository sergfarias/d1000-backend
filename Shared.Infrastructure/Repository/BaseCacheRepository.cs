using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Shared.Domain.Interface.Entity;
using System.Collections.Generic;

namespace Shared.Infrastructure.Repository
{
    public abstract class BaseCacheRepository<T> : BaseCrudRepository<T>
        where T : class, IEntityCrud<T>
    {
        private readonly IMemoryCache cache;
        private readonly string type = typeof(T).Name;
        
        public BaseCacheRepository(IMemoryCache cache, DbContext context) : base(context)
        {
            this.cache = cache;
        }

        public new void Inserir(T entity)
        {
            base.Inserir(entity);
            ResetCache();
        }

        public new void InserirRetornaModel(T entity)
        {
            base.InserirRetornaModel(entity);
            ResetCache();
        }

        public new void Atualizar(T entity)
        {
            base.Atualizar(entity);
            ResetCache();
        }

        public new void Remover(T entity)
        {
            base.Remover(entity);
            ResetCache();
        }

        public new void RemoverPorId(string id)
        {
            base.RemoverPorId(id);
            ResetCache();
        }

        protected IList<dynamic> ListFromCache()
        {
            return cache.GetOrCreate(type, (entry) => {

                entry.SetPriority(CacheItemPriority.High);

                return GenerateData();
            });
        }

        protected abstract IList<dynamic> GenerateData();

        private void ResetCache()
        {
            cache.Remove(type);
        }
    }
}
