using Shared.Domain.Impl.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Domain.Models.Data.Alunos
{
    public class DML_BA_SIGLA_ORG_EXP : EntityCrud<DML_BA_SIGLA_ORG_EXP>
    {
        public int ID_SIGLA_ORG_EXP { get; set; }
        public string DS_SIGLA_ORG_EXP { get; set; }
    }
}
