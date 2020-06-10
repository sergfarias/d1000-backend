using d1000.Common.Domain.Models.Data.Escolas.Entities;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services;
using Shared.Domain.Impl.Validator;
using Shared.Domain.Interface.Validator;
using Shared.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Escolas.Services
{
    public class EscolasLogradouroService : BaseCrudService<DML_BA_ESCOLA_LOGRADOURO>, IEscolasLogradouroService
    {
        private IEscolasLogradouroRepository repository;

        public EscolasLogradouroService(IEscolasLogradouroRepository repository, IValidationService validationService) : base(repository, validationService)
        {
            this.repository = repository;
        }
        public override ResultadoValidacao InserirRetornaModel(DML_BA_ESCOLA_LOGRADOURO model)
        {
            var resultado = base.InserirRetornaModel(model);
            return resultado;
        }
        bool IEscolasLogradouroService.ExisteLogradouroCadastrado(int id_cliente_logradouro)
        {
            return repository.ExisteLogradouroCadastrado(id_cliente_logradouro);
        }
    }
}