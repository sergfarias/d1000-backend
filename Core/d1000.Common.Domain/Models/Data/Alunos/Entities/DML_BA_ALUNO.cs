using FluentValidation;
using Shared.Domain.Impl.Entity;
using System;

namespace d1000.Common.Domain.Models.Data.Alunos
{

    public class DML_BA_ALUNO : EntityCrud<DML_BA_ALUNO>
    {

        public int ID_ALUNO { get; set; }
        public string? NM_ALUNO { get; set; }
        public DateTime? DT_NASC { get; set; }
        public string CNPJ_CPF { get; set; }
        public string? RG { get; set; }
        public int? ID_SIGLA_ORG_EXP { get; set; }
        public string? OBS { get; set; }
        public bool STS_ALUNO { get; set; }
        public int ID_TIPO_SEXO { get; set; }
        
        public void PreencherDados(DML_BA_ALUNO data)
        {
            ID_ALUNO = data.ID_ALUNO;
            NM_ALUNO = data.NM_ALUNO;
            DT_NASC = data.DT_NASC;
            CNPJ_CPF = data.CNPJ_CPF;
            RG = data.RG;
            ID_SIGLA_ORG_EXP = data.ID_SIGLA_ORG_EXP;
            OBS = data.OBS;
            STS_ALUNO = data.STS_ALUNO;
            ID_TIPO_SEXO = data.ID_TIPO_SEXO;
            ID_USU = data.ID_USU; //Usuário Padrão
            DT_CAD = DateTime.Now; //Data do Cadastro
            DT_ULT_ALT = data.DT_ULT_ALT;
        }
    }

    public class AlunoValidator : AbstractValidator<DML_BA_ALUNO>
    {
        public AlunoValidator()
        {
            RuleFor(x => x.NM_ALUNO).NotNull();
            RuleFor(x => x.CNPJ_CPF).MaximumLength(14).NotNull();
            RuleFor(x => x.STS_ALUNO).NotNull();
            RuleFor(x => x.ID_TIPO_SEXO).NotNull();
            RuleFor(x => x.ID_USU).NotNull();
            RuleFor(x => x.DT_CAD).NotNull();
            RuleFor(x => x.DT_ULT_ALT).Null();
        }
    }
}
