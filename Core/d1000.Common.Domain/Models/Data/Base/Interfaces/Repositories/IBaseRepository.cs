using Shared.Application.Interface;
using Shared.Domain.Interface.Repository;
using System.Collections.Generic;

namespace d1000.Common.Domain.Models.Data.Base.Interfaces.Repositories
{
    public interface IBaseRepository : IBaseCrudRepository<DML_BA_LOGRADOURO>
    {
        dynamic RecuperarDropDownUFLogradouro();
        dynamic RecuperarDropDownOrgaoExpedidor();
        dynamic RecuperarDropDownTipoSexo(); 
        dynamic RecuperarDropDownTipoContato();
        dynamic RecuperarDropDownTipoDocumento();
        dynamic RecuperarDropDownFormaPgto();
        IResultadoApplication<object> GetByCep(string Termo);
        IResultadoApplication<dynamic> GetByEscolaLogradouro(string Termo);
        IResultadoApplication<dynamic> GetByAlunoLogradouro(string Termo);
        IResultadoApplication<dynamic> GetByClienteLograModal(int id_logradouro, int id_cliente);
    }
}
