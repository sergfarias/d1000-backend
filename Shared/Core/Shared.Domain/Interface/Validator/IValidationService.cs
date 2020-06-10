using Shared.Domain.Impl.Validator;

namespace Shared.Domain.Interface.Validator
{
    public interface IValidationService
    {
        ResultadoValidacao Validate<TEntity>(TEntity entity) where TEntity : class;
    }
}
