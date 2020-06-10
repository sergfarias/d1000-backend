using System;

namespace d1000.Common.Domain.Models.Data.Base
{

    public class DML_BA_CIDADE
    {
        public int ID_CIDADE { get; set; }
        public string NOME_CIDADE { get; set; }
        public int ID_UF { get; set; }
        public int ID_PAIS { get; set; }
        public int? COD_IBGE { get; set; }
        public int? COD_CID_IBGE { get; set; }
        public int? COD_UF_IBGE { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }
    }
}
