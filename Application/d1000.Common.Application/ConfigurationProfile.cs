using AutoMapper;
using d1000.Common.Application.Base.ViewModels;
using d1000.Common.Application.Escolas.ViewModels;
using d1000.Common.Application.Alunos.ViewModels;
//using d1000.Common.Application.FarmaciaPopular.ViewModels;
//using d1000.Common.Application.PedidosLoja.ViewModels;
//using d1000.Common.Application.SNGPC.ViewModels;

namespace d1000.Common.Application
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            this.AllowNullCollections = true;

            // PrescritorViewModel.Mapping(this);
            // PedidosLojaViewModel.Mapping(this);
            // PedidosLojaProdViewModel.Mapping(this);
            //	FarmaciaPopularViewModel.Mapping(this);

            AlunoViewModel.Mapping(this);
            AlunoLogradouroViewModel.Mapping(this);
            AlunoContatoViewModel.Mapping(this);

            LogradouroViewModel.Mapping(this);

            EscolaViewModel.Mapping(this);
            EscolaLogradouroViewModel.Mapping(this);
            EscolaContatoViewModel.Mapping(this);
        }
    }
}
