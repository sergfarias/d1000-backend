using FluentValidation;
using Shared.Domain.Impl.Entity;
using System;

namespace d1000.Common.Domain.Models.Data.Turmas
{

    public class DML_BA_TURMA : EntityCrud<DML_BA_TURMA>
    {
        public int ID_TURMA { get; set; }
        public int ID_ESCOLA { get; set; }
        public string DESCRICAO { get; set; }
        public string PERIODO { get; set; }
       
        public void PreencherDados(DML_BA_TURMA data)
        {
            ID_TURMA = data.ID_TURMA;
            ID_ESCOLA = data.ID_ESCOLA;
            DESCRICAO = data.DESCRICAO;
            PERIODO = data.PERIODO;
            ID_USU = data.ID_USU; //Usuário Padrão
            DT_CAD = DateTime.Now; //Data do Cadastro
            DT_ULT_ALT = data.DT_ULT_ALT;
        }
    }

    public class EscolaValidator : AbstractValidator<DML_BA_TURMA>
    {
        public EscolaValidator()
        {
            RuleFor(x => x.DESCRICAO).MaximumLength(14).NotNull();
            RuleFor(x => x.ID_ESCOLA).NotNull();
            RuleFor(x => x.PERIODO).NotNull();
            RuleFor(x => x.ID_USU).NotNull();
            RuleFor(x => x.DT_CAD).NotNull();
            RuleFor(x => x.DT_ULT_ALT).Null();
        }
    }
}
