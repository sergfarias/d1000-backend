using AutoMapper;
using d1000.Common.Application.Alunos.Interfaces;
using d1000.Common.Application.Alunos.ViewModels;
using d1000.Common.Domain.Models.Data.Alunos.Entities;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services;
using Shared.Application.Interface;

namespace d1000.Common.Application.Alunos.AppServices
{
    public class AlunosLogradouroAppService : BaseCrudAppService<AlunoLogradouroViewModel, DML_BA_ALUNO_LOGRADOURO>, IAlunosLogradouroAppService
    {
        private readonly IAlunosLogradouroService service;
        private readonly IMapper mapper;

        public AlunosLogradouroAppService(IAlunosLogradouroService service, IMapper mapper) : base(service, mapper)
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