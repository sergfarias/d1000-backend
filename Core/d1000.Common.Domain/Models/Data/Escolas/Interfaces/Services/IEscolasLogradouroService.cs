using d1000.Common.Domain.Models.Data.Escolas.Entities;
using Shared.Domain.Interface.Service;

namespace d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services
{
    public interface IEscolasLogradouroService : IBaseCrudService<DML_BA_ESCOLA_LOGRADOURO>
    {
        bool ExisteLogradouroCadastrado(int id_escola_logradouro);
    }
}