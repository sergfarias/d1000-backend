using Shared.Domain.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain.Interface.Service
{
    public interface IBaseService<TEntity, TTYpe> where TEntity : class, IEntity<TEntity, TTYpe>
    {
        TEntity RecuperarPorId(TTYpe id);

        ICollection<TEntity> RecuperarTodos(int? numeroPagina = null, int? registrosPorPagina = null);

        int Commit();
    }
}
