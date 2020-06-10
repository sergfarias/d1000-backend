using System;

namespace d1000.Common.Domain.Models.Data.Base
{

    public class DML_BA_USU
    {

        public int ID_USU { get; set; }
        public string NOME_USU { get; set; }
        public string CPF { get; set; }
        public DateTime? DT_NASC { get; set; }
        public string? TELEFONE1 { get; set; }
        public string? TELEFONE2 { get; set; }
        public string? TELEFONE3 { get; set; }
        public int? ID_LOGRADOURO { get; set; }
        public int NR_LOGRADOURO { get; set; }
        public string? CPL_LOGRADOURO { get; set; }
        public string? EMAIL { get; set; }
        public string SENHA { get; set; }
        public DateTime? ULT_ALT_SENHA { get; set; }
        public int STS_USU { get; set; }
        public int COD_CARGO { get; set; }
        public DateTime DT_ADMISSAO { get; set; }
        public DateTime? DT_DEMISSAO { get; set; }
        public int? SEXO { get; set; }
        public string MATRICULA { get; set; }
        public string? NOME_REDE { get; set; }
        public string? SITUACAO_FOLHA { get; set; }
        public int? COD_LEGADO { get; set; }
        public int ID_USU_CAD { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }
    }

}
