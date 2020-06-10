using Shared.Domain.Impl.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Alunos
{
    public class DML_BA_TIPO_SEXO : EntityCrud<DML_BA_TIPO_SEXO>
    {
       public int ID_TIPO_SEXO { get; set; }
       public string DS_TIPO_SEXO { get; set; }
    }
}
