using System;

namespace d1000.Common.Domain.Data.Models {

    public class DML_BA_CARGO 
    {
        public int ID_CARGO { get; set; }
        public string NOME_CARGO { get; set; }
        public int TIPO_CARGO { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }
        public bool EXIGE_SENHA_ORC { get; set; }
    }
}
