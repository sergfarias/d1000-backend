using d1000.Common.Application.Escolas.ViewModels;
using d1000.Common.Domain.Models.Data.Escolas;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Escolas.Interfaces
{
    public interface IEscolasAppService : IBaseCrudAppService<EscolaViewModel, DML_BA_ESCOLA>
    {
       
        IResultadoApplication<dynamic> GetByClienteFidelidade(string Termo);
        IResultadoApplication<dynamic> GetByClienteContato(string Termo);

    }
}
