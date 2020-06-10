using FluentValidation;
using Shared.Domain.Impl.Enum;
using Shared.Domain.Interface.Validator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain.Impl.Validator
{
    public class FluentValidationService : IValidationService
    {
        private readonly IValidatorFactory validatorFactory;

        public FluentValidationService(IValidatorFactory validatorFactory)
        {
            this.validatorFactory = validatorFactory;
        }

        public ResultadoValidacao Validate<TEntity>(TEntity entity) where TEntity : class
        {
            var validator = this.validatorFactory.GetValidator<TEntity>();

            var result = validator.Validate(entity);

            CodigoRetornoEnum codigoRetorno = !result.IsValid && result.Errors.Count > 0 ? CodigoRetornoEnum.Erro : CodigoRetornoEnum.Sucesso;

            return new ResultadoValidacao(result.Errors, codigoRetorno);
        }
    }
}
