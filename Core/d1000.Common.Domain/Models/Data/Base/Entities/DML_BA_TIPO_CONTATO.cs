using Shared.Domain.Impl.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Base.Entities
{
    public class DML_BA_TIPO_CONTATO : EntityCrud<DML_BA_TIPO_CONTATO>
    {
        public int ID_TIPO_CONTATO { get; set; }
        public string DS_TIPO_CONTATO { get; set; }
    }
}
