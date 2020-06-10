using Shared.Application.Interface;
using Shared.Domain.Interface.Repository;
using System.Collections.Generic;

namespace d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories
{
    public interface IAlunosRepository : IBaseCrudRepository<DML_BA_ALUNO>
    {

        //IEnumerable<object> GetByConvenioCPF(string Codigo);
        IResultadoApplication<dynamic> GetByAlunoFidelidade(string Termo);
       // IEnumerable<dynamic> GetByClienteConvenio(string Codigo);

        IResultadoApplication<dynamic> GetByAlunoContato(string Termo);
    }
}
