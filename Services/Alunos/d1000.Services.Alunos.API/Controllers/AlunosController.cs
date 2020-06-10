using d1000.Common.Application.Alunos.Interfaces;
using d1000.Common.Application.Alunos.ViewModels;
using d1000.Common.Domain.Models.Data.Alunos;
using d1000.Common.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace d1000.Services.Alunos.API.Controllers
{
    [Route("Alunos")]
    [ApiController]
    public class AlunosController : BaseController
    {
        public readonly IAlunosAppService appservice;
        public readonly IAlunosLogradouroAppService appserviceLogra;
        public readonly IAlunosContatoAppService appserviceContato;
        public readonly d1000DataContext _dbContext;

        public AlunosController(IAlunosAppService appservice, IAlunosLogradouroAppService appserviceLogra, IAlunosContatoAppService appserviceContato, d1000DataContext dbContext)
        {
            this.appservice = appservice;
            this.appserviceLogra = appserviceLogra;
            this.appserviceContato = appserviceContato;
            this._dbContext = dbContext;
        }

        // GET: api/Produtos
        [HttpGet]
        public IEnumerable<DML_BA_ALUNO> GetAll()
        {
            // Retornar lista de produtos
            return _dbContext.DML_BA_ALUNO.Take(5).ToList();
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

           IQueryable<DML_BA_ALUNO> clientes = null;

            if (Campo == "2")
            {
                    clientes = (from cliente in _dbContext.DML_BA_ALUNO
                               where cliente.NM_ALUNO.ToUpper().Trim().Contains(Termo) 
                               select cliente).Take(100);
            }
            if (Campo == "4")
            {
                    clientes = from cliente in _dbContext.DML_BA_ALUNO
                               from clicontato in _dbContext.DML_BA_ALUNO_CONTATO.Where(e => cliente.ID_ALUNO == e.ID_ALUNO)
                               where  clicontato.DS_CONTATO.Contains(Termo) //&&clicontato.ID_TIPO_CONTATO == 2
                               select cliente;
            }
          
            return clientes.ToList().Select(cli =>
            {
                var contatos = _dbContext.DML_BA_ALUNO_CONTATO.Where(c => c.ID_ALUNO == cli.ID_ALUNO).ToList();
                return new
                {
                    cli.ID_ALUNO,
                   cli.NM_ALUNO,
                    cli.DT_NASC,
                    cli.CNPJ_CPF,
                    cli.OBS,
                    cli.ID_SIGLA_ORG_EXP,
                    cli.RG,
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

            var clientes = from cliente in _dbContext.DML_BA_ALUNO
                           where cliente.ID_ALUNO == ID_CLIENTE || cliente.CNPJ_CPF == Codigo
                           select cliente;

            return clientes.ToList().Select(cli =>
            {
                var contatos = _dbContext.DML_BA_ALUNO_CONTATO.Where(c => c.ID_ALUNO == cli.ID_ALUNO).ToList();

                return new
                {
                    cli.ID_ALUNO,
                    cli.NM_ALUNO,
                    cli.DT_NASC,
                    cli.CNPJ_CPF,
                    cli.OBS,
                    cli.ID_SIGLA_ORG_EXP,
                    cli.RG,
                    telefone = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 2),
                    celular = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 1),
                    email = contatos.FirstOrDefault(c => c.ID_TIPO_CONTATO == 3)
                };
            });
        }

        /// <summary>
        /// Cadastro do Cliente - Cadastrar os dados do Cliente
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("cadastro/cliente")]
        public ActionResult Post([FromBody]AlunoViewModel aluno)
        {
            var inserirAluno = appservice.InserirRetornaModel(aluno);
            int ID_ALUNO = inserirAluno.ID;

            if (aluno.enderecos != null)
            {
                /*Insere os dados do Logradouro do Cliente*/
                foreach (var e in aluno.enderecos)
                {
                    AlunoLogradouroViewModel LograView = new AlunoLogradouroViewModel();
                    LograView.ID_ALUNO = ID_ALUNO;
                    LograView.ID_LOGRADOURO = e.ID_LOGRADOURO;
                    LograView.NR_LOGRADOURO = e.NR_LOGRADOURO;
                    LograView.CPL_LOGRADOURO = e.CPL_LOGRADOURO;
                    LograView.PONTO_REFERENCIA = e.PONTO_REFERENCIA;
                    LograView.ID_USU = aluno.ID_USU;
                    LograView.DT_CAD = aluno.DT_CAD;
                    appserviceLogra.Inserir(LograView);
                }
            }

            /*Insere os dados do Contato do Cliente*/
            foreach (var c in aluno.contatos)
            {
                AlunoContatoViewModel ContatoView = new AlunoContatoViewModel();
                ContatoView.ID_ALUNO = ID_ALUNO;
                ContatoView.ID_TIPO_CONTATO = c.ID_TIPO_CONTATO;
                ContatoView.DS_CONTATO = c.DS_CONTATO;
                ContatoView.ID_USU = aluno.ID_USU;
                ContatoView.DT_CAD = aluno.DT_CAD;
                appserviceContato.Inserir(ContatoView);
            }


            return TratarRetorno(inserirAluno);
        }

        /// <summary>
        /// Cadastro do Cliente - Atualiza os dados do Cliente
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("atualiza/cliente")]
        public ActionResult Put([FromBody]AlunoViewModel aluno)
        {
            /*Atualiza os dados do Logradouro do Cliente*/
            if (aluno.enderecos != null)
            {
                foreach (var e in aluno.enderecos)
                {
                    AlunoLogradouroViewModel LograView = new AlunoLogradouroViewModel();
                    LograView.ID_ALUNO_LOGRADOURO = e.ID_ALUNO_LOGRADOURO;
                    LograView.ID_ALUNO = aluno.ID_ALUNO ;
                    LograView.ID_LOGRADOURO = e.ID_LOGRADOURO;
                    LograView.NR_LOGRADOURO = e.NR_LOGRADOURO;
                    LograView.CPL_LOGRADOURO = e.CPL_LOGRADOURO;
                    LograView.PONTO_REFERENCIA = e.PONTO_REFERENCIA;
                    LograView.ID_USU = aluno.ID_USU;
                    LograView.DT_CAD = aluno.DT_CAD;
                    LograView.DT_ULT_ALT = DateTime.Now;
                    var existelogradouro = appserviceLogra.ExisteLogradouroCadastrado(e.ID_ALUNO_LOGRADOURO);
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
            foreach (var c in aluno.contatos)
            {
                AlunoContatoViewModel ContatoView = new AlunoContatoViewModel();
                ContatoView.ID_CONTATO = c.ID_CONTATO;
                ContatoView.ID_ALUNO = aluno.ID_ALUNO;
                ContatoView.ID_TIPO_CONTATO = c.ID_TIPO_CONTATO;
                ContatoView.DS_CONTATO = c.DS_CONTATO;
                ContatoView.ID_USU = aluno.ID_USU;
                ContatoView.DT_CAD = aluno.DT_CAD;
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

            return TratarRetorno(appservice.Atualizar(aluno));
        }

        /// <summary>
        /// Pesquisa se um cliente é fidelidade
        /// </summary>
        /// <param name="Termo">CPF/CNPJ do cliente.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/clientefidelidade")]
        public ActionResult<dynamic> GetByAlunoFidelidade(string Termo)
        {
            return TratarRetorno(appservice.GetByAlunoFidelidade(Termo));
        }

        /// <summary>
        /// Pesquisa os contatos de um cliente
        /// </summary>
        /// <param name="Termo">CPF/CNPJ do cliente.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/clientecontato")]
        public ActionResult<dynamic> GetByAlunoContato(string Termo)
        {
            return TratarRetorno(appservice.GetByAlunoContato(Termo));
        }
    }
}
