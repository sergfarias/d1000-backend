using Shared.Application.Interface;
using Shared.Domain.Interface.Repository;
using System.Collections.Generic;

namespace d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories
{
    public interface IEscolasRepository : IBaseCrudRepository<DML_BA_ESCOLA>
    {

       // IEnumerable<object> GetByConvenioCPF(string Codigo);
        IResultadoApplication<dynamic> GetByClienteFidelidade(string Termo);
        IEnumerable<dynamic> GetByClienteConvenio(string Codigo);

        IResultadoApplication<dynamic> GetByClienteContato(string Termo);
    }
}
