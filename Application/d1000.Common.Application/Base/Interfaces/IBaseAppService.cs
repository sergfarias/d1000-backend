using d1000.Common.Application.Base.ViewModels;
using d1000.Common.Domain.Models.Data.Base;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Base.Interfaces
{
    public interface IBaseAppService : IBaseCrudAppService<LogradouroViewModel, DML_BA_LOGRADOURO>
    {
        IResultadoApplication<dynamic> RecuperarDropDownUFLogradouro();
        IResultadoApplication<dynamic> RecuperarDropdownOrgaoExpedidor();
        IResultadoApplication<dynamic> RecuperarDropdownTipoSexo();
        IResultadoApplication<dynamic> RecuperarDropdownTipoContato();
        IResultadoApplication<dynamic> RecuperarDropdownTipoDocumento();
        IResultadoApplication<dynamic> RecuperarDropdownFormaPgto();
        IResultadoApplication<object> GetByCep(string Termo);
        IResultadoApplication<dynamic> GetByEscolaLogradouro(string Termo);
        IResultadoApplication<dynamic> GetByAlunoLogradouro(string Termo);
        IResultadoApplication<dynamic> GetByClienteLograModal(int id_logradouro, int id_cliente);
    }
}
