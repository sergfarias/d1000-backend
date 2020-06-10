using d1000.Common.Domain.Models.Data.Escolas.Entities;
using Shared.Domain.Interface.Service;

namespace d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services
{
    public interface IEscolasContatoService : IBaseCrudService<DML_BA_ESCOLA_CONTATO>
    {
        bool ExisteContatoCadastrado(int id_contato);
    }
}
