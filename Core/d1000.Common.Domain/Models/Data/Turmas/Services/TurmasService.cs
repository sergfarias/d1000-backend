using d1000.Common.Domain.Models.Data.Turmas.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Turmas.Interfaces.Services;
using Shared.Domain.Impl.Validator;
using Shared.Domain.Interface.Validator;
using Shared.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Turmas.Services
{
    public class TurmasService : BaseCrudService<DML_BA_TURMA>, ITurmasService
    {
        private ITurmasRepository repository;

        public TurmasService(ITurmasRepository repository, IValidationService validationService) : base(repository, validationService)
        {
            this.repository = repository;
        }

        public override ResultadoValidacao InserirRetornaModel(DML_BA_TURMA model)
       {
            var resultado = new ResultadoValidacao();

            PreencherDados(model);

            resultado = base.InserirRetornaModel(model);

            var res = new ResultadoValidacao(model.ID_ESCOLA);

            if (resultado.CodigoRetorno == res.CodigoRetorno)
            {
                resultado = res;
            }

            return resultado;
        }

        public void PreencherDados(DML_BA_TURMA data)
        {
            data.ID_USU = data.ID_USU; //Usuário Padrão
            data.DT_CAD = DateTime.Now; //Data do Cadastro
            data.DT_ULT_ALT = data.DT_ULT_ALT;
        }

      
    }
}
