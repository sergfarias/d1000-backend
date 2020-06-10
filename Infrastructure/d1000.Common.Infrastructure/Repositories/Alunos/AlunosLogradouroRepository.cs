using d1000.Common.Domain.Models.Data.Alunos.Entities;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Shared.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d1000.Common.Infrastructure.Repositories.Alunos
{
    public class AlunosLogradouroRepository : BaseCacheRepository<DML_BA_ALUNO_LOGRADOURO>, IAlunosLogradouroRepository
    {
        private readonly d1000DataContext _dbContext;

        public AlunosLogradouroRepository(
            IMemoryCache memoryCache,
            d1000DataContext context) : base(memoryCache, context)
        {
            _dbContext = context;
        }

        bool IAlunosLogradouroRepository.ExisteLogradouroCadastrado(int id_aluno_logradouro)
        {
            return _dbContext.DML_BA_ALUNO_LOGRADOURO.Any(x => x.ID_ALUNO_LOGRADOURO == id_aluno_logradouro);
        }

        protected override IList<dynamic> GenerateData()
        {
            throw new System.NotImplementedException();
        }
    }
}