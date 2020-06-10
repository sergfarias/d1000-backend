using d1000.Common.Domain.Models.Data.Alunos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace d1000.Common.Infrastructure.Maps.Alunos
{
    public class DML_BA_ALUNO_CONTATO_Map : IEntityTypeConfiguration<DML_BA_ALUNO_CONTATO>
    {
        public void Configure(EntityTypeBuilder<DML_BA_ALUNO_CONTATO> builder)
        {
            builder.ToTable("DML_BA_ALUNO_CONTATO");

            // Primary Key
            builder.HasKey(c => c.ID_CONTATO);

            builder.Property(c => c.ID_CONTATO).IsRequired().HasColumnName("ID_CONTATO");
            builder.Property(c => c.ID_ALUNO).IsRequired().HasColumnName("ID_ALUNO");
            builder.Property(c => c.ID_TIPO_CONTATO).IsRequired().HasColumnName("ID_TIPO_CONTATO");
            builder.Property(c => c.DS_CONTATO).IsRequired().HasColumnName("DS_CONTATO");
            builder.Property(c => c.ID_USU).IsRequired().HasColumnName("ID_USU");
            builder.Property(c => c.DT_CAD).IsRequired().HasColumnName("DT_CAD");
            builder.Property(c => c.DT_ULT_ALT).HasColumnName("DT_ULT_ALT");

        }
    }
}
