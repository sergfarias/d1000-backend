using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps {

    public class DML_BA_USU_PERMISSAO_Map : IEntityTypeConfiguration<DML_BA_USU_PERMISSAO> {
        
        public DML_BA_USU_PERMISSAO_Map() { }

        public void Configure(EntityTypeBuilder<DML_BA_USU_PERMISSAO> builder)
        {
            builder.ToTable("DML_BA_USU_PERMISSAO");

            builder.HasKey(c => c.ID_USU);
            builder.HasKey(c => c.ID_MODULO);
            builder.HasKey(c => c.ID_TELA);
            builder.HasKey(c => c.ID_PERMISSAO);
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.ID_MODULO).IsRequired().HasColumnName("ID_MODULO");
            builder.Property(c => c.ID_TELA).IsRequired().HasColumnName("ID_TELA");
            builder.Property(c => c.ID_PERMISSAO).IsRequired().HasColumnName("ID_PERMISSAO");
            
        }

    }

}
