using Microsoft.EntityFrameworkCore;
using Shared.Domain.Interface.Entity;
using Shared.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Shared.Infrastructure.Repository
{
    public abstract class BaseRepository<TEntity, TType> : IBaseRepository<TEntity, TType>
         where TEntity : class, IEntity<TEntity, TType>
    {
        protected readonly DbContext context;

        public BaseRepository(DbContext context)
        {
            this.context = context;
        }

        public TEntity RecuperarPorId(TType id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public virtual ICollection<TEntity> RecuperarTodos(int? numeroPagina, int? registrosPorPagina)
        {
            if (numeroPagina.HasValue && registrosPorPagina.HasValue)
                return context.Set<TEntity>()
                    .AsNoTracking()
                    .Skip((numeroPagina.Value - 1) * registrosPorPagina.Value)
                    .Take(registrosPorPagina.Value + 1)
                    .ToList();

            return context.Set<TEntity>()
                .AsNoTracking()
                .ToList();
        }

        protected void Inserir(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        protected void Atualizar(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        protected void Remover(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        protected void RemoverPorId(TType id)
        {
            var entity = RecuperarPorId(id);

            Remover(entity);
        }

        public int Commit()
        {
            return context.SaveChanges();
        }
    }
}
