using d1000.Common.Application.Escolas.AppServices;
using d1000.Common.Application.Escolas.Interfaces;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Escolas.Interfaces.Services;
using d1000.Common.Domain.Models.Data.Escolas.Services;
using d1000.Common.Infrastructure.Repositories.Escolas;
using Microsoft.Extensions.DependencyInjection;

namespace d1000.Common.CrossCutting.Escolas
{
    public class Configuracao
    {
        public static void InjecaoDependencia(IServiceCollection services)
        {
            // Deixar SEMPRE em ordem alfabetica de entidade para ficar mais facil de procurar

            services.AddScoped<Shared.Domain.Interface.Validator.IValidationService, Shared.Domain.Impl.Validator.FluentValidationService>();

            services.AddScoped<IEscolasAppService, EscolasAppService>();
            services.AddScoped<IEscolasService, EscolasService>();
            services.AddScoped<IEscolasRepository, EscolasRepository>();

            services.AddScoped<IEscolasLogradouroAppService, EscolasLogradouroAppService>();
            services.AddScoped<IEscolasLogradouroService, EscolasLogradouroService>();
            services.AddScoped<IEscolasLogradouroRepository, EscolasLogradouroRepository>();

            services.AddScoped<IEscolasContatoAppService, EscolasContatoAppService>();
            services.AddScoped<IEscolasContatoService, EscolasContatoService>();
            services.AddScoped<IEscolasContatoRepository, EscolasContatoRepository>();
        }
    }
}
