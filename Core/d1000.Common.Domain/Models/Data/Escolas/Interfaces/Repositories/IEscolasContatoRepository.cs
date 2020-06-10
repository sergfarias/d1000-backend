using d1000.Common.Domain.Models.Data.Escolas.Entities;
using Shared.Domain.Interface.Repository;

namespace d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories
{
    public interface IEscolasContatoRepository : IBaseCrudRepository<DML_BA_ESCOLA_CONTATO>
    {
        bool ExisteContatoCadastrado(int id_contato);
    }
}
