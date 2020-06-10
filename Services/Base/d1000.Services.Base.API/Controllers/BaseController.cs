using d1000.Common.Application.Base.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace d1000.Services.Base.API.Controllers
{
    [Route("Base")]
    [ApiController]
    public class BaseController : d1000BaseController
    {

        public readonly IBaseAppService appservice;

        public BaseController(IBaseAppService appservice)
        {
            this.appservice = appservice;
        }

        /// <summary>
        /// Consulta de Logradouro - Popula a combo de UF Logradouro
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("dropdown/uflogradouro")]
        public ActionResult<dynamic> RecuperarDropdownUFLogradouro()
        {
            return TratarRetorno(appservice.RecuperarDropDownUFLogradouro());
        }

        /// <summary>
        /// Consulta de Logradouro - Popula a combo de UF Logradouro
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("dropdown/orgaoexpedidor")]
        public ActionResult<dynamic> RecuperarDropdownOrgaoExpedidor()
        {
            return TratarRetorno(appservice.RecuperarDropdownOrgaoExpedidor());
        }

        /// <summary>
        /// Consulta de Logradouro - Popula a combo de UF Logradouro
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("dropdown/tiposexo")]
        public ActionResult<dynamic> RecuperarDropdownTipoSexo()
        {
            return TratarRetorno(appservice.RecuperarDropdownTipoSexo());
        }

        /// <summary>
        /// Consulta de Logradouro - Pesquisa do logradouro pelo cep
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/logradouro")]
        public ActionResult<dynamic> GetByCep(string Termo)
        {
            return TratarRetorno(appservice.GetByCep(Termo));
        }

        /// <summary>
        /// Consulta de Cliente - Popula a combo de tipo de contato
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("dropdown/tipocontato")]
        public ActionResult<dynamic> RecuperarDropdownTipoContato()
        {
            return TratarRetorno(appservice.RecuperarDropdownTipoContato());
        }

        /// <summary>
        /// Receituario - Popula a combo de tipo de documento
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("dropdown/tipodocumento")]
        public ActionResult<dynamic> RecuperarDropdownTipoDocumento()
        {
            return TratarRetorno(appservice.RecuperarDropdownTipoDocumento());
        }

        /// <summary>
        /// Entrega domicilio - Popula a combo forma de pagamento
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("dropdown/formapgto")]
        public ActionResult<dynamic> RecuperarDropdownFormaPgto()
        {
            return TratarRetorno(appservice.RecuperarDropdownFormaPgto());
        }

        /// <summary>
        /// Pesquisa um cliente e seus Logradouro por CPF/CNPJ
        /// </summary>
        /// <param name="Termo">CPF/CNPJ do cliente.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/escolalogradourogrid")]
        public ActionResult<dynamic> GetByEscolaLogradouro(string Termo)
        {
            return TratarRetorno(appservice.GetByEscolaLogradouro(Termo));
        }

        /// <summary>
        /// Pesquisa um cliente e seus Logradouro por CPF/CNPJ
        /// </summary>
        /// <param name="Termo">CPF/CNPJ do cliente.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/alunologradourogrid")]
        public ActionResult<dynamic> GetByAlunoLogradouro(string Termo)
        {
            return TratarRetorno(appservice.GetByAlunoLogradouro(Termo));
        }

        /// <summary>
        /// Pesquisa um cliente e seus Logradouro por ID_LOGRADOURO e ID_CLIENTE
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisa/logradouroclientegrid")]
        public ActionResult<dynamic> GetByClienteLograModal(int id_logradouro, int id_cliente)
        {
            return TratarRetorno(appservice.GetByClienteLograModal(id_logradouro, id_cliente));
        }

    }
}
