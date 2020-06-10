using Shared.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services
{
    public interface IEscolasService : IBaseCrudService<DML_BA_ESCOLA>
    {
       // object GetByConvenioCPF(string Codigo);
        dynamic GetByClienteFidelidade(string Termo);

        object GetByClienteConvenio(string Codigo);

        dynamic GetByClienteContato(string Termo);
    }
}
