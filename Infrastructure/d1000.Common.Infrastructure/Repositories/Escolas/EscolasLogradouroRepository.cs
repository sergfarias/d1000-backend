using d1000.Common.Domain.Models.Data.Escolas.Entities;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Shared.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d1000.Common.Infrastructure.Repositories.Escolas
{
    public class EscolasLogradouroRepository : BaseCacheRepository<DML_BA_ESCOLA_LOGRADOURO>, IEscolasLogradouroRepository
    {
        private readonly d1000DataContext _dbContext;

        public EscolasLogradouroRepository(
            IMemoryCache memoryCache,
            d1000DataContext context) : base(memoryCache, context)
        {
            _dbContext = context;
        }

        bool IEscolasLogradouroRepository.ExisteLogradouroCadastrado(int id_cliente_logradouro)
        {
            return _dbContext.DML_BA_ESCOLA_LOGRADOURO.Any(x => x.ID_ESCOLA_LOGRADOURO == id_cliente_logradouro);
        }

        protected override IList<dynamic> GenerateData()
        {
            throw new System.NotImplementedException();
        }
    }
}