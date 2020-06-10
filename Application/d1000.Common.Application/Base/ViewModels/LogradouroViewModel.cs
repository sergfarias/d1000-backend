using AutoMapper;
using d1000.Common.Domain.Models.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Application.Base.ViewModels
{
    public class LogradouroViewModel
    {
        public int CEP { get; set; }
        public string LOGRADOURO { get; set; }
        public string BAIRRO { get; set; }
        public string ID_CIDADE { get; set; }
       

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<LogradouroViewModel, DML_BA_LOGRADOURO>()
                     .ForPath(x => x.CEP, src => src.MapFrom(x => x.CEP))
                     .ForPath(x => x.LOGRADOURO, src => src.MapFrom(x => x.LOGRADOURO))
                     .ForPath(x => x.BAIRRO, src => src.MapFrom(x => x.BAIRRO))
                     .ForPath(x => x.ID_CIDADE, src => src.MapFrom(x => x.ID_CIDADE))
                    ;

            mapper.CreateMap<DML_BA_LOGRADOURO, LogradouroViewModel>()
                 .ForPath(x => x.CEP, src => src.MapFrom(x => x.CEP))
                 .ForPath(x => x.LOGRADOURO, src => src.MapFrom(x => x.LOGRADOURO))
                 .ForPath(x => x.BAIRRO, src => src.MapFrom(x => x.BAIRRO))
                 .ForPath(x => x.ID_CIDADE, src => src.MapFrom(x => x.ID_CIDADE))
                ;
        }
    }
}
