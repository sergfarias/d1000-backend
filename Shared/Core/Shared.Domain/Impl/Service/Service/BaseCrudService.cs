using Shared.Domain.Impl.Validator;
using Shared.Domain.Interface.Entity;
using Shared.Domain.Interface.Repository;
using Shared.Domain.Interface.Service;
using Shared.Domain.Interface.Validator;

namespace Shared.Domain.Service
{
    public abstract class BaseCrudService<TEntity> : BaseService<TEntity, string>, IBaseCrudService<TEntity>
        where TEntity : class, IEntityCrud<TEntity>
    {
        private readonly IBaseCrudRepository<TEntity> repository;
        protected readonly IValidationService validationService;

        public BaseCrudService(IBaseCrudRepository<TEntity> repository,
            IValidationService validationService) : base(repository)
        {
            this.repository = repository;
            this.validationService = validationService;
        }

        public virtual ResultadoValidacao Atualizar(TEntity model)
        {
            var validate = validationService.Validate(model);

            if (validate.IsValid)
                repository.Atualizar(model);

            return validate;
        }

        public virtual ResultadoValidacao<TEntity> AtualizarERetornar(TEntity model)
        {
            return this.Atualizar(model).ToResultadoValidacao(model);

        }

        public virtual ResultadoValidacao Inserir(TEntity model)
        {
            var validate = validationService.Validate(model);

            if (validate.IsValid)
                repository.Inserir(model);

            return validate;
        }

        public virtual ResultadoValidacao<TEntity> InserirERetornar(TEntity model)
        {
            return this.Inserir(model).ToResultadoValidacao(model);
        }

        public virtual ResultadoValidacao RemoverPorId(string id)
        {
            repository.RemoverPorId(id);

            return new ResultadoValidacao();
        }

        public virtual ResultadoValidacao Remover(TEntity model)
        {
            repository.Remover(model);

            return new ResultadoValidacao();
        }

        public virtual ResultadoValidacao InserirRetornaModel(TEntity model)
        {
            var validate = validationService.Validate(model);

            if (validate.IsValid)
                repository.InserirRetornaModel(model);

            return validate;
        }

    }
}
