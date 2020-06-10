using d1000.Common.Domain.Models.Data.Alunos.Entities;
using Shared.Domain.Interface.Service;

namespace d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services
{
    public interface IAlunosLogradouroService : IBaseCrudService<DML_BA_ALUNO_LOGRADOURO>
    {
        bool ExisteLogradouroCadastrado(int id_aluno_logradouro);
    }
}