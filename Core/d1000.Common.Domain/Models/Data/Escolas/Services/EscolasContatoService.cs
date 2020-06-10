using d1000.Common.Domain.Models.Data.Escolas.Entities;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services;
using Shared.Domain.Impl.Validator;
using Shared.Domain.Interface.Validator;
using Shared.Domain.Service;

namespace d1000.Common.Domain.Models.Data.Escolas.Services
{
    public class EscolasContatoService : BaseCrudService<DML_BA_ESCOLA_CONTATO>, IEscolasContatoService
    {
        private IEscolasContatoRepository repository;

        public EscolasContatoService(IEscolasContatoRepository repository, IValidationService validationService) : base(repository, validationService)
        {
            this.repository = repository;
        }
        public override ResultadoValidacao InserirRetornaModel(DML_BA_ESCOLA_CONTATO model)
        {
            var resultado = base.InserirRetornaModel(model);
            return resultado;
        }
        bool IEscolasContatoService.ExisteContatoCadastrado(int id_contato)
        {
            return repository.ExisteContatoCadastrado(id_contato);
        }
    }
}
