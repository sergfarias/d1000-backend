using d1000.Common.Domain.Models.Data.Alunos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Services.Alunos.Infrastructure.Maps
{
    public class DML_BA_ALUNO_Map : IEntityTypeConfiguration<DML_BA_ALUNO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_ALUNO> builder)
        {
            builder.ToTable("DML_BA_ALUNO");

            builder.HasKey(c => c.ID_ALUNO);

            builder.Property(c => c.ID_ALUNO).IsRequired().HasColumnName("ID_ALUNO");
            builder.Property(c => c.NM_ALUNO).HasColumnName("NM_ALUNO");
            builder.Property(c => c.DT_NASC).HasColumnName("DT_NASC");
            builder.Property(c => c.CNPJ_CPF).IsRequired().HasColumnName("CNPJ_CPF");
            builder.Property(c => c.RG).HasColumnName("RG");
            builder.Property(c => c.ID_SIGLA_ORG_EXP).HasColumnName("ID_SIGLA_ORG_EXP");
            builder.Property(c => c.OBS).HasColumnName("OBS");
            builder.Property(c => c.STS_ALUNO).IsRequired().HasColumnName("STS_ALUNO");
            builder.Property(c => c.ID_TIPO_SEXO).IsRequired().HasColumnName("ID_TIPO_SEXO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");

        }
    }
}
