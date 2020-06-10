using d1000.Common.Domain.Models.Data.Base.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Infrastructure.Maps.Base
{
    public class DML_BA_TIPO_CONTATO_Map : IEntityTypeConfiguration<DML_BA_TIPO_CONTATO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_TIPO_CONTATO> builder)
        {
            builder.ToTable("DML_BA_TIPO_CONTATO");

            builder.HasKey(c => c.ID_TIPO_CONTATO);

            builder.Property(c => c.DS_TIPO_CONTATO).IsRequired().HasColumnName("DS_TIPO_CONTATO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}