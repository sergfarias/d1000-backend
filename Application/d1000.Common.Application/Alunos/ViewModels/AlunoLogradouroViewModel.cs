using AutoMapper;
using d1000.Common.Domain.Models.Data.Alunos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Alunos.ViewModels
{
    public class AlunoLogradouroViewModel
    {
        public int ID_ALUNO_LOGRADOURO { get; set; }
        public int ID_ALUNO { get; set; }
        public int ID_LOGRADOURO { get; set; }
        public string NR_LOGRADOURO { get; set; }
        public string CPL_LOGRADOURO { get; set; }
        public string PONTO_REFERENCIA { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime DT_ULT_ALT { get; set; }

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<AlunoLogradouroViewModel, DML_BA_ALUNO_LOGRADOURO>();

            mapper.CreateMap<DML_BA_ALUNO_LOGRADOURO, AlunoLogradouroViewModel>();
        }
    }
}
