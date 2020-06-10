using AutoMapper;
using d1000.Common.Application.Alunos.Interfaces;
using d1000.Common.Application.Alunos.ViewModels;
using d1000.Common.Domain.Models.Data.Alunos;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services;
using Shared.Application.Impl;
using Shared.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Alunos.AppServices
{
    public class AlunosAppService : BaseCrudAppService<AlunoViewModel, DML_BA_ALUNO>, IAlunosAppService
    {
        private readonly IAlunosService service;
        private readonly IMapper mapper;

        public AlunosAppService(IAlunosService service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        IResultadoApplication<dynamic> IAlunosAppService.GetByAlunoFidelidade(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();
            try
            {
                resultado.DefinirData(service.GetByAlunoFidelidade(Termo))
                    .ExecutadoComSuccesso();
            }
            catch (Exception ex)
            {
                resultado.ExecutadoComErro(ex);
            }
            return resultado;
        }
      
        IResultadoApplication<dynamic> IAlunosAppService.GetByAlunoContato(string Termo)
        {
            var resultado = new ResultadoApplication<dynamic>();
            try
            {
                resultado.DefinirData(service.GetByAlunoContato(Termo))
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
