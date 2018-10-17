using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Converte
    {
        public static Equipamento ToEquipamento(EquipamentoVO equipamentoVO)
        {
            return new Equipamento()
            {
                id = equipamentoVO.id,
                nome = equipamentoVO.nome,
                valor = equipamentoVO.valor,
                DataCadastro = equipamentoVO.dataCadastro
            };
        }

        public static EquipamentoVO ToEquipamentoVO(Equipamento equipamento)
        {
            return new EquipamentoVO()
            {
                id = equipamento.id,
                nome = equipamento.nome,
                valor = (decimal)equipamento.valor,
                dataCadastro = (DateTime)equipamento.DataCadastro
            };
        }
    }
}
