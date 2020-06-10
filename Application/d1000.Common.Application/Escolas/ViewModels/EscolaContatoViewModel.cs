using AutoMapper;
using d1000.Common.Domain.Models.Data.Escolas.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Escolas.ViewModels
{
    public class EscolaContatoViewModel
    {
        public int ID_CONTATO { get; set; }
        public int ID_ESCOLA { get; set; }
        public int ID_TIPO_CONTATO { get; set; }
        public string DS_CONTATO { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<EscolaContatoViewModel, DML_BA_ESCOLA_CONTATO>();

            mapper.CreateMap<DML_BA_ESCOLA_CONTATO, EscolaContatoViewModel>();
        }
    }
}
