using d1000.Common.Application.FarmaciaPopular.ViewModels;
using Shared.Application.Interface;
using System.Collections.Generic;

namespace d1000.Common.Application.System.Interfaces
{
    public interface ISystemAppService 
    {
        string DnaSUS(SolicitacaoSUSViewModel farmaciapopular);
    }
}
