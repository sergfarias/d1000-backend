using System;

namespace d1000.Common.Domain.Data.Models {

    public class DML_BA_TIPO_DOCUMENTO 
    {
        public int ID_TIPO_DOCUMENTO { get; set; }
        public string DS_TIPO_DOCUMENTO { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }

        

    }

}
