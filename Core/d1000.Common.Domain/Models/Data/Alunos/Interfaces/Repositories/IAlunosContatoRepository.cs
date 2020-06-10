using d1000.Common.Domain.Models.Data.Alunos.Entities;
using Shared.Domain.Interface.Repository;

namespace d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories
{
    public interface IAlunosContatoRepository : IBaseCrudRepository<DML_BA_ALUNO_CONTATO>
    {
        bool ExisteContatoCadastrado(int id_contato);
    }
}
