using d1000.Common.Domain.Models.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Services.Base.Infrastructure.Maps
{
    public class DML_BA_PAIS_Map : IEntityTypeConfiguration<DML_BA_PAIS>
    {
        public void Configure(EntityTypeBuilder<DML_BA_PAIS> builder)
        {
            builder.ToTable("DML_BA_PAIS");

            builder.HasKey(c => c.ID_PAIS);

            builder.Property(c => c.DS_PAIS).IsRequired().HasColumnName("DS_PAIS");
            builder.Property(c => c.COD_PAIS_SINTEGRA).IsRequired().HasColumnName("COD_PAIS_SINTEGRA");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}
