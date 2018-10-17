using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class EquipamentoVO
    {
        public int id { get; set; }
        public String nome { get; set; }
        public decimal valor { get; set; }
        public DateTime dataCadastro { get; set; }
    }
}
