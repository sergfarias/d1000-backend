using d1000.Common.Application.Alunos.ViewModels;
using d1000.Common.Domain.Models.Data.Alunos;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Alunos.Interfaces
{
    public interface IAlunosAppService : IBaseCrudAppService<AlunoViewModel, DML_BA_ALUNO>
    {
        IResultadoApplication<dynamic> GetByAlunoFidelidade(string Termo);
        IResultadoApplication<dynamic> GetByAlunoContato(string Termo);
    }
}
