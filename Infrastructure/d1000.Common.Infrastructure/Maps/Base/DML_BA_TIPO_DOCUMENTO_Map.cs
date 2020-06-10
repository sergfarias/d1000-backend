using d1000.Common.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Common.Infrastructure.Maps.Base
{
    public class DML_BA_TIPO_DOCUMENTO_Map : IEntityTypeConfiguration<DML_BA_TIPO_DOCUMENTO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_TIPO_DOCUMENTO> builder)
        {
            builder.ToTable("DML_BA_TIPO_DOCUMENTO");

            builder.HasKey(c => c.ID_TIPO_DOCUMENTO);

            builder.Property(c => c.DS_TIPO_DOCUMENTO).IsRequired().HasColumnName("DS_TIPO_DOCUMENTO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}