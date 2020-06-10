using d1000.Common.Domain.Models.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Services.Base.Infrastructure.Maps
{
    public class DML_BA_USU_Map : IEntityTypeConfiguration<DML_BA_USU>
    {
        public void Configure(EntityTypeBuilder<DML_BA_USU> builder)
        {
            builder.ToTable("DML_BA_USU");

            builder.HasKey(c => c.ID_USU);

            builder.Property(c => c.NOME_USU).IsRequired().HasColumnName("NOME_USU");
            builder.Property(c => c.CPF).IsRequired().HasColumnName("CPF");
            builder.Property(c => c.DT_NASC).HasColumnName("DT_NASC");
            builder.Property(c => c.TELEFONE1).HasColumnName("TELEFONE1");
            builder.Property(c => c.TELEFONE2).HasColumnName("TELEFONE2");
            builder.Property(c => c.TELEFONE3).HasColumnName("TELEFONE3");
            builder.Property(c => c.ID_LOGRADOURO).HasColumnName("ID_LOGRADOURO");
            builder.Property(c => c.NR_LOGRADOURO).IsRequired().HasColumnName("NR_LOGRADOURO");
            builder.Property(c => c.CPL_LOGRADOURO).HasColumnName("CPL_LOGRADOURO");
            builder.Property(c => c.EMAIL).HasColumnName("EMAIL");
            builder.Property(c => c.SENHA).IsRequired().HasColumnName("SENHA");
            builder.Property(c => c.ULT_ALT_SENHA).HasColumnName("ULT_ALT_SENHA");
            builder.Property(c => c.STS_USU).IsRequired().HasColumnName("STS_USU");
            builder.Property(c => c.COD_CARGO).IsRequired().HasColumnName("COD_CARGO");
            builder.Property(c => c.DT_ADMISSAO).IsRequired().HasColumnName("DT_ADMISSAO");
            builder.Property(c => c.DT_DEMISSAO).HasColumnName("DT_DEMISSAO");
            builder.Property(c => c.SEXO).HasColumnName("SEXO");
            builder.Property(c => c.MATRICULA).IsRequired().HasColumnName("MATRICULA");
            builder.Property(c => c.NOME_REDE).HasColumnName("NOME_REDE");
            builder.Property(c => c.SITUACAO_FOLHA).HasColumnName("SITUACAO_FOLHA");
            builder.Property(c => c.COD_LEGADO).HasColumnName("COD_LEGADO");
            builder.Property(c => c.ID_USU_CAD).IsRequired().HasColumnName("ID_USU_CAD");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}
