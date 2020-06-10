using FluentValidation;
using Shared.Domain.Impl.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace d1000.Common.Domain.Models.Data.Base
{

    public class DML_BA_LOGRADOURO : EntityCrud<DML_BA_LOGRADOURO>
    {
        public int ID_LOGRADOURO { get; set; }
        public string LOGRADOURO { get; set; }
        public string BAIRRO { get; set; }
		[ForeignKey("ID_CIDADE")]
		public int ID_CIDADE { get; set; }
        public string CEP { get; set; }

		public void PreencherDados(DML_BA_LOGRADOURO data)
		{
			LOGRADOURO = data.LOGRADOURO;
			BAIRRO = data.BAIRRO;
			ID_CIDADE = data.ID_CIDADE;
			CEP = data.CEP;
			ID_USU = 1; //Usuário Padrão
			DT_CAD = DateTime.Now; //Data do Cadastro
			DT_ULT_ALT = data.DT_ULT_ALT;
		}
	}

	public class LogradouroValidator : AbstractValidator<DML_BA_LOGRADOURO>
	{
		public LogradouroValidator()
		{
			RuleFor(x => x.LOGRADOURO).NotNull();
			RuleFor(x => x.BAIRRO).NotNull();
			RuleFor(x => x.ID_CIDADE).NotNull();
			RuleFor(x => x.CEP).MaximumLength(8).NotNull();
			RuleFor(x => x.ID_USU).NotNull();
			RuleFor(x => x.DT_CAD).NotNull();
			RuleFor(x => x.DT_ULT_ALT).Null();
		}
	}
}
