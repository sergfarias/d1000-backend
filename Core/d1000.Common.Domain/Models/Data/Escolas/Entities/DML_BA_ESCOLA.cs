using FluentValidation;
using Shared.Domain.Impl.Entity;
using System;

namespace d1000.Common.Domain.Models.Data.Escolas
{

    public class DML_BA_ESCOLA : EntityCrud<DML_BA_ESCOLA>
    {

        public int ID_ESCOLA { get; set; }
        public string? NM_ESCOLA { get; set; }
        public string RG_MEC { get; set; }
        public int ID_TIPO_ESCOLA { get; set; }
        public string? OBS { get; set; }
        public bool STS_ESCOLA { get; set; }
       
        public void PreencherDados(DML_BA_ESCOLA data)
        {
            ID_ESCOLA = data.ID_ESCOLA;
            NM_ESCOLA = data.NM_ESCOLA;
            RG_MEC = data.RG_MEC;
            ID_TIPO_ESCOLA = data.ID_TIPO_ESCOLA;
            OBS = data.OBS;
            STS_ESCOLA = data.STS_ESCOLA;
            ID_USU = data.ID_USU; //Usuário Padrão
            DT_CAD = DateTime.Now; //Data do Cadastro
            DT_ULT_ALT = data.DT_ULT_ALT;
        }
    }

    public class EscolaValidator : AbstractValidator<DML_BA_ESCOLA>
    {
        public EscolaValidator()
        {
            RuleFor(x => x.RG_MEC).MaximumLength(14).NotNull();
            RuleFor(x => x.ID_TIPO_ESCOLA).NotNull();
            RuleFor(x => x.STS_ESCOLA).NotNull();
            RuleFor(x => x.ID_USU).NotNull();
            RuleFor(x => x.DT_CAD).NotNull();
            RuleFor(x => x.DT_ULT_ALT).Null();
        }
    }
}
