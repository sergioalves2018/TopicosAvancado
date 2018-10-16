using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidade;

namespace Persistencia
{
    class LabInfoContexto : DbContext
    {
        public LabInfoContexto() : base("StringConexao")
        { }

        public DbSet<LabInfo> LabInfos { get; set; }
    }
}
