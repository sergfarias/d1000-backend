using d1000.Common.Domain.Models.Data.Escolas;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Shared.Application.Impl;
using Shared.Application.Interface;
using Shared.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace d1000.Common.Infrastructure.Repositories.Escolas
{
    public class EscolasRepository : BaseCacheRepository<DML_BA_ESCOLA>, IEscolasRepository
    {
        private readonly d1000DataContext _dbContext;

        public EscolasRepository(
            IMemoryCache memoryCache,
            d1000DataContext context) : base(memoryCache, context)
        {
            _dbContext = context;
        }

        protected override IList<dynamic> GenerateData()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<dynamic> GetByClienteConvenio(string Codigo)
        {
            int.TryParse(Codigo, out int ID_CLIENTE);
            var retorno = _dbContext.DML_BA_ESCOLA.Where(f => f.ID_ESCOLA == ID_CLIENTE || f.RG_MEC == Codigo).ToList(); 
            return retorno;
        }




        IResultadoApplication<dynamic> IEscolasRepository.GetByClienteFidelidade(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();

            var query = from cliente in _dbContext.DML_BA_ESCOLA
                        where cliente.RG_MEC == Termo
                        select new
                        {
                            cliente.ID_ESCOLA,
                            cliente.NM_ESCOLA,
                            //cliente.RZ_CLIENTE,
                            //cliente.RG,
                            cliente.ID_TIPO_ESCOLA,
                            //cliente.ID_SIGLA_ORG_EXP,
                            //cliente.ID_TIPO_SEXO,
                            //cliente.DT_NASC,
                            cliente.DT_CAD,
                            //cliente.INSC_EST,
                            //cliente.INSC_MUNI,
                            cliente.OBS
                            //cliente.ACEITA_MKT_ATIVO,
                            //cliente.FML_FID,
                            //cliente.DML_FID,
                            //cliente.TMO_FID,
                            //cliente.RSO_FID
                        };

            foreach (var logradouro in query)
            {
                var ID_ESCOLA = logradouro.ID_ESCOLA != 0 ? logradouro.ID_ESCOLA : 0;
                var NM_ESCOLA = logradouro.NM_ESCOLA != null ? logradouro.NM_ESCOLA : string.Empty;
                var ID_TIPO_ESCOLA = logradouro.ID_TIPO_ESCOLA != 0 ? logradouro.ID_TIPO_ESCOLA : 0;
                var DT_CAD = logradouro.DT_CAD;
                var OBS = logradouro.OBS != null ? logradouro.OBS : string.Empty;
                resultado.DefinirData(new { ID_ESCOLA, NM_ESCOLA,  ID_TIPO_ESCOLA,  DT_CAD,  OBS });

                resultado.ExecutadoComSuccesso();

                break;

            }
            return resultado;
        }

        IResultadoApplication<dynamic> IEscolasRepository.GetByClienteContato(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();

            var query = from cliente in _dbContext.DML_BA_ESCOLA
                        from clientecontato in _dbContext.DML_BA_ESCOLA_CONTATO.Where(x => cliente.ID_ESCOLA == x.ID_ESCOLA)
                        where cliente.RG_MEC == Termo
                        select new
                        {
                            clientecontato.ID_CONTATO,
                            clientecontato.ID_ESCOLA,
                            clientecontato.ID_TIPO_CONTATO,
                            clientecontato.DS_CONTATO
                        };


            resultado.DefinirData(new { query });
            resultado.ExecutadoComSuccesso();

            return resultado;
        }
    }
}
