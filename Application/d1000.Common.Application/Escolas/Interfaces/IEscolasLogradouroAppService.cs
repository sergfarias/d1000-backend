using d1000.Common.Application.Escolas.ViewModels;
using d1000.Common.Domain.Models.Data.Escolas.Entities;
using Shared.Application.Interface;

namespace d1000.Common.Application.Escolas.Interfaces
{
    public interface IEscolasLogradouroAppService : IBaseCrudAppService<EscolaLogradouroViewModel, DML_BA_ESCOLA_LOGRADOURO>
    {
        bool ExisteLogradouroCadastrado(int id_escola_logradouro);
    }
}