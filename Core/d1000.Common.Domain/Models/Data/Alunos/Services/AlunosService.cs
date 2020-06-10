using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services;
using Shared.Domain.Impl.Validator;
using Shared.Domain.Interface.Validator;
using Shared.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Alunos.Services
{
    public class AlunosService : BaseCrudService<DML_BA_ALUNO>, IAlunosService
    {
        private IAlunosRepository repository;

        public AlunosService(IAlunosRepository repository, IValidationService validationService) : base(repository, validationService)
        {
            this.repository = repository;
        }

        public override ResultadoValidacao InserirRetornaModel(DML_BA_ALUNO model)
       {
            var resultado = new ResultadoValidacao();

            PreencherDados(model);

            resultado = base.InserirRetornaModel(model);

            var res = new ResultadoValidacao(model.ID_ALUNO);

            if (resultado.CodigoRetorno == res.CodigoRetorno)
            {
                resultado = res;
            }

            return resultado;
        }

        public void PreencherDados(DML_BA_ALUNO data)
        {
            data.ID_USU = data.ID_USU; //Usuário Padrão
            data.DT_CAD = DateTime.Now; //Data do Cadastro
            data.DT_ULT_ALT = data.DT_ULT_ALT;
        }

        
        dynamic IAlunosService.GetByAlunoFidelidade(string Termo)
        {
            return repository.GetByAlunoFidelidade(Termo);
        }

        
        dynamic IAlunosService.GetByAlunoContato(string Termo)
        {
            return repository.GetByAlunoContato(Termo);
        }
    }
}
