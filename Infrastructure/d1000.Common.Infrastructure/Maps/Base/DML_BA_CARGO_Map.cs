
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps {

    public class DML_BA_CARGO_Map : IEntityTypeConfiguration<DML_BA_CARGO> 
    {

        public void Configure(EntityTypeBuilder<DML_BA_CARGO> builder)
        {
            builder.ToTable("DML_BA_CARGO");
            
            builder.HasKey(c => c.ID_CARGO);

            builder.Property(c => c.ID_CARGO).IsRequired().HasColumnName("ID_CARGO");
            builder.Property(c => c.NOME_CARGO).IsRequired().HasColumnName("NOME_CARGO");
            builder.Property(c => c.TIPO_CARGO).IsRequired().HasColumnName("TIPO_CARGO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
            builder.Property(c => c.EXIGE_SENHA_ORC).HasColumnName("EXIGE_SENHA_ORC");

        }
    }
}
