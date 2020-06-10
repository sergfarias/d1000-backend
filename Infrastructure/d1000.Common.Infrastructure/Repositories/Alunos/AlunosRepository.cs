using d1000.Common.Domain.Models.Data.Alunos;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Shared.Application.Impl;
using Shared.Application.Interface;
using Shared.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace d1000.Common.Infrastructure.Repositories.Alunos
{
    public class AlunosRepository : BaseCacheRepository<DML_BA_ALUNO>, IAlunosRepository
    {
        private readonly d1000DataContext _dbContext;

        public AlunosRepository(
            IMemoryCache memoryCache,
            d1000DataContext context) : base(memoryCache, context)
        {
            _dbContext = context;
        }

        protected override IList<dynamic> GenerateData()
        {
            throw new System.NotImplementedException();
        }


        IResultadoApplication<dynamic> IAlunosRepository.GetByAlunoFidelidade(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();

            var query = from cliente in _dbContext.DML_BA_ALUNO
                        where cliente.CNPJ_CPF == Termo
                        select new
                        {
                            cliente.ID_ALUNO,
                            cliente.NM_ALUNO,
                            cliente.RG,
                            cliente.ID_SIGLA_ORG_EXP,
                            cliente.ID_TIPO_SEXO,
                            cliente.DT_NASC,
                            cliente.DT_CAD,
                            cliente.OBS,
                            };

            foreach (var logradouro in query)
            {
                var ID_ALUNO = logradouro.ID_ALUNO != 0 ? logradouro.ID_ALUNO : 0;
                var NM_ALUNO = logradouro.NM_ALUNO != null ? logradouro.NM_ALUNO : string.Empty;
                var RG = logradouro.RG != null ? logradouro.RG : string.Empty;
                var ID_SIGLA_ORG_EXP = logradouro.ID_SIGLA_ORG_EXP != null ? logradouro.ID_SIGLA_ORG_EXP : null;
                var ID_TIPO_SEXO = logradouro.ID_TIPO_SEXO != 0 ? logradouro.ID_TIPO_SEXO : 0;
                var DT_NASC = logradouro.DT_NASC;
                var DT_CAD = logradouro.DT_CAD;
                var OBS = logradouro.OBS != null ? logradouro.OBS : string.Empty;
               
                resultado.DefinirData(new { ID_ALUNO, NM_ALUNO,  RG, ID_SIGLA_ORG_EXP, ID_TIPO_SEXO, DT_NASC, DT_CAD,  OBS  });
                resultado.ExecutadoComSuccesso();

                break;

            }
            return resultado;
        }

        IResultadoApplication<dynamic> IAlunosRepository.GetByAlunoContato(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();

            var query = from cliente in _dbContext.DML_BA_ALUNO
                        from clientecontato in _dbContext.DML_BA_ALUNO_CONTATO.Where(x => cliente.ID_ALUNO == x.ID_ALUNO)
                        where cliente.CNPJ_CPF == Termo
                        select new
                        {
                            clientecontato.ID_CONTATO,
                            clientecontato.ID_ALUNO,
                            clientecontato.ID_TIPO_CONTATO,
                            clientecontato.DS_CONTATO
                        };


            resultado.DefinirData(new { query });
            resultado.ExecutadoComSuccesso();

            return resultado;
        }
    }
}
