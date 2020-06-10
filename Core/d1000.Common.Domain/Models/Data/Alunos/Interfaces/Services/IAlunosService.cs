using Shared.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services
{
    public interface IAlunosService : IBaseCrudService<DML_BA_ALUNO>
    {
        //object GetByConvenioCPF(string Codigo);
        dynamic GetByAlunoFidelidade(string Termo);

        //object GetByClienteConvenio(string Codigo);

        dynamic GetByAlunoContato(string Termo);
    }
}
