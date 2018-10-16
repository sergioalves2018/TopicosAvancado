using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidade;

namespace ServicoWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IServico" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        int Inserir(LabInfo lab);

        [OperationContract]
        List<LabInfo> PesquisaLabInfo(int? id, string nome, bool? isprojetor, int? qtdAlunos, int? qtdComputadores
                            , string sistemaOperacional, string software1, string software2, string software3);

        [OperationContract]
        LabInfo LabInfoStart();
    }
}
