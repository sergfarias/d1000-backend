using d1000.Common.Domain.Models.Data.Alunos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Common.Infrastructure.Maps.Alunos
{
    public class DML_BA_SIGLA_ORG_EXP_Map : IEntityTypeConfiguration<DML_BA_SIGLA_ORG_EXP>
    {
        public void Configure(EntityTypeBuilder<DML_BA_SIGLA_ORG_EXP> builder)
        {
            builder.ToTable("DML_BA_SIGLA_ORG_EXP");

            builder.HasKey(c => c.ID_SIGLA_ORG_EXP);

            builder.Property(c => c.DS_SIGLA_ORG_EXP).IsRequired().HasColumnName("DS_SIGLA_ORG_EXP");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");
        }
    }
}
