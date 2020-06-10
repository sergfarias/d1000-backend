using AutoMapper;
using d1000.Common.CrossCutting.Escolas;
using d1000.Common.Domain.Models.Data.Escolas;
using d1000.Common.Infrastructure;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace d1000.Services.Escolas.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public static readonly LoggerFactory _myLoggerFactory = new LoggerFactory(new[] {
            new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()
        });

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<d1000DataContext>(options =>
            {
                options.UseLoggerFactory(_myLoggerFactory)
                       .UseSqlServer(Configuration["ConnectionStrings:ConexaoPadrao"]);

            });

            // Adiciona todos os mapeamentos das viewmodels
            services.AddAutoMapper(
                //Shared
                typeof(Shared.Application.ConfigurationProfile).GetTypeInfo().Assembly,
                //Clientes
                typeof(Common.Application.ConfigurationProfile).GetTypeInfo().Assembly
            );

            #region Injeção de Dependência
            // Clientes
            Configuracao.InjecaoDependencia(services);
            #endregion

            services.AddMemoryCache();
            services.AddCors();

            services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddMvc()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.GetAssembly(typeof(EscolaValidator))))
                .AddMvcOptions(f => f.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
