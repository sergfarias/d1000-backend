using d1000.Common.Domain.Models.Data.Escolas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Common.Infrastructure.Maps.Escolas
{
    public class DML_BA_ESCOLA_CONTATO_Map : IEntityTypeConfiguration<DML_BA_ESCOLA_CONTATO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_ESCOLA_CONTATO> builder)
        {
            builder.ToTable("DML_BA_ESCOLA_CONTATO");

            // Primary Key
            builder.HasKey(c => c.ID_CONTATO);

            builder.Property(c => c.ID_CONTATO).IsRequired().HasColumnName("ID_CONTATO");
            builder.Property(c => c.ID_ESCOLA).IsRequired().HasColumnName("ID_ESCOLA");
            builder.Property(c => c.ID_TIPO_CONTATO).IsRequired().HasColumnName("ID_TIPO_CONTATO");
            builder.Property(c => c.DS_CONTATO).IsRequired().HasColumnName("DS_CONTATO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");

        }
    }
}
