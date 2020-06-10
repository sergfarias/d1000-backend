using AutoMapper;
using Shared.Application.Impl;
using Shared.Domain.Interface.Entity;
using Shared.Domain.Interface.Service;
using System.Collections.Generic;

namespace Shared.Application.Interface
{
    public class BaseAppService<TViewModel, TEntity, TType> : IBaseAppService<TViewModel, TEntity, TType> 
        where TEntity : class, IEntity<TEntity, TType>
        where TViewModel : class
    {
        private readonly IBaseService<TEntity, TType> service;
        private readonly IMapper mapper;

        public BaseAppService(
            IBaseService<TEntity, TType> service,
            IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public virtual IResultadoApplication<ICollection<TViewModel>> RecuperarTodos(int? numeroPagina, int? registrosPorPagina)
        {
            var resultado = new ResultadoApplication<ICollection<TViewModel>>();

            try
            {
                resultado.DefinirData(mapper.Map<ICollection<TViewModel>>(
                    service.RecuperarTodos(numeroPagina, registrosPorPagina)));
                resultado.ExecutadoComSuccesso();
            }
            catch (System.Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }

        public IResultadoApplication<TViewModel> RecuperarPorId(TType id)
        {
            var resultado = new ResultadoApplication<TViewModel>();

            try
            {
                var data = service.RecuperarPorId(id);
                if(data != null){
                    resultado
                        .DefinirData(mapper.Map<TViewModel>(data))
                        .ExecutadoComSuccesso();
                }
                else
                    resultado.ExecutadoComErro();
            }
            catch (System.Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }
    }
}
