using Microsoft.EntityFrameworkCore;
using System.Linq;
using Shared.Domain.Interface.Entity;
using Shared.Domain.Interface.Repository;

namespace Shared.Infrastructure.Repository
{
    public abstract class BaseCrudRepository<TEntity> : BaseRepository<TEntity, string>, IBaseCrudRepository<TEntity>
        where TEntity : class, IEntityCrud<TEntity>
    {
        public BaseCrudRepository(DbContext context) : base(context)
        {
        }

        void IBaseCrudRepository<TEntity>.Inserir(TEntity entity)
        {
            base.Inserir(entity);
        }

        void IBaseCrudRepository<TEntity>.Atualizar(TEntity entity)
        {
            base.Atualizar(entity);
        }

        void IBaseCrudRepository<TEntity>.Remover(TEntity entity)
        {
            base.Remover(entity);
        }

        void IBaseCrudRepository<TEntity>.RemoverPorId(string id)
        {
            base.RemoverPorId(id);
        }

        void IBaseCrudRepository<TEntity>.InserirRetornaModel(TEntity entity)
        {
            base.InserirRetornaModel(entity);
        }
    }
}
