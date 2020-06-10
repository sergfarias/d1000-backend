using FluentValidation.Results;
using Shared.Domain.Impl.Enum;

namespace Shared.Application.Interface
{
    public interface IResultadoApplication
    {
        CodigoRetornoEnum CodigoRetorno { get; }
        string[] Mensagem { get; }
        public int ID { get; }

        IResultadoApplication ExecutadoComSuccesso();
        IResultadoApplication ExecutadoComErro(string message = null);
        IResultadoApplication ExibirMensagem(string message);
        IResultadoApplication ResultadoValidacao(ValidationResult validate);
    }

    public interface IResultadoApplication<TData> : IResultadoApplication
    {
        TData Data { get; }

        IResultadoApplication<TData> DefinirData(TData data);
    }

    //public interface IResultadoPaginadoApplication<TData> : IResultadoApplication<TData>
    //{
    //    int Pagina { get; }
    //    int Total { get; }
    //    int TotalPorPagina { get; }

    //    IResultadoPaginadoApplication<TData> DefinirPagina(int pagina);
    //    IResultadoPaginadoApplication<TData> DefinirTotal(int total);
    //    IResultadoPaginadoApplication<TData> DefinirPaginacao<T>(IPaginacao<T> paginacao, Func<ICollection<T>, TData> mapper);
    //}
}
