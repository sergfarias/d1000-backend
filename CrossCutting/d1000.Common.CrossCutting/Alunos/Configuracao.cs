using d1000.Common.Application.Alunos.AppServices;
using d1000.Common.Application.Alunos.Interfaces;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services;
using d1000.Common.Domain.Models.Data.Alunos.Services;
using d1000.Common.Infrastructure.Repositories.Alunos;
using Microsoft.Extensions.DependencyInjection;

namespace d1000.Common.CrossCutting.Alunos
{
    public class Configuracao
    {
        public static void InjecaoDependencia(IServiceCollection services)
        {
            // Deixar SEMPRE em ordem alfabetica de entidade para ficar mais facil de procurar

            services.AddScoped<Shared.Domain.Interface.Validator.IValidationService, Shared.Domain.Impl.Validator.FluentValidationService>();

            services.AddScoped<IAlunosAppService, AlunosAppService>();
            services.AddScoped<IAlunosService, AlunosService>();
            services.AddScoped<IAlunosRepository, AlunosRepository>();

            services.AddScoped<IAlunosLogradouroAppService, AlunosLogradouroAppService>();
            services.AddScoped<IAlunosLogradouroService, AlunosLogradouroService>();
            services.AddScoped<IAlunosLogradouroRepository, AlunosLogradouroRepository>();

            services.AddScoped<IAlunosContatoAppService, AlunosContatoAppService>();
            services.AddScoped<IAlunosContatoService, AlunosContatoService>();
            services.AddScoped<IAlunosContatoRepository, AlunosContatoRepository>();
        }
    }
}
