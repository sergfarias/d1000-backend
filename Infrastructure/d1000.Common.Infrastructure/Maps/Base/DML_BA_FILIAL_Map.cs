
using d1000.Common.Models.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Services.Base.Infrastructure.Maps
{
    public class DML_BA_FILIAL_Map : IEntityTypeConfiguration<DML_BA_FILIAL>
    {
        public void Configure(EntityTypeBuilder<DML_BA_FILIAL> builder)
        {
            builder.ToTable("DML_BA_FILIAL");

            builder.HasKey(c => c.ID_FILIAL);

            builder.Property(c => c.RAZAO_SOCIAL).IsRequired().HasColumnName("RAZAO_SOCIAL");
            builder.Property(c => c.NOME_FANTASIA).IsRequired().HasColumnName("NOME_FANTASIA");
            builder.Property(c => c.SIGLA_FILIAL).IsRequired().HasColumnName("SIGLA_FILIAL");
            builder.Property(c => c.NOME_LISTA).IsRequired().HasColumnName("NOME_LISTA");
            builder.Property(c => c.LOGRADOURO).IsRequired().HasColumnName("LOGRADOURO");
            builder.Property(c => c.NR_LOGRADOURO).HasColumnName("NR_LOGRADOURO");
            builder.Property(c => c.CPL_LOGRADOURO).HasColumnName("CPL_LOGRADOURO");
            builder.Property(c => c.CNPJ).IsRequired().HasColumnName("CNPJ");
            builder.Property(c => c.INSC_MUNI).IsRequired().HasColumnName("INSC_MUNI");
            builder.Property(c => c.INSC_EST).IsRequired().HasColumnName("INSC_EST");
            builder.Property(c => c.TIPO_FILIAL).IsRequired().HasColumnName("TIPO_FILIAL");
            builder.Property(c => c.STS_FILIAL).IsRequired().HasColumnName("STS_FILIAL");
            builder.Property(c => c.LOJA_ABERTA).IsRequired().HasColumnName("LOJA_ABERTA");
            builder.Property(c => c.LOJA_24H).IsRequired().HasColumnName("LOJA_24H");
            builder.Property(c => c.DT_INAUGURACAO).HasColumnName("DT_INAUGURACAO");
            builder.Property(c => c.ORDEM_SEQ_FILIAL).IsRequired().HasColumnName("ORDEM_SEQ_FILIAL");
            builder.Property(c => c.REGIME_TRIBUTARIO).HasColumnName("REGIME_TRIBUTARIO");
            builder.Property(c => c.COD_EMPRESA_CONTABIL).HasColumnName("COD_EMPRESA_CONTABIL");
            builder.Property(c => c.COD_CENTRO_CUSTO_CONTABIL).HasColumnName("COD_CENTRO_CUSTO_CONTABIL");
            builder.Property(c => c.METRAGEM_FILIAL).HasColumnName("METRAGEM_FILIAL");
            builder.Property(c => c.ID_REDE).IsRequired().HasColumnName("ID_REDE");
            builder.Property(c => c.ID_GRUPO_ECONOMICO).IsRequired().HasColumnName("ID_GRUPO_ECONOMICO");
            builder.Property(c => c.CONNECT_D1000).IsRequired().HasColumnName("CONNECT_D1000");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}

