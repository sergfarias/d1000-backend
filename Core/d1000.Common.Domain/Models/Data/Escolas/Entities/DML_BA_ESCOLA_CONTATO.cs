using FluentValidation;
using Shared.Domain.Impl.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Escolas.Entities
{
    public class DML_BA_ESCOLA_CONTATO : EntityCrud<DML_BA_ESCOLA_CONTATO>
    {

        public int ID_CONTATO { get; set; }
        public int ID_ESCOLA { get; set; }
        public int ID_TIPO_CONTATO { get; set; }
        public string DS_CONTATO { get; set; }
    }

    public class EscolaContatoValidator : AbstractValidator<DML_BA_ESCOLA_CONTATO>
    {
        public EscolaContatoValidator()
        {
            RuleFor(x => x.ID_CONTATO).NotNull();
            RuleFor(x => x.ID_ESCOLA).NotNull();
            RuleFor(x => x.ID_TIPO_CONTATO).NotNull();
            RuleFor(x => x.DS_CONTATO).NotNull();
        }
    }
}
