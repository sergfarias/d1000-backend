using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps {

    public class DML_BA_FORMA_PAG_Map : IEntityTypeConfiguration<DML_BA_FORMA_PAG> 
    {
        public void Configure(EntityTypeBuilder<DML_BA_FORMA_PAG> builder)
        {
            builder.ToTable("DML_BA_FORMA_PAG");

            builder.HasKey(c => c.ID_FORMA_PAG);
            builder.Property(c => c.ID_FORMA_PAG).IsRequired().HasColumnName("ID_FORMA_PAG");
            builder.Property(c => c.DESCRICAO).IsRequired().HasColumnName("DESCRICAO");
            
        }

    }

}
