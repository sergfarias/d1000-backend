using AutoMapper;
using d1000.Common.Domain.Models.Data.Escolas.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Escolas.ViewModels
{
    public class EscolaLogradouroViewModel
    {
        public int ID_ESCOLA_LOGRADOURO { get; set; }
        public int ID_ESCOLA { get; set; }
        public int ID_LOGRADOURO { get; set; }
        public string NR_LOGRADOURO { get; set; }
        public string CPL_LOGRADOURO { get; set; }
        public string PONTO_REFERENCIA { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime DT_ULT_ALT { get; set; }

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<EscolaLogradouroViewModel, DML_BA_ESCOLA_LOGRADOURO>();

            mapper.CreateMap<DML_BA_ESCOLA_LOGRADOURO, EscolaLogradouroViewModel>();
        }
    }
}
