using Shared.Domain.Interface.Entity;
using System.Collections.Generic;

namespace Shared.Application.Interface
{
    public interface IBaseAppService<TViewModel, TEntity, TType> 
        where TEntity : class, IEntity<TEntity, TType>
        where TViewModel : class
    {
        IResultadoApplication<ICollection<TViewModel>> RecuperarTodos(int? numeroPagina = null, int? registrosPorPagina = 10);

        IResultadoApplication<TViewModel> RecuperarPorId(TType id);
    }
}
