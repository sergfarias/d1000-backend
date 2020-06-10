using d1000.Common.Domain.Models.Data.Escolas.Entities;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Shared.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace d1000.Common.Infrastructure.Repositories.Escolas
{
    public class EscolasContatoRepository : BaseCacheRepository<DML_BA_ESCOLA_CONTATO>, IEscolasContatoRepository
    {
        private readonly d1000DataContext _dbContext;

        public EscolasContatoRepository(
            IMemoryCache memoryCache,
            d1000DataContext context) : base(memoryCache, context)
        {
            _dbContext = context;
        }

        bool IEscolasContatoRepository.ExisteContatoCadastrado(int id_contato)
        {
            return _dbContext.DML_BA_ESCOLA_CONTATO.Any(x => x.ID_CONTATO == id_contato);
        }

        protected override IList<dynamic> GenerateData()
        {
            throw new System.NotImplementedException();
        }
    }
}