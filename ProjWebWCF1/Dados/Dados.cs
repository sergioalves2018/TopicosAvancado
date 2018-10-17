using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Dados
    {
        public Boolean Inserir(EquipamentoVO equipamentoVO)
        {
            EquipamentoEntities context = new EquipamentoEntities();
            context.Equipamento.Add(Converte.ToEquipamento(equipamentoVO));
            int row = context.SaveChanges();

            if (row > 1)
                return true;
            else
                return false;
        }
    }
}
