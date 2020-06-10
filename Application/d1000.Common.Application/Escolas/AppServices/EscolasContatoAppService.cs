using AutoMapper;
using d1000.Common.Application.Escolas.Interfaces;
using d1000.Common.Application.Escolas.ViewModels;
using d1000.Common.Domain.Models.Data.Escolas.Entities;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Escolas.AppServices
{
    public class EscolasContatoAppService : BaseCrudAppService<EscolaContatoViewModel, DML_BA_ESCOLA_CONTATO>, IEscolasContatoAppService
    {
        private readonly IEscolasContatoService service;
        private readonly IMapper mapper;

        public EscolasContatoAppService(IEscolasContatoService service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public bool ExisteContatoCadastrado(int id_contato)
        {
            var existecontato = service.ExisteContatoCadastrado(id_contato);

            return existecontato;
        }
    }
}
