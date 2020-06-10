using d1000.Common.Application.Escolas.ViewModels;
using d1000.Common.Domain.Models.Data.Escolas.Entities;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Escolas.Interfaces
{
    public interface IEscolasContatoAppService : IBaseCrudAppService<EscolaContatoViewModel, DML_BA_ESCOLA_CONTATO>
    {
        bool ExisteContatoCadastrado(int id_contato);
    }
}
