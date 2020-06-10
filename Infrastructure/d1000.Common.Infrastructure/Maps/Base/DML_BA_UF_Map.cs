using d1000.Common.Domain.Models.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Services.Base.Infrastructure.Maps
{
    public class DML_BA_UF_Map : IEntityTypeConfiguration<DML_BA_UF>
    {
        public void Configure(EntityTypeBuilder<DML_BA_UF> builder)
        {
            builder.ToTable("DML_BA_UF");

            builder.HasKey(c => c.ID_UF);

            builder.Property(c => c.DS_UF).IsRequired().HasColumnName("DS_UF");
            builder.Property(c => c.SIGLA_UF).IsRequired().HasColumnName("SIGLA_UF");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}
