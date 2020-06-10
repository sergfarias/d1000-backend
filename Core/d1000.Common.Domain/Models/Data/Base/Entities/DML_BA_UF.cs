using System;

namespace d1000.Common.Domain.Models.Data.Base
{
    public class DML_BA_UF
    {
        public int ID_UF { get; set; }
        public string DS_UF { get; set; }
        public string SIGLA_UF { get; set; }
        public int ID_USU { get; set; }
        public DateTime DT_CAD { get; set; }
        public DateTime? DT_ULT_ALT { get; set; }
    }
}
