using d1000.Common.Domain.Models.Data.Alunos.Entities;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Shared.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace d1000.Common.Infrastructure.Repositories.Alunos
{
    public class AlunosContatoRepository : BaseCacheRepository<DML_BA_ALUNO_CONTATO>, IAlunosContatoRepository
    {
        private readonly d1000DataContext _dbContext;

        public AlunosContatoRepository(
            IMemoryCache memoryCache,
            d1000DataContext context) : base(memoryCache, context)
        {
            _dbContext = context;
        }

        bool IAlunosContatoRepository.ExisteContatoCadastrado(int id_contato)
        {
            return _dbContext.DML_BA_ALUNO_CONTATO.Any(x => x.ID_CONTATO == id_contato);
        }

        protected override IList<dynamic> GenerateData()
        {
            throw new System.NotImplementedException();
        }
    }
}