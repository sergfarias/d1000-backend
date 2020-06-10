using AutoMapper;
using d1000.Common.Domain.Models.Data.Alunos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Alunos.ViewModels
{
    public class AlunoContatoViewModel
    {
        public int ID_CONTATO { get; set; }
        public int ID_ALUNO { get; set; }
        public int ID_TIPO_CONTATO { get; set; }
        public string DS_CONTATO { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<AlunoContatoViewModel, DML_BA_ALUNO_CONTATO>();

            mapper.CreateMap<DML_BA_ALUNO_CONTATO, AlunoContatoViewModel>();
        }
    }
}
