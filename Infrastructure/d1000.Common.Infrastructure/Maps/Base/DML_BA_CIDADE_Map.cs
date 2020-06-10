using d1000.Common.Domain.Models.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Services.Base.Infrastructure.Maps
{
    public class DML_BA_CIDADE_Map : IEntityTypeConfiguration<DML_BA_CIDADE>
    {
        public void Configure(EntityTypeBuilder<DML_BA_CIDADE> builder)
        {
            builder.ToTable("DML_BA_CIDADE");

            builder.HasKey(c => c.ID_CIDADE);

            builder.Property(c => c.NOME_CIDADE).IsRequired().HasColumnName("NOME_CIDADE");
            builder.Property(c => c.ID_UF).IsRequired().HasColumnName("ID_UF");
            builder.Property(c => c.ID_PAIS).IsRequired().HasColumnName("ID_PAIS");
            builder.Property(c => c.COD_IBGE).HasColumnName("COD_IBGE");
            builder.Property(c => c.COD_CID_IBGE).HasColumnName("COD_CID_IBGE");
            builder.Property(c => c.COD_UF_IBGE).HasColumnName("COD_UF_IBGE");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}
