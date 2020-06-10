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

        //private void a(Exception exception)
        //{
        //    //            if (exception is DbEntityValidationException)
        //    //{
        //    //    // Retrieve the error messages as a list of strings.
        //    //    var errorMessages = dbEx.EntityValidationErrors
        //    //            .SelectMany(x => x.ValidationErrors)
        //    //            .Select(x => x.ErrorMessage);

        //    //    // Join the list to a single string.
        //    //    var fullErrorMessage = string.Join("; ", errorMessages);

        //    //    // Combine the original exception message with the new one.
        //    //    var exceptionMessage = string.Concat(dbEx.Message, " The validation errors are: ", fullErrorMessage);

        //    //    // tracing in output
        //    //    foreach (var validationErrors in dbEx.EntityValidationErrors)
        //    //    {
        //    //        foreach (var validationError in validationErrors.ValidationErrors)
        //    //        {
        //    //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
        //    //        }
        //    //    }

        //    //    throw dbEx;
        //    //}

        //}
    }
}
