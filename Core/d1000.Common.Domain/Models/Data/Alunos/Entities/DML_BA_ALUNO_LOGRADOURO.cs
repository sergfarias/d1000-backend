using FluentValidation;
using Shared.Domain.Impl.Entity;

namespace d1000.Common.Domain.Models.Data.Alunos.Entities
{
    public class DML_BA_ALUNO_LOGRADOURO : EntityCrud<DML_BA_ALUNO_LOGRADOURO>
    {
        public int ID_ALUNO_LOGRADOURO { get; set; }
        public int ID_LOGRADOURO { get; set; }
        public int ID_ALUNO { get; set; }
        public string? NR_LOGRADOURO { get; set; }
        public string? CPL_LOGRADOURO { get; set; }
        public string? PONTO_REFERENCIA { get; set; }
    }

    public class AlunoLogradouroValidator : AbstractValidator<DML_BA_ALUNO_LOGRADOURO>
    {
        public AlunoLogradouroValidator()
        {
            RuleFor(x => x.ID_ALUNO_LOGRADOURO).NotNull();
            RuleFor(x => x.ID_LOGRADOURO).NotNull();
            RuleFor(x => x.ID_ALUNO).NotNull();
        }
    }
}
