using AutoMapper;
using d1000.Common.Application.Escolas.Interfaces;
using d1000.Common.Application.Escolas.ViewModels;
using d1000.Common.Domain.Models.Data.Escolas;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services;
using Shared.Application.Impl;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Escolas.AppServices
{
    public class EscolasAppService : BaseCrudAppService<EscolaViewModel, DML_BA_ESCOLA>, IEscolasAppService
    {
        private readonly IEscolasService service;
        private readonly IMapper mapper;

        public EscolasAppService(IEscolasService service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

       
        IResultadoApplication<dynamic> IEscolasAppService.GetByClienteFidelidade(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();
            try
            {
                resultado.DefinirData(service.GetByClienteFidelidade(Termo))
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }
            return resultado;
        }

      
       
        IResultadoApplication<dynamic> IEscolasAppService.GetByClienteContato(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();
            try
            {
                resultado.DefinirData(service.GetByClienteContato(Termo))
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
