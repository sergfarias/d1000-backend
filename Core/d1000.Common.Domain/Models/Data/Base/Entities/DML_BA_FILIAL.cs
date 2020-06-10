
using System;

namespace d1000.Common.Models.Data.Base
{

	public class DML_BA_FILIAL
	{
		public int ID_FILIAL { get; set; }
		public string RAZAO_SOCIAL { get; set; }
		public string NOME_FANTASIA { get; set; }
		public string SIGLA_FILIAL { get; set; }
		public string NOME_LISTA { get; set; }
		public string LOGRADOURO { get; set; }

		public string? NR_LOGRADOURO { get; set; }
		public string? CPL_LOGRADOURO { get; set; }
		public string CNPJ { get; set; }
		public string? INSC_MUNI { get; set; }
		public string INSC_EST { get; set; }
		public int TIPO_FILIAL { get; set; }
		public int STS_FILIAL { get; set; }
		public int LOJA_ABERTA { get; set; }
		public int LOJA_24H { get; set; }
		public DateTime? DT_INAUGURACAO { get; set; }
		public int ORDEM_SEQ_FILIAL { get; set; }
		public int? REGIME_TRIBUTARIO { get; set; }
		public string? COD_EMPRESA_CONTABIL { get; set; }
		public string? COD_CENTRO_CUSTO_CONTABIL { get; set; }
		public decimal? METRAGEM_FILIAL { get; set; }
		public int ID_REDE { get; set; }
		public int ID_GRUPO_ECONOMICO { get; set; }
		public int CONNECT_D1000 { get; set; }
		public int ID_USU { get; set; }
		public DateTime DT_CAD { get; set; }
		public DateTime? DT_ULT_ALT { get; set; }


	}
}
