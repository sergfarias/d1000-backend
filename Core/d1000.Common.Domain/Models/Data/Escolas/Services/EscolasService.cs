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
    public class EscolasService : BaseCrudService<DML_BA_ESCOLA>, IEscolasService
    {
        private IEscolasRepository repository;

        public EscolasService(IEscolasRepository repository, IValidationService validationService) : base(repository, validationService)
        {
            this.repository = repository;
        }

        public override ResultadoValidacao InserirRetornaModel(DML_BA_ESCOLA model)
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

        public void PreencherDados(DML_BA_ESCOLA data)
        {
            data.ID_USU = data.ID_USU; //Usuário Padrão
            data.DT_CAD = DateTime.Now; //Data do Cadastro
            data.DT_ULT_ALT = data.DT_ULT_ALT;
        }

      
        dynamic IEscolasService.GetByClienteFidelidade(string Termo)
        {
            return repository.GetByClienteFidelidade(Termo);
        }

        dynamic IEscolasService.GetByClienteConvenio(string Termo)
        {
            return repository.GetByClienteConvenio(Termo);
        }

        dynamic IEscolasService.GetByClienteContato(string Termo)
        {
            return repository.GetByClienteContato(Termo);
        }
    }
}
