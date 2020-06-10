using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps {

    public class DML_BA_TELA_Map : IEntityTypeConfiguration<DML_BA_TELA> 
    {
        public void Configure(EntityTypeBuilder<DML_BA_TELA> builder)
        {
            builder.ToTable("DML_BA_TELA");

            
            builder.HasKey(c => c.ID_TELA);

            builder.Property(c => c.ID_TELA).IsRequired().HasColumnName("ID_TELA");
            builder.Property(c => c.NOME).IsRequired().HasColumnName("NOME");
            builder.Property(c => c.DESCRICAO).IsRequired().HasColumnName("DESCRICAO");

            
        }

    }

}
