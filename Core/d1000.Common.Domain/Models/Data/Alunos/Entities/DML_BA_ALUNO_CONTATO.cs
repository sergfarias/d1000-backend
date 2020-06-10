using FluentValidation;
using Shared.Domain.Impl.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Alunos.Entities
{
    public class DML_BA_ALUNO_CONTATO : EntityCrud<DML_BA_ALUNO_CONTATO>
    {

        public int ID_CONTATO { get; set; }
        public int ID_ALUNO { get; set; }
        public int ID_TIPO_CONTATO { get; set; }
        public string DS_CONTATO { get; set; }
    }

    public class AlunoContatoValidator : AbstractValidator<DML_BA_ALUNO_CONTATO>
    {
        public AlunoContatoValidator()
        {
            RuleFor(x => x.ID_CONTATO).NotNull();
            RuleFor(x => x.ID_ALUNO).NotNull();
            RuleFor(x => x.ID_TIPO_CONTATO).NotNull();
            RuleFor(x => x.DS_CONTATO).NotNull();
        }
    }
}
