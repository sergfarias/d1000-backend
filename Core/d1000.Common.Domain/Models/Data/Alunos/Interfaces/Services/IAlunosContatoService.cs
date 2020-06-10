using d1000.Common.Domain.Models.Data.Alunos.Entities;
using Shared.Domain.Interface.Service;

namespace d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services
{
    public interface IAlunosContatoService : IBaseCrudService<DML_BA_ALUNO_CONTATO>
    {
        bool ExisteContatoCadastrado(int id_contato);
    }
}
