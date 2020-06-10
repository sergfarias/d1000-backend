using AutoMapper;
using d1000.Common.Application.Alunos.Interfaces;
using d1000.Common.Application.Alunos.ViewModels;
using d1000.Common.Domain.Models.Data.Alunos.Entities;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Alunos.AppServices
{
    public class AlunosContatoAppService : BaseCrudAppService<AlunoContatoViewModel, DML_BA_ALUNO_CONTATO>, IAlunosContatoAppService
    {
        private readonly IAlunosContatoService service;
        private readonly IMapper mapper;

        public AlunosContatoAppService(IAlunosContatoService service, IMapper mapper) : base(service, mapper)
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
