using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps {

    public class DML_BA_REGIAO_Map : IEntityTypeConfiguration<DML_BA_REGIAO> 
    {
        public void Configure(EntityTypeBuilder<DML_BA_REGIAO> builder)
        {
            builder.ToTable("DML_BA_REGIAO");

            
            builder.HasKey(c => c.ID_REGIAO);

            builder.Property(c => c.ID_REGIAO).IsRequired().HasColumnName("ID_REGIAO");
            builder.Property(c => c.DS_REGIAO).IsRequired().HasColumnName("DS_REGIAO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");

            
        }

    }

}
