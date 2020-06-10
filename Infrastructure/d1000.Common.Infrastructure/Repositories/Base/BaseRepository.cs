using d1000.Common.Domain.Data.Models;
using d1000.Common.Domain.Models.Data.Base;
using d1000.Common.Domain.Models.Data.Base.Entities;
using d1000.Common.Domain.Models.Data.Base.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Escolas;
using d1000.Common.Domain.Models.Data.Alunos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Shared.Application.Impl;
using Shared.Application.Interface;
using Shared.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d1000.Common.Infrastructure.Repositories.Base
{
    public class BaseRepository : BaseCacheRepository<DML_BA_LOGRADOURO>, IBaseRepository
    {
        private readonly d1000DataContext _dbContext;

        public BaseRepository(
            IMemoryCache memoryCache,
            d1000DataContext context) : base(memoryCache, context)
        {
            _dbContext = context;
        }

        dynamic IBaseRepository.RecuperarDropDownUFLogradouro()
        {
            var condicao = context.Set<DML_BA_UF>().AsNoTracking();

            var query = from uf in condicao
                        orderby uf.ID_UF ascending
                        select new
                        {
                            uf.ID_UF,
                            uf.SIGLA_UF
                        };

            return query.ToList();
        }

        dynamic IBaseRepository.RecuperarDropDownOrgaoExpedidor()
        {
            var condicao = context.Set<DML_BA_SIGLA_ORG_EXP>().AsNoTracking();

            var query = from uf in condicao
                        orderby uf.ID_SIGLA_ORG_EXP ascending
                        select new
                        {
                            uf.ID_SIGLA_ORG_EXP,
                            uf.DS_SIGLA_ORG_EXP
                        };

            return query.ToList();
        }

        dynamic IBaseRepository.RecuperarDropDownTipoSexo()
        {
            var condicao = context.Set<DML_BA_TIPO_SEXO>().AsNoTracking();

            var query = from uf in condicao
                        orderby uf.ID_TIPO_SEXO ascending
                        select new
                        {
                            uf.ID_TIPO_SEXO,
                            uf.DS_TIPO_SEXO
                        };

            return query.ToList();
        }

        dynamic IBaseRepository.RecuperarDropDownTipoContato()
        {
            var condicao = context.Set<DML_BA_TIPO_CONTATO>().AsNoTracking();

            var query = from uf in condicao
                        orderby uf.ID_TIPO_CONTATO ascending
                        select new
                        {
                            uf.ID_TIPO_CONTATO,
                            uf.DS_TIPO_CONTATO
                        };

            return query.ToList();
        }

        dynamic IBaseRepository.RecuperarDropDownTipoDocumento()
        {
            var condicao = context.Set<DML_BA_TIPO_DOCUMENTO>().AsNoTracking();

            var query = from uf in condicao
                        orderby uf.ID_TIPO_DOCUMENTO ascending
                        select new
                        {
                            uf.ID_TIPO_DOCUMENTO,
                            uf.DS_TIPO_DOCUMENTO
                        };

            return query.ToList();
        }

        //dynamic IBaseRepository.RecuperarDropDownTipoReceita()
        //{
        //    var condicao = context.Set<DML_BA_TIPO_RECEITA>().AsNoTracking();

        //    var query = from uf in condicao
        //                orderby uf.ID_TIPO_RECEITA ascending
        //                select new
        //                {
        //                    uf.ID_TIPO_RECEITA,
        //                    uf.NOME_TIPO_RECEITA
        //                };

        //    return query.ToList();
        //}

        dynamic IBaseRepository.RecuperarDropDownFormaPgto()
        {
            var condicao = context.Set<DML_BA_FORMA_PAG>().AsNoTracking();

            var query = from uf in condicao
                        orderby uf.ID_FORMA_PAG ascending
                        select new
                        {
                            uf.ID_FORMA_PAG,
                            uf.DESCRICAO
                        };

            return query.ToList();
        }

        IResultadoApplication<object> IBaseRepository.GetByCep(string Termo)
        {
            var resultado = new ResultadoApplication<object>();

            var query = from logradouro in _dbContext.DML_BA_LOGRADOURO.Where(x => x.CEP == Termo)
                        from cidade in _dbContext.DML_BA_CIDADE.Where(x => logradouro.ID_CIDADE == x.ID_CIDADE )
                        from uf in _dbContext.DML_BA_UF.Where(x => cidade.ID_UF == x.ID_UF)
                        from pais in _dbContext.DML_BA_PAIS.Where(x => cidade.ID_PAIS == x.ID_PAIS)

                        select new
                        {
                            logradouro.ID_LOGRADOURO,
                            logradouro.CEP,
                            logradouro.LOGRADOURO,
                            logradouro.BAIRRO,
                            cidade.NOME_CIDADE,
                            cidade.ID_UF,
                            uf.SIGLA_UF
                        };

            foreach (var logradouro in query)
            {
                var ID_LOGRADOURO = logradouro.ID_LOGRADOURO != 0 ? logradouro.ID_LOGRADOURO : 0;
                var CEP = logradouro.CEP != null ? logradouro.CEP : string.Empty;
                var LOGRADOURO = logradouro.LOGRADOURO != null ? logradouro.LOGRADOURO : string.Empty;
                var BAIRRO = logradouro.BAIRRO != null ? logradouro.BAIRRO : string.Empty;
                var NOME_CIDADE = logradouro.NOME_CIDADE != null ? logradouro.NOME_CIDADE : string.Empty;
                var ID_UF = logradouro.ID_UF != 0 ? logradouro.ID_UF : 0;
                var SIGLA_UF = logradouro.SIGLA_UF != null ? logradouro.SIGLA_UF : string.Empty;


                resultado.DefinirData(new { ID_LOGRADOURO, CEP, LOGRADOURO, BAIRRO, NOME_CIDADE, ID_UF, SIGLA_UF });
                resultado.ExecutadoComSuccesso();

                break;

            }

            return resultado;
        }

        IResultadoApplication<dynamic> IBaseRepository.GetByEscolaLogradouro(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();

            var query = //from usuario in _dbContext.DML_BA_USU
                        from cliente in _dbContext.DML_BA_ESCOLA //.Where(x => x.ID_USU == usuario.ID_USU)
                        from clienteLogradouro in _dbContext.DML_BA_ESCOLA_LOGRADOURO.Where(x => cliente.ID_ESCOLA == x.ID_ESCOLA  )
                        from logradouro in _dbContext.DML_BA_LOGRADOURO.Where(x =>  clienteLogradouro.ID_LOGRADOURO == x.ID_LOGRADOURO )
                        from cidade in _dbContext.DML_BA_CIDADE.Where(x => logradouro.ID_CIDADE == x.ID_CIDADE  )
                        from uf in _dbContext.DML_BA_UF.Where(x => cidade.ID_UF == x.ID_UF)
                        from pais in _dbContext.DML_BA_PAIS.Where(x => cidade.ID_PAIS == x.ID_PAIS)
                        where cliente.RG_MEC == Termo

                        select new
                        {
                            cliente.ID_ESCOLA,
                            clienteLogradouro.ID_ESCOLA_LOGRADOURO,
                            clienteLogradouro.ID_LOGRADOURO,
                            clienteLogradouro.NR_LOGRADOURO,
                            clienteLogradouro.CPL_LOGRADOURO,
                            clienteLogradouro.PONTO_REFERENCIA,
                            logradouro.LOGRADOURO,
                            logradouro.BAIRRO,
                            logradouro.CEP,
                            logradouro.ID_CIDADE,
                            cidade.NOME_CIDADE,
                            cidade.ID_UF,
                            uf.SIGLA_UF

                        };
      
            resultado.DefinirData(new { query } );
            resultado.ExecutadoComSuccesso();

            return resultado;
        }

        IResultadoApplication<dynamic> IBaseRepository.GetByAlunoLogradouro(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();

            var query = //from usuario in _dbContext.DML_BA_USU
                        from aluno in _dbContext.DML_BA_ALUNO //.Where(x => x.ID_USU == usuario.ID_USU)
                        from alunoLogradouro in _dbContext.DML_BA_ALUNO_LOGRADOURO.Where(x => aluno.ID_ALUNO == x.ID_ALUNO)
                        from logradouro in _dbContext.DML_BA_LOGRADOURO.Where(x => alunoLogradouro.ID_LOGRADOURO == x.ID_LOGRADOURO)
                        from cidade in _dbContext.DML_BA_CIDADE.Where(x => logradouro.ID_CIDADE == x.ID_CIDADE)
                        from uf in _dbContext.DML_BA_UF.Where(x => cidade.ID_UF == x.ID_UF)
                        from pais in _dbContext.DML_BA_PAIS.Where(x => cidade.ID_PAIS == x.ID_PAIS)
                        where aluno.CNPJ_CPF == Termo

                        select new
                        {
                            aluno.ID_ALUNO,
                            alunoLogradouro.ID_ALUNO_LOGRADOURO,
                            alunoLogradouro.ID_LOGRADOURO,
                            alunoLogradouro.NR_LOGRADOURO,
                            alunoLogradouro.CPL_LOGRADOURO,
                            alunoLogradouro.PONTO_REFERENCIA,
                            logradouro.LOGRADOURO,
                            logradouro.BAIRRO,
                            logradouro.CEP,
                            logradouro.ID_CIDADE,
                            cidade.NOME_CIDADE,
                            cidade.ID_UF,
                            uf.SIGLA_UF

                        };

            resultado.DefinirData(new { query });
            resultado.ExecutadoComSuccesso();

            return resultado;
        }



        IResultadoApplication<object> IBaseRepository.GetByClienteLograModal(int id_logradouro, int id_cliente)
        {
            var resultado = new ResultadoApplication<object>();

            var query = from cliente in _dbContext.DML_BA_ESCOLA
                        from clienteLogradouro in _dbContext.DML_BA_ESCOLA_LOGRADOURO.Where(x => cliente.ID_ESCOLA == x.ID_ESCOLA)
                        from logradouro in _dbContext.DML_BA_LOGRADOURO.Where(x => clienteLogradouro.ID_LOGRADOURO == x.ID_LOGRADOURO)
                        from usuario in _dbContext.DML_BA_USU.Where(x => logradouro.ID_USU == x.ID_USU)
                        from uf in _dbContext.DML_BA_UF.Where(x => usuario.ID_USU == x.ID_USU)
                        from pais in _dbContext.DML_BA_PAIS.Where(x => usuario.ID_USU == x.ID_USU)
                        from cidade in _dbContext.DML_BA_CIDADE.Where(x => usuario.ID_USU == x.ID_USU &&
                                                                           logradouro.ID_CIDADE == x.ID_CIDADE &&
                                                                           uf.ID_UF == x.ID_UF &&
                                                                           pais.ID_PAIS == x.ID_PAIS)
                        where clienteLogradouro.ID_LOGRADOURO == id_logradouro &&
                              clienteLogradouro.ID_ESCOLA == id_cliente

                        select new
                        {
                            cliente.ID_ESCOLA,
                            clienteLogradouro.ID_LOGRADOURO,
                            clienteLogradouro.NR_LOGRADOURO,
                            clienteLogradouro.CPL_LOGRADOURO,
                            clienteLogradouro.PONTO_REFERENCIA,
                            logradouro.LOGRADOURO,
                            logradouro.BAIRRO,
                            logradouro.CEP,
                            logradouro.ID_CIDADE,
                            cidade.NOME_CIDADE,
                            cidade.ID_UF,
                            uf.SIGLA_UF
                        };

            foreach (var logradouro in query)
            {
                var ID_LOGRADOURO = logradouro.ID_LOGRADOURO != 0 ? logradouro.ID_LOGRADOURO : 0;
                var CEP = logradouro.CEP != null ? logradouro.CEP : string.Empty;
                var LOGRADOURO = logradouro.LOGRADOURO != null ? logradouro.LOGRADOURO : string.Empty;
                var BAIRRO = logradouro.BAIRRO != null ? logradouro.BAIRRO : string.Empty;
                var NOME_CIDADE = logradouro.NOME_CIDADE != null ? logradouro.NOME_CIDADE : string.Empty;
                var ID_UF = logradouro.ID_UF != 0 ? logradouro.ID_UF : 0;
                var SIGLA_UF = logradouro.SIGLA_UF != null ? logradouro.SIGLA_UF : string.Empty;
                var NR_LOGRADOURO = logradouro.NR_LOGRADOURO != null ? logradouro.NR_LOGRADOURO : string.Empty;
                var CPL_LOGRADOURO = logradouro.CPL_LOGRADOURO != null ? logradouro.CPL_LOGRADOURO : string.Empty;
                var PONTO_REFERENCIA = logradouro.PONTO_REFERENCIA != null ? logradouro.PONTO_REFERENCIA : string.Empty;


                resultado.DefinirData(new { ID_LOGRADOURO, CEP, LOGRADOURO, BAIRRO, NOME_CIDADE, ID_UF, SIGLA_UF, NR_LOGRADOURO, CPL_LOGRADOURO, PONTO_REFERENCIA });
                resultado.ExecutadoComSuccesso();

                break;

            }

            return resultado;
        }

        protected override IList<dynamic> GenerateData()
        {
            return (
               from logradouro in context.Set<DML_BA_LOGRADOURO>()
               select new
               {
                   logradouro.ID_LOGRADOURO
               }
           ).ToList<dynamic>();
        }
    }
}
