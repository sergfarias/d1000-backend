using Shared.Domain.Impl.Enum;
using System.Collections.Generic;
using FluentValidation.Results;

namespace Shared.Domain.Impl.Validator
{
    public class ResultadoValidacao : ValidationResult
    {
        public int ID { get; protected set; }
        public CodigoRetornoEnum CodigoRetorno { get; protected set; }

        public ResultadoValidacao(CodigoRetornoEnum codigoRetorno = CodigoRetornoEnum.Sucesso)
                 : base()
        {
            this.CodigoRetorno = codigoRetorno;
        }

        public ResultadoValidacao(string titulo, string mensagem,
            CodigoRetornoEnum codigoRetorno = CodigoRetornoEnum.Sucesso)
            : base(new List<ValidationFailure>() { new ValidationFailure(titulo, mensagem) })
        {
            this.CodigoRetorno = codigoRetorno;
        }

        public ResultadoValidacao(IEnumerable<ValidationFailure> erros,
            CodigoRetornoEnum codigoRetorno = CodigoRetornoEnum.Sucesso)
            : base(erros)
        {
            this.CodigoRetorno = codigoRetorno;
        }

        public override bool IsValid => CodigoRetorno == CodigoRetornoEnum.Sucesso && base.Errors.Count == 0;

        public ResultadoValidacao(int id, CodigoRetornoEnum codigoRetorno = CodigoRetornoEnum.Sucesso)
               : base()
        {
            this.ID = id;
            this.CodigoRetorno = codigoRetorno;
        }
     }
    
    public class ResultadoValidacao<TEntity> : ResultadoValidacao
    {
        public ResultadoValidacao() : base()
        {
        }

        public ResultadoValidacao(CodigoRetornoEnum codigoRetorno)
            : base(codigoRetorno)
        {
        }

        public ResultadoValidacao(string titulo, string mensagem,
            CodigoRetornoEnum codigoRetorno = CodigoRetornoEnum.Sucesso)
            : base(titulo, mensagem, codigoRetorno)
        {
        }

        public ResultadoValidacao(IEnumerable<ValidationFailure> erros,
            CodigoRetornoEnum codigoRetorno = CodigoRetornoEnum.Sucesso)
            : base(erros, codigoRetorno)
        {
        }

        public ResultadoValidacao(int id, CodigoRetornoEnum codigoRetorno)
           : base(id, codigoRetorno)
        {
        }

        public TEntity Data { get; private set; }

        public ResultadoValidacao<TEntity> DefinirData(TEntity data)
        {
            this.Data = data;

            return this;
        }
    }

    public static class ResultadoValidacaoExtensions
    {
        public static ResultadoValidacao<TEntity> ToResultadoValidacao<TEntity>(this ResultadoValidacao resultado, TEntity entity)
        {
            return new ResultadoValidacao<TEntity>(resultado.Errors, resultado.CodigoRetorno).DefinirData(entity);
        }
    }
}
