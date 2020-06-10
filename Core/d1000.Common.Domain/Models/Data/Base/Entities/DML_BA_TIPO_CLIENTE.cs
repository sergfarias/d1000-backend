using System;

namespace d1000.Common.Domain.Data.Models {

    public class DML_BA_TIPO_CLIENTE 
    {
        public int ID_TIPO_CLIENTE { get; set; }
        public string DS_TIPO_CLIENTE { get; set; }
        public bool GERA_SUBS_TRIB { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }
    }
}
