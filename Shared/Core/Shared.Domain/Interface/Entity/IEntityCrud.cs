namespace Shared.Domain.Interface.Entity
{
    public interface IEntityCrud<TEntity> : IEntity<TEntity, string> where TEntity : class
    {
    }
}
