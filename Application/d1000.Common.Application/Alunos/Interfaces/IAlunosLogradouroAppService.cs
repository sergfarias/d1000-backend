using d1000.Common.Application.Alunos.ViewModels;
using d1000.Common.Domain.Models.Data.Alunos.Entities;
using Shared.Application.Interface;

namespace d1000.Common.Application.Alunos.Interfaces
{
    public interface IAlunosLogradouroAppService : IBaseCrudAppService<AlunoLogradouroViewModel, DML_BA_ALUNO_LOGRADOURO>
    {
        bool ExisteLogradouroCadastrado(int id_aluno_logradouro);
    }
}