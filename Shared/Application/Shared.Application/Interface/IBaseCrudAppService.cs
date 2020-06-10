using Shared.Domain.Interface.Entity;

namespace Shared.Application.Interface
{
    public interface IBaseCrudAppService<TViewModel, TEntity> : IBaseAppService<TViewModel, TEntity, string>
        where TEntity : class, IEntity<TEntity, string>
        where TViewModel : class
    {
        IResultadoApplication Inserir(TViewModel viewModel);

        IResultadoApplication Atualizar(TViewModel viewModel);

        IResultadoApplication RemoverPorId(string id);
        IResultadoApplication InserirRetornaModel(TViewModel viewModel);
    }
}
