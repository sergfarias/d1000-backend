using d1000.Common.Domain.Models.Data.Alunos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Infrastructure.Maps.Alunos
{
    public class DML_BA_TIPO_SEXO_Map : IEntityTypeConfiguration<DML_BA_TIPO_SEXO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_TIPO_SEXO> builder)
        {
            builder.ToTable("DML_BA_TIPO_SEXO");

            builder.HasKey(c => c.ID_TIPO_SEXO);

            builder.Property(c => c.DS_TIPO_SEXO).IsRequired().HasColumnName("DS_TIPO_SEXO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}
