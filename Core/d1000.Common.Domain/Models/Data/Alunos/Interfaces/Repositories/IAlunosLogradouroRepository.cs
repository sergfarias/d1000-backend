using d1000.Common.Domain.Models.Data.Alunos.Entities;
using Shared.Domain.Interface.Repository;

namespace d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories
{
    public interface IAlunosLogradouroRepository : IBaseCrudRepository<DML_BA_ALUNO_LOGRADOURO>
    {
        bool ExisteLogradouroCadastrado(int id_aluno_logradouro);
    }
}