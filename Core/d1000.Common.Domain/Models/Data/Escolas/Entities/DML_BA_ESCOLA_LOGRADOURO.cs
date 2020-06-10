using FluentValidation;
using Shared.Domain.Impl.Entity;

namespace d1000.Common.Domain.Models.Data.Escolas.Entities
{
    public class DML_BA_ESCOLA_LOGRADOURO : EntityCrud<DML_BA_ESCOLA_LOGRADOURO>
    {
        public int ID_ESCOLA_LOGRADOURO { get; set; }
        public int ID_LOGRADOURO { get; set; }
        public int ID_ESCOLA { get; set; }
        public string? NR_LOGRADOURO { get; set; }
        public string? CPL_LOGRADOURO { get; set; }
        public string? PONTO_REFERENCIA { get; set; }
    }

    public class EscolaLogradouroValidator : AbstractValidator<DML_BA_ESCOLA_LOGRADOURO>
    {
        public EscolaLogradouroValidator()
        {
            RuleFor(x => x.ID_ESCOLA_LOGRADOURO).NotNull();
            RuleFor(x => x.ID_LOGRADOURO).NotNull();
            RuleFor(x => x.ID_ESCOLA).NotNull();
        }
    }
}
