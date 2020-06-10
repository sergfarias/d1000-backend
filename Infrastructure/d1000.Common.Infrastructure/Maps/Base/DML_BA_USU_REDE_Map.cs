
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using d1000.Common.Domain.Data.Models;

namespace d1000.Common.Infrastructure.Maps {

    public class DML_BA_USU_REDE_Map : IEntityTypeConfiguration<DML_BA_USU_REDE> 
    {
        public void Configure(EntityTypeBuilder<DML_BA_USU_REDE> builder)
        {
            builder.ToTable("DML_BA_USU_REDE");

            builder.HasKey(c => c.ID_USU);
            builder.HasKey(c => c.ID_REDE);

            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.ID_REDE).IsRequired().HasColumnName("ID_REDE");
            
        }

    }

}
