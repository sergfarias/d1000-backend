using AutoMapper;
using d1000.Common.Domain.Models.Data.Escolas;
using d1000.Common.Domain.Models.Data.Escolas.Entities;
using System;
using System.Collections.Generic;

namespace d1000.Common.Application.Escolas.ViewModels
{
    public class EscolaViewModel
    {
        public int      ID_ESCOLA          { get; set; }
        public string   NM_ESCOLA         { get; set; }
        public DateTime? DT_NASC             { get; set; }
        public string   RG_MEC            { get; set; }
        public int      ID_TIPO_ESCOLA      { get; set; }
        public string   OBS                 { get; set; }
        public bool     STS_ESCOLA         { get; set; }
        public int      ID_USU              { get; set; }
        public DateTime DT_CAD              { get; set; }
        public List<EscolaContatoViewModel> contatos { get; set; }
        public List<EscolaLogradouroViewModel> enderecos { get; set; }

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<EscolaViewModel, DML_BA_ESCOLA>();

            mapper.CreateMap<DML_BA_ESCOLA, EscolaViewModel>();
        }
    }
}
