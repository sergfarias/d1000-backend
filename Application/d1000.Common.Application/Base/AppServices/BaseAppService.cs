using AutoMapper;
using d1000.Common.Application.Base.Interfaces;
using d1000.Common.Application.Base.ViewModels;
using d1000.Common.Domain.Models.Data.Base;
using d1000.Common.Domain.Models.Data.Base.Interfaces.Services;
using Shared.Application.Impl;
using Shared.Application.Interface;
using System;

namespace d1000.Common.Application.Base.AppServices
{
    public class BaseAppService : BaseCrudAppService<LogradouroViewModel, DML_BA_LOGRADOURO>, IBaseAppService
    {
        private readonly IBaseService service;
        private readonly IMapper mapper;

        public BaseAppService(IBaseService service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        IResultadoApplication<dynamic> IBaseAppService.RecuperarDropDownUFLogradouro()
        {
            var resultado = new ResultadoApplication<dynamic>();

            try
            {
                resultado.DefinirData(service.RecuperarDropDownUFLogradouro())
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }

        IResultadoApplication<dynamic> IBaseAppService.RecuperarDropdownOrgaoExpedidor()
        {
            var resultado = new ResultadoApplication<dynamic>();

            try
            {
                resultado.DefinirData(service.RecuperarDropDownOrgaoExpedidor())
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }

        IResultadoApplication<dynamic> IBaseAppService.RecuperarDropdownTipoSexo()
        {
            var resultado = new ResultadoApplication<dynamic>();

            try
            {
                resultado.DefinirData(service.RecuperarDropDownTipoSexo())
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }

        IResultadoApplication<dynamic> IBaseAppService.RecuperarDropdownTipoContato()
        {
            var resultado = new ResultadoApplication<dynamic>();

            try
            {
                resultado.DefinirData(service.RecuperarDropDownTipoContato())
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }

        IResultadoApplication<dynamic> IBaseAppService.RecuperarDropdownTipoDocumento()
        {
            var resultado = new ResultadoApplication<dynamic>();

            try
            {
                resultado.DefinirData(service.RecuperarDropDownTipoDocumento())
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }

        IResultadoApplication<dynamic> IBaseAppService.RecuperarDropdownFormaPgto()
        {
            var resultado = new ResultadoApplication<dynamic>();

            try
            {
                resultado.DefinirData(service.RecuperarDropDownFormaPgto())
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }

        IResultadoApplication<object> IBaseAppService.GetByCep(string Termo)
        {
            var resultado = new ResultadoApplication<object>();

            try
            {
                resultado.DefinirData(service.GetByCep(Termo))
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }

            return resultado;
        }

        IResultadoApplication<dynamic> IBaseAppService.GetByEscolaLogradouro(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();
            try
            {
                resultado.DefinirData(service.GetByEscolaLogradouro(Termo))
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }
            return resultado;
        }

        IResultadoApplication<dynamic> IBaseAppService.GetByAlunoLogradouro(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();
            try
            {
                resultado.DefinirData(service.GetByAlunoLogradouro(Termo))
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }
            return resultado;
        }

        IResultadoApplication<dynamic> IBaseAppService.GetByClienteLograModal(int id_logradouro, int id_cliente)
        {
            var resultado = new ResultadoApplication<dynamic>();
            try
            {
                resultado.DefinirData(service.GetByClienteLograModal(id_logradouro, id_cliente))
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }
            return resultado;
        }
    }
}
