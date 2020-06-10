using Shared.Domain.Impl.Validator;
using Shared.Domain.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain.Interface.Service
{
    public interface IBaseCrudService<TEntity> : IBaseService<TEntity, string> where TEntity : class, IEntity<TEntity, string>
    {
        ResultadoValidacao Inserir(TEntity model);

        ResultadoValidacao InserirRetornaModel(TEntity model);

        ResultadoValidacao<TEntity> InserirERetornar(TEntity model);

        ResultadoValidacao Atualizar(TEntity model);

        ResultadoValidacao<TEntity> AtualizarERetornar(TEntity model);

        ResultadoValidacao RemoverPorId(string id);

        ResultadoValidacao Remover(TEntity model);
    }
}
