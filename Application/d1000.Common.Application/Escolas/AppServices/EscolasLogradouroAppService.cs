using AutoMapper;
using d1000.Common.Application.Escolas.Interfaces;
using d1000.Common.Application.Escolas.ViewModels;
using d1000.Common.Domain.Models.Data.Escolas.Entities;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services;
using Shared.Application.Interface;

namespace d1000.Common.Application.Escolas.AppServices
{
    public class EscolasLogradouroAppService : BaseCrudAppService<EscolaLogradouroViewModel, DML_BA_ESCOLA_LOGRADOURO>, IEscolasLogradouroAppService
    {
        private readonly IEscolasLogradouroService service;
        private readonly IMapper mapper;

        public EscolasLogradouroAppService(IEscolasLogradouroService service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public bool ExisteLogradouroCadastrado(int id_cliente_logradouro)
        {
            var existelogradouro = service.ExisteLogradouroCadastrado(id_cliente_logradouro);

            return existelogradouro;
        }
    }
}