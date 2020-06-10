using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps
{

    public class DML_BA_TIPO_CARGO_Map : IEntityTypeConfiguration<DML_BA_TIPO_CARGO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_TIPO_CARGO> builder)
        {
            builder.ToTable("DML_BA_TIPO_CARGO");


            builder.HasKey(c => c.ID_TIPO_CARGO);

            builder.Property(c => c.ID_TIPO_CARGO).IsRequired().HasColumnName("ID_TIPO_CARGO");
            builder.Property(c => c.DS_TIPO_CARGO).IsRequired().HasColumnName("DS_TIPO_CARGO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }

    }

}
