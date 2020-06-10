using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps {

    public class DML_BA_GRUPO_USU_Map : IEntityTypeConfiguration<DML_BA_GRUPO_USU>
    { 
        public void Configure(EntityTypeBuilder<DML_BA_GRUPO_USU> builder)
        {
            builder.ToTable("DML_BA_GRUPO_USU");

            
            builder.HasKey(c => c.ID_GRUPO_USU);

            builder.Property(c => c.ID_GRUPO_USU).IsRequired().HasColumnName("ID_GRUPO_USU");
            builder.Property(c => c.NOME).IsRequired().HasColumnName("NOME");
            builder.Property(c => c.DESCRICAO).IsRequired().HasColumnName("DESCRICAO");

            
        }

    }

}
