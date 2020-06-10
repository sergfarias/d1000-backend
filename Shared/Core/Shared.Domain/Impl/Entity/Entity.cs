using Shared.Domain.Interface.Entity;

namespace Shared.Domain.Impl.Entity
{
    public abstract class Entity<TEntity, TTYpe> : IEntity<TEntity, TTYpe> where TEntity : class
    {
        //public TTYpe Id { get; set; }
    }
}
