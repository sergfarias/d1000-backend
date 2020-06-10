using Shared.Domain.Interface.Service;

namespace d1000.Common.Domain.Models.Data.Base.Interfaces.Services
{
    public interface IBaseService : IBaseCrudService<DML_BA_LOGRADOURO>
    {
        dynamic RecuperarDropDownUFLogradouro();
        dynamic RecuperarDropDownOrgaoExpedidor();
        dynamic RecuperarDropDownTipoSexo(); 
        dynamic RecuperarDropDownTipoContato();
        dynamic RecuperarDropDownTipoDocumento();
        dynamic RecuperarDropDownFormaPgto();
        object GetByCep(string Termo);
        dynamic GetByEscolaLogradouro(string Termo);
        dynamic GetByAlunoLogradouro(string Termo);
        dynamic GetByClienteLograModal(int id_logradouro, int id_cliente);
    }
}
