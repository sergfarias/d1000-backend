using System;

namespace d1000.Common.Domain.Data.Models {

    public class DML_BA_TIPO_PROD_EQUIPAMENTO {

        public int ID_TIPO_PROD_EQUIPAMENTO { get; set; }
        public string DS_TIPO_PROD_EQUIPAMENTO { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }
    }
}
