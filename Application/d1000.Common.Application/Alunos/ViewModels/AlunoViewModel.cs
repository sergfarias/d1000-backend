using AutoMapper;
using d1000.Common.Domain.Models.Data.Alunos;
using d1000.Common.Domain.Models.Data.Alunos.Entities;
using System;
using System.Collections.Generic;

namespace d1000.Common.Application.Alunos.ViewModels
{
    public class AlunoViewModel
    {
        public int      ID_ALUNO          { get; set; }
        public string   NM_ALUNO         { get; set; }
        public DateTime? DT_NASC             { get; set; }
        public string   CNPJ_CPF            { get; set; }
        public string   RG                  { get; set; }
        public int?      ID_SIGLA_ORG_EXP    { get; set; }
        public string   OBS                 { get; set; }
        public bool     STS_CLIENTE         { get; set; }
        public int      ID_TIPO_SEXO        { get; set; }
        public int      ID_USU              { get; set; }
        public DateTime DT_CAD              { get; set; }
        public List<AlunoContatoViewModel> contatos { get; set; }
        public List<AlunoLogradouroViewModel> enderecos { get; set; }

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<AlunoViewModel, DML_BA_ALUNO>();

            mapper.CreateMap<DML_BA_ALUNO, AlunoViewModel>();
        }
    }
}
