using FluentValidation.Results;
using Shared.Application.Interface;
using Shared.CrossCutting.Tools;
using Shared.Domain.Impl.Enum;
using Shared.Domain.Impl.Validator;
using System;
using System.Linq;

namespace Shared.Application.Impl
{
    public class ResultadoApplication : IResultadoApplication
    {
        public CodigoRetornoEnum CodigoRetorno { get; private set; }
        public string[] Mensagem { get; private set; }

        public int ID { get; private set; }

        public IResultadoApplication ExecutadoComSuccesso()
        {
            CodigoRetorno = CodigoRetornoEnum.Sucesso;

            return this;
        }

        public IResultadoApplication ExecutadoComSuccesso(string message = null)
        {
            CodigoRetorno = CodigoRetornoEnum.Sucesso;

            if (!string.IsNullOrWhiteSpace(message))
                Mensagem = new[] { message };

            return this;
        }

        public IResultadoApplication ExecutadoComErro(Exception excecao)
        {
            CodigoRetorno = CodigoRetornoEnum.Erro;

            Mensagem = new[] { excecao.TratarExcecao() };

            return this;
        }

        public IResultadoApplication ExecutadoComErro(string message = null)
        {
            return this.ExecutadoComErro(CodigoRetornoEnum.Erro, message);
        }

        public IResultadoApplication ExecutadoComErro(CodigoRetornoEnum codigoRetorno, string message = null)
        {
            CodigoRetorno = codigoRetorno;

            if (!string.IsNullOrWhiteSpace(message))
                Mensagem = new[] { message };

            return this;
        }

        public IResultadoApplication ExecutadoComErro(string[] message)
        {
            CodigoRetorno = CodigoRetornoEnum.Erro;

            if (message != null)
                Mensagem = message;

            return this;
        }

        public IResultadoApplication ExibirMensagem(string message)
        {
            Mensagem = new[] { message };

            return this;
        }

        public IResultadoApplication ResultadoValidacao(ValidationResult validate)
        {
            CodigoRetorno = (validate.IsValid ? CodigoRetornoEnum.Sucesso : CodigoRetorno = CodigoRetornoEnum.Erro);
            Mensagem = validate.Errors.Select(x => x.ErrorMessage).ToArray();

            return this;
        }

        public IResultadoApplication ResultadoValidacao(ValidationResult validate, int id)
        {
            CodigoRetorno = (validate.IsValid ? CodigoRetornoEnum.Sucesso : CodigoRetorno = CodigoRetornoEnum.Erro);
            Mensagem = validate.Errors.Select(x => x.ErrorMessage).ToArray();
            ID = id;
            return this;
        }

        public IResultadoApplication AdicionarMensagem(ResultadoValidacao resultadoValidacao)
        {
            var erros = resultadoValidacao.Errors.Select(x => x.ErrorMessage).ToArray();

            return this.AdicionarMensagem(erros);
        }

        public IResultadoApplication AdicionarMensagem(string[] mensagens, bool? useOnlyTheseMessages = null)
        {
            if (Mensagem == null || Mensagem.Length == 0)
                Mensagem = mensagens;
            else
            {
                var mensagemExistente = Mensagem.ToList();
                mensagemExistente.AddRange(mensagens);
                Mensagem = mensagemExistente.ToArray();
            }

            if(useOnlyTheseMessages.HasValue && useOnlyTheseMessages.Value)
            {
                Mensagem = mensagens;
            }

            return this;
        }

        protected void SetCodigo(CodigoRetornoEnum codigoRetorno)
        {
            CodigoRetorno = codigoRetorno;
        }
    }

    public class ResultadoApplication<TData> : ResultadoApplication, IResultadoApplication<TData>
    {
        public TData Data { get; private set; }

        public IResultadoApplication<TData> DefinirData(TData data)
        {
            Data = data;

            return this;
        }

        public ResultadoApplication() { }

        public ResultadoApplication(IResultadoApplication resultadoApplication)
        {
            SetCodigo(resultadoApplication.CodigoRetorno);
            AdicionarMensagem(resultadoApplication.Mensagem);
        }
    }

    //public class ResultadoPaginadoApplication<TData> : ResultadoApplication<TData>, IResultadoPaginadoApplication<TData>
    //{
    //    public int Pagina { get; private set; }
    //    public int Total { get; private set; }
    //    public int TotalPorPagina { get; private set; }

    //    public IResultadoPaginadoApplication<TData> DefinirPagina(int pagina)
    //    {
    //        Pagina = pagina;

    //        return this;
    //    }

        //public IResultadoPaginadoApplication<XCData> DefinirTotal(int total)
        //{
        //    Total = total;

        //    return this;
        //}

        //public IResultadoPaginadoApplication<TData> DefinirPaginacao<T>(
        //    IPaginacao<T> paginacao, Func<ICollection<T>, TData> mapper)
        //{
        //    Pagina = paginacao.Pagina.GetValueOrDefault();
        //    Total = paginacao.Total.GetValueOrDefault();
        //    TotalPorPagina = paginacao.TotalPorPagina.GetValueOrDefault();

        //    DefinirData(mapper(paginacao.Data));

        //    return this;
        //}
}
