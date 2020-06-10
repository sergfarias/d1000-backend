using d1000.Common.Domain.Models.Data.Alunos.Entities;
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
    public class AlunosLogradouroService : BaseCrudService<DML_BA_ALUNO_LOGRADOURO>, IAlunosLogradouroService
    {
        private IAlunosLogradouroRepository repository;

        public AlunosLogradouroService(IAlunosLogradouroRepository repository, IValidationService validationService) : base(repository, validationService)
        {
            this.repository = repository;
        }
        public override ResultadoValidacao InserirRetornaModel(DML_BA_ALUNO_LOGRADOURO model)
        {
            var resultado = base.InserirRetornaModel(model);
            return resultado;
        }
        bool IAlunosLogradouroService.ExisteLogradouroCadastrado(int id_cliente_logradouro)
        {
            return repository.ExisteLogradouroCadastrado(id_cliente_logradouro);
        }
    }
}