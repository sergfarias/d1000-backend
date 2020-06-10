using d1000.Common.Application.Alunos.ViewModels;
using d1000.Common.Domain.Models.Data.Alunos.Entities;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Alunos.Interfaces
{
    public interface IAlunosContatoAppService : IBaseCrudAppService<AlunoContatoViewModel, DML_BA_ALUNO_CONTATO>
    {
        bool ExisteContatoCadastrado(int id_contato);
    }
}
