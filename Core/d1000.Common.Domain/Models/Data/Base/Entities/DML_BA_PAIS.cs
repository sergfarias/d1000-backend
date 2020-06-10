using System;

namespace d1000.Common.Domain.Models.Data.Base
{

    public class DML_BA_PAIS
    {
        public int ID_PAIS { get; set; }
        public string DS_PAIS { get; set; }
        public int COD_PAIS_SINTEGRA { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }
    }
}
