using d1000.Common.Application.Escolas.Interfaces;
using d1000.Common.Application.Escolas.ViewModels;
using d1000.Common.Domain.Models.Data.Escolas;
using d1000.Common.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace d1000.Services.Escolas.API.Controllers
{
    [Route("Escolas")]
    [ApiController]
    public class EscolasController : BaseController
    {
        public readonly IEscolasAppService appservice;
        public readonly IEscolasLogradouroAppService appserviceLogra;
        public readonly IEscolasContatoAppService appserviceContato;
        public readonly d1000DataContext _dbContext;

        public EscolasController(IEscolasAppService appservice, IEscolasLogradouroAppService appserviceLogra, IEscolasContatoAppService appserviceContato, d1000DataContext dbContext)
        {
            this.appservice = appservice;
            this.appserviceLogra = appserviceLogra;
            this.appserviceContato = appserviceContato;
            this._dbContext = dbContext;
        }

        // GET: api/Produtos
        [HttpGet]
        public IEnumerable<DML_BA_ESCOLA> GetAll()
        {
            // Retornar lista de produtos
            return _dbContext.DML_BA_ESCOLA.Take(5).ToList();
        }

        /// <summary>
        /// Pesquisa um cliente por Nome
        /// </summary>
        /// <param name="Termo">Nome do cliente a ser pesquisado.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/termo")]
        public IEnumerable<object> GetByTerm([FromQuery]string Termo, string Campo = null)
        {
            Termo = Termo.Trim().ToUpper();

           IQueryable<DML_BA_ESCOLA> clientes = null;

            if (Campo == "2")
            {
                    clientes = (from cliente in _dbContext.DML_BA_ESCOLA
                               where cliente.NM_ESCOLA.ToUpper().Trim().Contains(Termo) 
                               select cliente).Take(100);
            }
            if (Campo == "4")
            {
                    clientes = from cliente in _dbContext.DML_BA_ESCOLA
                               from clicontato in _dbContext.DML_BA_ESCOLA_CONTATO.Where(e => cliente.ID_ESCOLA == e.ID_ESCOLA)
                               where  clicontato.DS_CONTATO.Contains(Termo) //&&clicontato.ID_TIPO_CONTATO == 2
                               select cliente;
            }
            if (Campo == null)
            {
                clientes = from cliente in _dbContext.DML_BA_ESCOLA
                            where cliente.NM_ESCOLA.ToUpper().Trim().Contains(Termo)
                            //|| cliente.NM_FANTASIA.ToUpper().Trim().Contains(Termo) )
                            select cliente;
            }
            return clientes.ToList().Select(cli =>
            {
                var contatos = _dbContext.DML_BA_ESCOLA_CONTATO.Where(c => c.ID_ESCOLA == cli.ID_ESCOLA).ToList();
                return new
                {
                    cli.ID_ESCOLA,
                    cli.NM_ESCOLA,
                    cli.RG_MEC,
                    cli.OBS,
                    telefone = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 2),
                    celular = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 1),
                    email = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 3)
                };
            });
        }

        /// <summary>
        /// Pesquisa um cliente por Código ou CPF/CNPJ
        /// </summary>
        /// <param name="Codigo">Código interno ou CPF/CNPJ do cliente.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/codigo")]
        public IEnumerable<object> GetByCodigoEAN([FromQuery]string Codigo)
        {
            int.TryParse(Codigo, out int ID_CLIENTE);
            var clientes = from cliente in _dbContext.DML_BA_ESCOLA
                           where cliente.ID_ESCOLA == ID_CLIENTE || cliente.RG_MEC == Codigo
                           select cliente;
            return clientes.ToList().Select(cli =>
            {
                var contatos = _dbContext.DML_BA_ESCOLA_CONTATO.Where(c => c.ID_ESCOLA == cli.ID_ESCOLA).ToList();
                return new
                {
                    cli.ID_ESCOLA,
                    cli.NM_ESCOLA,
                    cli.RG_MEC,
                    cli.OBS,
                    telefone = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 2),
                    celular = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 1),
                    email = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 3)
                };
            });
        }


        /// <summary>
        /// Pesquisa um cliente por Código ou CPF/CNPJ
        /// </summary>
        /// <param name="Codigo">Código interno ou CPF/CNPJ do cliente.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/turma")]
        public IEnumerable<object> GetByTurma([FromQuery]string Codigo)
        {
            int.TryParse(Codigo, out int ID_ESCOLA);
            var clientes = from cliente in _dbContext.DML_BA_TURMA
                           where cliente.ID_ESCOLA == ID_ESCOLA 
                           select cliente;

            return clientes.ToList().Select(cli =>
            {
                return new
                {
                    cli.ID_TURMA,
                    cli.ID_ESCOLA,
                    cli.DESCRICAO,
                    cli.PERIODO  };
            });
        }

        /// <summary>
        /// Cadastro do Cliente - Cadastrar os dados do Cliente
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("cadastro/escola")]
        public ActionResult Post([FromBody]EscolaViewModel escola)
        {
            var inserirEscola = appservice.InserirRetornaModel(escola);
            int ID_ESCOLA = inserirEscola.ID;

            if (escola.enderecos != null)
            {
                /*Insere os dados do Logradouro do Cliente*/
                foreach (var e in escola.enderecos)
                {
                    EscolaLogradouroViewModel LograView = new EscolaLogradouroViewModel();
                    LograView.ID_ESCOLA = ID_ESCOLA;
                    LograView.ID_LOGRADOURO = e.ID_LOGRADOURO;
                    LograView.NR_LOGRADOURO = e.NR_LOGRADOURO;
                    LograView.CPL_LOGRADOURO = e.CPL_LOGRADOURO;
                    LograView.PONTO_REFERENCIA = e.PONTO_REFERENCIA;
                    LograView.ID_USU = escola.ID_USU;
                    LograView.DT_CAD = escola.DT_CAD;
                    appserviceLogra.Inserir(LograView);
                }
            }

            /*Insere os dados do Contato do Cliente*/
            foreach (var c in escola.contatos)
            {
                EscolaContatoViewModel ContatoView = new EscolaContatoViewModel();
                ContatoView.ID_ESCOLA = ID_ESCOLA;
                ContatoView.ID_TIPO_CONTATO = c.ID_TIPO_CONTATO;
                ContatoView.DS_CONTATO = c.DS_CONTATO;
                ContatoView.ID_USU = escola.ID_USU;
                ContatoView.DT_CAD = escola.DT_CAD;
                appserviceContato.Inserir(ContatoView);
            }

            return TratarRetorno(inserirEscola);
        }

        /// <summary>
        /// Cadastro do Cliente - Atualiza os dados do Cliente
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("atualiza/escola")]
        public ActionResult Put([FromBody]EscolaViewModel escola)
        {
            /*Atualiza os dados do Logradouro do Cliente*/
            if (escola.enderecos != null)
            {
                foreach (var e in escola.enderecos)
                {
                    EscolaLogradouroViewModel LograView = new EscolaLogradouroViewModel();
                    LograView.ID_ESCOLA_LOGRADOURO = e.ID_ESCOLA_LOGRADOURO;
                    LograView.ID_ESCOLA = escola.ID_ESCOLA;
                    LograView.ID_LOGRADOURO = e.ID_LOGRADOURO;
                    LograView.NR_LOGRADOURO = e.NR_LOGRADOURO;
                    LograView.CPL_LOGRADOURO = e.CPL_LOGRADOURO;
                    LograView.PONTO_REFERENCIA = e.PONTO_REFERENCIA;
                    LograView.ID_USU = escola.ID_USU;
                    LograView.DT_CAD = escola.DT_CAD;
                    LograView.DT_ULT_ALT = DateTime.Now;
                    var existelogradouro = appserviceLogra.ExisteLogradouroCadastrado(e.ID_ESCOLA_LOGRADOURO);
                    if (existelogradouro)
                    {
                        appserviceLogra.Atualizar(LograView);
                    }
                    else
                    {
                        appserviceLogra.Inserir(LograView);
                    }
                }
            }

            /*Atualiza os dados do Contato do Cliente*/
            foreach (var c in escola.contatos)
            {
                EscolaContatoViewModel ContatoView = new EscolaContatoViewModel();
                ContatoView.ID_CONTATO = c.ID_CONTATO;
                ContatoView.ID_ESCOLA = escola.ID_ESCOLA;
                ContatoView.ID_TIPO_CONTATO = c.ID_TIPO_CONTATO;
                ContatoView.DS_CONTATO = c.DS_CONTATO;
                ContatoView.ID_USU = escola.ID_USU;
                ContatoView.DT_CAD = escola.DT_CAD;
                ContatoView.DT_ULT_ALT = DateTime.Now;
                var existecontato = appserviceContato.ExisteContatoCadastrado(c.ID_CONTATO);
                if (existecontato)
                {
                    appserviceContato.Atualizar(ContatoView);
                }
                else
                {
                    appserviceContato.Inserir(ContatoView);
                }
            }

            return TratarRetorno(appservice.Atualizar(escola));
        }

        /// <summary>
        /// Pesquisa se um cliente é fidelidade
        /// </summary>
        /// <param name="Termo">CPF/CNPJ do cliente.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/clientefidelidade")]
        public ActionResult<dynamic> GetByClienteFidelidade(string Termo)
        {
            return TratarRetorno(appservice.GetByClienteFidelidade(Termo));
        }

        /// <summary>
        /// Pesquisa os contatos de um cliente
        /// </summary>
        /// <param name="Termo">CPF/CNPJ do cliente.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/clientecontato")]
        public ActionResult<dynamic> GetByClienteContato(string Termo)
        {
            return TratarRetorno(appservice.GetByClienteContato(Termo));
        }
    }
}
