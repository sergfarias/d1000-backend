using Shared.Domain.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain.Interface.Repository
{
    public interface IBaseCrudRepository<TEntity> : IBaseRepository<TEntity, string>
        where TEntity : class, IEntityCrud<TEntity>
    {
        void Inserir(TEntity entity);

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);

        void RemoverPorId(string id);

        void InserirRetornaModel(TEntity entity);

    }
}
