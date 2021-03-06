﻿using d1000.Common.Domain.Models.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Services.Base.Infrastructure.Maps
{
    public class DML_BA_LOGRADOURO_Map : IEntityTypeConfiguration<DML_BA_LOGRADOURO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_LOGRADOURO> builder)
        {
            builder.ToTable("DML_BA_LOGRADOURO");

            builder.HasKey(c => c.ID_LOGRADOURO);

            builder.Property(c => c.LOGRADOURO).IsRequired().HasColumnName("LOGRADOURO");
            builder.Property(c => c.BAIRRO).IsRequired().HasColumnName("BAIRRO");
            builder.Property(c => c.ID_CIDADE).IsRequired().HasColumnName("ID_CIDADE");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}
