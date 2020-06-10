using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain.Impl.Enum
{
    public enum CodigoRetornoEnum
    {
        Sucesso = 200,
        NaoEncontrado = 404,
        SemPermissao = 401,
        OperacaoNaoDisponivel = 403,
        Erro = 400
    }
}