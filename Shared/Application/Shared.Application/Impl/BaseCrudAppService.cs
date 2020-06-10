using System.Linq;
using AutoMapper;
using Shared.Application.Impl;
using Shared.Domain.Impl.Enum;
using Shared.Domain.Interface.Entity;
using Shared.Domain.Interface.Service;

namespace Shared.Application.Interface
{
    public abstract class BaseCrudAppService<TViewModel, TEntity> : BaseAppService<TViewModel, TEntity, string>,
        IBaseCrudAppService<TViewModel, TEntity>
        where TEntity : class, IEntity<TEntity, string>
        where TViewModel : class
    {
        private readonly IBaseCrudService<TEntity> service;
        private readonly IMapper mapper;

        public BaseCrudAppService(
            IBaseCrudService<TEntity> service,
            IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public virtual IResultadoApplication Inserir(TViewModel viewModel)
        {
            var application = new ResultadoApplication();

            try
            {
                application.ResultadoValidacao(service.Inserir(mapper.Map<TEntity>(viewModel)));
                if (application.CodigoRetorno == CodigoRetornoEnum.Sucesso)
                {
                    service.Commit();
                }
            }
            catch (System.Exception ex)
            {
                application.ExecutadoComErro(ex);
            }

            return application;
        }


        public virtual IResultadoApplication InserirRetornaModel(TViewModel viewModel)
        {
            var application = new ResultadoApplication();

            try
            {
                var x = service.InserirRetornaModel(mapper.Map<TEntity>(viewModel));
                application.ResultadoValidacao(x, x.ID);

                if (application.CodigoRetorno != CodigoRetornoEnum.Sucesso)
                {
                    //service.Commit();
                    throw new System.Exception();
                }
            }
            catch (System.Exception ex)
            {
                application.ExecutadoComErro(ex);
            }

            return application;
        }

        public virtual IResultadoApplication Atualizar(TViewModel viewModel)
        {
            var application = new ResultadoApplication();

            try
            {
                application.ResultadoValidacao(service.Atualizar(mapper.Map<TEntity>(viewModel)));

                if (application.CodigoRetorno == CodigoRetornoEnum.Sucesso)
                {
                    service.Commit();
                }
            }
            catch (System.Exception ex)
            {
                application.ExecutadoComErro(ex);
            }

            return application;
        }

        public virtual IResultadoApplication RemoverPorId(string id)
        {
            var application = new ResultadoApplication();

            try
            {
                var resultado = service.RemoverPorId(id);

                if (resultado.CodigoRetorno == CodigoRetornoEnum.Sucesso)
                {
                    service.Commit();
                    application.ExecutadoComSuccesso();
                }
                else
                    application.ExecutadoComErro(resultado.CodigoRetorno, resultado.Errors.Select(x => x.ErrorMessage).FirstOrDefault());
            }
            catch (System.Exception ex)
            {
                application.ExecutadoComErro(ex);
            }

            return application;
        }
    }
}
