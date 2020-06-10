using d1000.Common.Domain.Models.Data.Escolas.Entities;
using Shared.Domain.Interface.Repository;

namespace d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories
{
    public interface IEscolasLogradouroRepository : IBaseCrudRepository<DML_BA_ESCOLA_LOGRADOURO>
    {
        bool ExisteLogradouroCadastrado(int id_escola_logradouro);
    }
}