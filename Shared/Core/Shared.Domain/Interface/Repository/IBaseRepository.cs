using Shared.Domain.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain.Interface.Repository
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class, IEntity<TEntity, TType>
    {
        TEntity RecuperarPorId(TType id);

        ICollection<TEntity> RecuperarTodos(int? numeroPagina = null, int? registrosPorPagina = null);

        int Commit();
    }
}
