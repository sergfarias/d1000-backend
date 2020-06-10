using Shared.Domain.Interface.Entity;
using Shared.Domain.Interface.Repository;
using Shared.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain.Service
{
    public abstract class BaseService<TEntity, TTYpe> : IBaseService<TEntity, TTYpe>
        where TEntity : class, IEntity<TEntity, TTYpe>
    {
        private readonly IBaseRepository<TEntity, TTYpe> repository;

        public BaseService(IBaseRepository<TEntity, TTYpe> repository)
        {
            this.repository = repository;
        }

        public TEntity RecuperarPorId(TTYpe id)
        {
            return repository.RecuperarPorId(id);
        }

        public virtual ICollection<TEntity> RecuperarTodos(int? numeroPagina, int? registrosPorPagina)
        {
            return repository.RecuperarTodos(numeroPagina, registrosPorPagina);
        }

        public int Commit()
        {
            return repository.Commit();
        }
    }
}
