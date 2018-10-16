﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webLabInfo.ServicoCrud {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicoCrud.IServico")]
    public interface IServico {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/Inserir", ReplyAction="http://tempuri.org/IServico/InserirResponse")]
        int Inserir(Entidade.LabInfo lab);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/Inserir", ReplyAction="http://tempuri.org/IServico/InserirResponse")]
        System.Threading.Tasks.Task<int> InserirAsync(Entidade.LabInfo lab);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/PesquisaLabInfo", ReplyAction="http://tempuri.org/IServico/PesquisaLabInfoResponse")]
        Entidade.LabInfo[] PesquisaLabInfo(System.Nullable<int> id, string nome, System.Nullable<bool> isprojetor, System.Nullable<int> qtdAlunos, System.Nullable<int> qtdComputadores, string sistemaOperacional, string software1, string software2, string software3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/PesquisaLabInfo", ReplyAction="http://tempuri.org/IServico/PesquisaLabInfoResponse")]
        System.Threading.Tasks.Task<Entidade.LabInfo[]> PesquisaLabInfoAsync(System.Nullable<int> id, string nome, System.Nullable<bool> isprojetor, System.Nullable<int> qtdAlunos, System.Nullable<int> qtdComputadores, string sistemaOperacional, string software1, string software2, string software3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/LabInfoStart", ReplyAction="http://tempuri.org/IServico/LabInfoStartResponse")]
        Entidade.LabInfo LabInfoStart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/LabInfoStart", ReplyAction="http://tempuri.org/IServico/LabInfoStartResponse")]
        System.Threading.Tasks.Task<Entidade.LabInfo> LabInfoStartAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoChannel : webLabInfo.ServicoCrud.IServico, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoClient : System.ServiceModel.ClientBase<webLabInfo.ServicoCrud.IServico>, webLabInfo.ServicoCrud.IServico {
        
        public ServicoClient() {
        }
        
        public ServicoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Inserir(Entidade.LabInfo lab) {
            return base.Channel.Inserir(lab);
        }
        
        public System.Threading.Tasks.Task<int> InserirAsync(Entidade.LabInfo lab) {
            return base.Channel.InserirAsync(lab);
        }
        
        public Entidade.LabInfo[] PesquisaLabInfo(System.Nullable<int> id, string nome, System.Nullable<bool> isprojetor, System.Nullable<int> qtdAlunos, System.Nullable<int> qtdComputadores, string sistemaOperacional, string software1, string software2, string software3) {
            return base.Channel.PesquisaLabInfo(id, nome, isprojetor, qtdAlunos, qtdComputadores, sistemaOperacional, software1, software2, software3);
        }
        
        public System.Threading.Tasks.Task<Entidade.LabInfo[]> PesquisaLabInfoAsync(System.Nullable<int> id, string nome, System.Nullable<bool> isprojetor, System.Nullable<int> qtdAlunos, System.Nullable<int> qtdComputadores, string sistemaOperacional, string software1, string software2, string software3) {
            return base.Channel.PesquisaLabInfoAsync(id, nome, isprojetor, qtdAlunos, qtdComputadores, sistemaOperacional, software1, software2, software3);
        }
        
        public Entidade.LabInfo LabInfoStart() {
            return base.Channel.LabInfoStart();
        }
        
        public System.Threading.Tasks.Task<Entidade.LabInfo> LabInfoStartAsync() {
            return base.Channel.LabInfoStartAsync();
        }
    }
}
