using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    [Table("LabInfo")]
    public class LabInfo
    {
       public int id { get; set; }
       public string nome { get; set; }
       public int qtdComputadores { get; set; }
       public int qtdAlunos { get; set; }
       public bool projetor { get; set; }
       public string software1 { get; set; }
       public string software2 { get; set; }
       public string software3 { get; set; }
       public string sistemaOperacional { get; set; }
    }
}
