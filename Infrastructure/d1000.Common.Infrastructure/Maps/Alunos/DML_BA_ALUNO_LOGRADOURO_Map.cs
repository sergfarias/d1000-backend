﻿using d1000.Common.Domain.Models.Data.Alunos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Infrastructure.Maps.Alunos
{
    public class DML_BA_ALUNO_LOGRADOURO_Map : IEntityTypeConfiguration<DML_BA_ALUNO_LOGRADOURO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_ALUNO_LOGRADOURO> builder)
        {
            builder.ToTable("DML_BA_ALUNO_LOGRADOURO");

            // Primary Key
            builder.HasKey(c => c.ID_ALUNO_LOGRADOURO);

            builder.Property(c => c.ID_ALUNO_LOGRADOURO).IsRequired().HasColumnName("ID_ALUNO_LOGRADOURO");
            builder.Property(c => c.ID_ALUNO).IsRequired().HasColumnName("ID_ALUNO");
            builder.Property(c => c.ID_LOGRADOURO).IsRequired().HasColumnName("ID_LOGRADOURO");
            builder.Property(c => c.NR_LOGRADOURO).HasColumnName("NR_LOGRADOURO");
            builder.Property(c => c.CPL_LOGRADOURO).HasColumnName("CPL_LOGRADOURO");
            builder.Property(c => c.PONTO_REFERENCIA).HasColumnName("PONTO_REFERENCIA");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");

        }
    }
}
