using d1000.Common.Domain.Models.Data.Base.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Base.Interfaces.Services;
using Shared.Domain.Interface.Validator;
using Shared.Domain.Service;

namespace d1000.Common.Domain.Models.Data.Base.Services
{
    public class BaseService : BaseCrudService<DML_BA_LOGRADOURO>, IBaseService
    {
        private IBaseRepository repository;

        public BaseService(IBaseRepository repository, IValidationService validationService) : base(repository, validationService)
        {
            this.repository = repository;
        }

        dynamic IBaseService.RecuperarDropDownUFLogradouro()
        {
            return repository.RecuperarDropDownUFLogradouro();
        }

        dynamic IBaseService.RecuperarDropDownOrgaoExpedidor()
        {
            return repository.RecuperarDropDownOrgaoExpedidor();
        }

        dynamic IBaseService.RecuperarDropDownTipoSexo()
        {
            return repository.RecuperarDropDownTipoSexo();
        }

        dynamic IBaseService.RecuperarDropDownTipoContato()
        {
            return repository.RecuperarDropDownTipoContato();
        }

        dynamic IBaseService.RecuperarDropDownTipoDocumento()
        {
            return repository.RecuperarDropDownTipoDocumento();
        }

        dynamic IBaseService.RecuperarDropDownFormaPgto()
        {
            return repository.RecuperarDropDownFormaPgto();
        }

        object IBaseService.GetByCep(string Termo)
        {
            return repository.GetByCep(Termo);
        }

        dynamic IBaseService.GetByEscolaLogradouro(string Termo)
        {
            return repository.GetByEscolaLogradouro(Termo);
        }

        dynamic IBaseService.GetByAlunoLogradouro(string Termo)
        {
            return repository.GetByAlunoLogradouro(Termo);
        }

        dynamic IBaseService.GetByClienteLograModal(int id_logradouro, int id_cliente)
        {
            return repository.GetByClienteLograModal(id_logradouro, id_cliente);
        }

        public void PreencherDados(DML_BA_LOGRADOURO data)
        {
            data.CEP = data.CEP;
            data.LOGRADOURO = data.LOGRADOURO;
            data.BAIRRO = data.BAIRRO;
            data.ID_CIDADE = data.ID_CIDADE;
        }
    }
}
