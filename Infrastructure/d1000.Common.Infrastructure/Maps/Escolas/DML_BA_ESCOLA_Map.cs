using d1000.Common.Domain.Models.Data.Escolas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Services.Escolas.Infrastructure.Maps
{
    public class DML_BA_ESCOLA_Map : IEntityTypeConfiguration<DML_BA_ESCOLA>
    {
        public void Configure(EntityTypeBuilder<DML_BA_ESCOLA> builder)
        {
            builder.ToTable("DML_BA_ESCOLA");
            builder.HasKey(c => c.ID_ESCOLA);
            builder.Property(c => c.ID_ESCOLA).IsRequired().HasColumnName("ID_ESCOLA");
            builder.Property(c => c.NM_ESCOLA).HasColumnName("NM_ESCOLA");
            builder.Property(c => c.RG_MEC).IsRequired().HasColumnName("RG_MEC");
            builder.Property(c => c.ID_TIPO_ESCOLA).IsRequired().HasColumnName("ID_TIPO_ESCOLA");
            builder.Property(c => c.OBS).HasColumnName("OBS");
            builder.Property(c => c.STS_ESCOLA).IsRequired().HasColumnName("STS_ESCOLA");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");

        }
    }
}
