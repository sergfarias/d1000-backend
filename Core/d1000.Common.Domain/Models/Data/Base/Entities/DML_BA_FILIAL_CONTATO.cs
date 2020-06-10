using System;

namespace d1000.Common.Domain.Data.Models {

    public class DML_BA_FILIAL_CONTATO 
    {
        public int ID_FILIAL { get; set; }
        public int ID_TIPO_CONTATO { get; set; }
        public string CONTATO { get; set; }
        public bool CONTATO_PRINCIPAL { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }

    }
}
