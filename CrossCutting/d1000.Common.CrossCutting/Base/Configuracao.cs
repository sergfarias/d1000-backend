using d1000.Common.Application.Base.AppServices;
using d1000.Common.Application.Base.Interfaces;
using d1000.Common.Domain.Models.Data.Base.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Base.Interfaces.Services;
using d1000.Common.Domain.Models.Data.Base.Services;
using d1000.Common.Infrastructure.Repositories.Base;
using Microsoft.Extensions.DependencyInjection;

namespace d1000.Common.CrossCutting.Base
{
    public class Configuracao
    {
        public static void InjecaoDependencia(IServiceCollection services)
        {
            // Deixar SEMPRE em ordem alfabetica de entidade para ficar mais facil de procurar

            services.AddScoped<Shared.Domain.Interface.Validator.IValidationService, Shared.Domain.Impl.Validator.FluentValidationService>();

            services.AddScoped<IBaseAppService, BaseAppService>();
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped<IBaseRepository, BaseRepository>();
        }
    }
}
