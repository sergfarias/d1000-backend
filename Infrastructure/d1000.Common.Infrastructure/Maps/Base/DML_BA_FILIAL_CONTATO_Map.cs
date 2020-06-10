using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps {

    public class DML_BA_FILIAL_CONTATO_Map : IEntityTypeConfiguration<DML_BA_FILIAL_CONTATO> 
    {
        public void Configure(EntityTypeBuilder<DML_BA_FILIAL_CONTATO> builder)
        {
            builder.ToTable("DML_BA_FILIAL_CONTATO");

            builder.HasKey(c => c.ID_FILIAL);
            builder.HasKey(c => c.ID_TIPO_CONTATO);
            builder.Property(c => c.ID_FILIAL).IsRequired().HasColumnName("ID_FILIAL");
            builder.Property(c => c.ID_TIPO_CONTATO).IsRequired().HasColumnName("ID_TIPO_CONTATO");
            builder.Property(c => c.CONTATO).IsRequired().HasColumnName("CONTATO");
            builder.Property(c => c.CONTATO_PRINCIPAL).IsRequired().HasColumnName("CONTATO_PRINCIPAL");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");

        }

    }

}
