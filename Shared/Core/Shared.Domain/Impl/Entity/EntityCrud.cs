using Shared.Domain.Interface.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Domain.Impl.Entity
{
    public abstract class EntityCrud<TEntity> : Entity<TEntity, string>, IEntityCrud<TEntity>
         where TEntity : class
    {
        [ForeignKey("ID_USU")]
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }
    }
}
