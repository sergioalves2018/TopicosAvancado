using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidade;
using Persistencia;


namespace ServicoWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Servico" no arquivo de código e configuração ao mesmo tempo.
    public class Servico : IServico
    {
        public int Inserir(LabInfo lab)
        {
            return LabInfoPersis.Salvar(lab); 
        }

        public List<LabInfo> PesquisaLabInfo(int? id, string nome, bool? isprojetor, int? qtdAlunos, int? qtdComputadores
                                              , string sistemaOperacional, string software1, string software2, string software3)
        {
            return LabInfoPersis.FillLabInfo(id, nome,  isprojetor,  qtdAlunos,  qtdComputadores, sistemaOperacional, software1, software2, software3);
        }

        public LabInfo LabInfoStart()
        {
            return new LabInfo();
        }
    }
}
