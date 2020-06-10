using Microsoft.AspNetCore.Mvc;
using Shared.Application.Interface;
using Shared.Domain.Impl.Enum;
using System.IO;
using System.Net.Http.Headers;

namespace d1000.Services.Base.API
{
    public class d1000BaseController : ControllerBase
    {
        protected ActionResult TratarRetorno(IResultadoApplication resultado)
        {
            if (resultado.CodigoRetorno == CodigoRetornoEnum.Sucesso && (resultado.Mensagem == null || resultado.Mensagem.Length == 0))
                return NoContent();
            else
                return TratarRetornoPadrao(resultado);
        }

        protected ActionResult<TViewModel> TratarRetorno<TViewModel>(IResultadoApplication<TViewModel> resultado)
        {
            if (resultado.CodigoRetorno == CodigoRetornoEnum.Sucesso)
            {
                if (resultado.Mensagem != null && resultado.Data != null)
                {
                    return TratarRetornoComDadosEMensagem(resultado);
                }
                else
                {
                    return Ok(resultado.Data);
                }
            }
            else
            {
                if (resultado.Data != null)
                {
                    return TratarRetornoErroComDados(resultado);
                }
                else
                {
                    return TratarRetornoPadrao(resultado);
                }
            }
        }

        protected ActionResult TratarRetornoPadrao(IResultadoApplication resultado)
        {
            switch (resultado.CodigoRetorno)
            {
                case CodigoRetornoEnum.NaoEncontrado:
                    return NotFound();
                case CodigoRetornoEnum.SemPermissao:
                    return Unauthorized();
            }
            return StatusCode((int)resultado.CodigoRetorno, resultado.Mensagem);
        }

        protected ActionResult<TViewModel> TratarRetornoComDadosEMensagem<TViewModel>(IResultadoApplication<TViewModel> resultado)
        {
            if (resultado.CodigoRetorno == CodigoRetornoEnum.Sucesso)
            {
                if (resultado.Mensagem != null && resultado.Data != null)
                {
                    var objResponse = new
                    {
                        mensagens = resultado.Mensagem,
                        dados = resultado.Data
                    };
                    return Ok(objResponse);
                }
                else
                {
                    return Ok(resultado.Data);
                }
            }
            else
            {
                if (resultado.Data != null)
                {
                    return TratarRetornoErroComDados(resultado);
                }
                else
                {
                    return TratarRetornoPadrao(resultado);
                }
            }
        }

        protected ActionResult<TViewModel> TratarRetornoErroComDados<TViewModel>(IResultadoApplication<TViewModel> resultado)
        {
            switch (resultado.CodigoRetorno)
            {
                case CodigoRetornoEnum.NaoEncontrado:
                    return NotFound();
                case CodigoRetornoEnum.SemPermissao:
                    return Unauthorized();
            }
            var objResponse = new
            {
                mensagens = resultado.Mensagem,
                dados = resultado.Data
            };
            return StatusCode((int)resultado.CodigoRetorno, objResponse);
        }

        protected ActionResult TratarRetornoArquivo(IResultadoApplication<MemoryStream> resultado, string nomeArquivo)
        {
            if (resultado.CodigoRetorno == CodigoRetornoEnum.Sucesso)
            {
                var mediaTypeHeaderValue = new MediaTypeHeaderValue("application/octet-stream");
                return File(resultado.Data.GetBuffer(), mediaTypeHeaderValue.MediaType, nomeArquivo);
            }
            return StatusCode((int)resultado.CodigoRetorno, resultado.Mensagem);
        }
    }
}
