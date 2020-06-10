using d1000.Common.Domain.Models.Data.Turmas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Services.Turmas.Infrastructure.Maps
{
    public class DML_BA_TURMA_Map : IEntityTypeConfiguration<DML_BA_TURMA>
    {
        public void Configure(EntityTypeBuilder<DML_BA_TURMA> builder)
        {
            builder.ToTable("DML_BA_TURMA");
            builder.HasKey(c => c.ID_TURMA);
            builder.Property(c => c.ID_TURMA).IsRequired().HasColumnName("ID_TURMA");
            builder.Property(c => c.DESCRICAO).HasColumnName("DESCRICAO");
            builder.Property(c => c.PERIODO).HasColumnName("PERIODO");
            builder.Property(c => c.ID_ESCOLA).IsRequired().HasColumnName("ID_ESCOLA");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");

        }
    }
}
