﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstoqueMVC.EstoqueServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/EstoqueWCF")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long quantidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double valorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long quantidade {
            get {
                return this.quantidadeField;
            }
            set {
                if ((this.quantidadeField.Equals(value) != true)) {
                    this.quantidadeField = value;
                    this.RaisePropertyChanged("quantidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double valor {
            get {
                return this.valorField;
            }
            set {
                if ((this.valorField.Equals(value) != true)) {
                    this.valorField = value;
                    this.RaisePropertyChanged("valor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EstoqueServiceReference.IEstoqueService")]
    public interface IEstoqueService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/encontraTodos", ReplyAction="http://tempuri.org/IEstoqueService/encontraTodosResponse")]
        EstoqueMVC.EstoqueServiceReference.Produto[] encontraTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/encontraTodos", ReplyAction="http://tempuri.org/IEstoqueService/encontraTodosResponse")]
        System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto[]> encontraTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/encontra", ReplyAction="http://tempuri.org/IEstoqueService/encontraResponse")]
        EstoqueMVC.EstoqueServiceReference.Produto encontra(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/encontra", ReplyAction="http://tempuri.org/IEstoqueService/encontraResponse")]
        System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> encontraAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/novo", ReplyAction="http://tempuri.org/IEstoqueService/novoResponse")]
        EstoqueMVC.EstoqueServiceReference.Produto novo(EstoqueMVC.EstoqueServiceReference.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/novo", ReplyAction="http://tempuri.org/IEstoqueService/novoResponse")]
        System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> novoAsync(EstoqueMVC.EstoqueServiceReference.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/atualiza", ReplyAction="http://tempuri.org/IEstoqueService/atualizaResponse")]
        EstoqueMVC.EstoqueServiceReference.Produto atualiza(EstoqueMVC.EstoqueServiceReference.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/atualiza", ReplyAction="http://tempuri.org/IEstoqueService/atualizaResponse")]
        System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> atualizaAsync(EstoqueMVC.EstoqueServiceReference.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/deletaID", ReplyAction="http://tempuri.org/IEstoqueService/deletaIDResponse")]
        EstoqueMVC.EstoqueServiceReference.Produto deletaID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/deletaID", ReplyAction="http://tempuri.org/IEstoqueService/deletaIDResponse")]
        System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> deletaIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/deleta", ReplyAction="http://tempuri.org/IEstoqueService/deletaResponse")]
        EstoqueMVC.EstoqueServiceReference.Produto deleta(EstoqueMVC.EstoqueServiceReference.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/deleta", ReplyAction="http://tempuri.org/IEstoqueService/deletaResponse")]
        System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> deletaAsync(EstoqueMVC.EstoqueServiceReference.Produto produto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstoqueServiceChannel : EstoqueMVC.EstoqueServiceReference.IEstoqueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstoqueServiceClient : System.ServiceModel.ClientBase<EstoqueMVC.EstoqueServiceReference.IEstoqueService>, EstoqueMVC.EstoqueServiceReference.IEstoqueService {
        
        public EstoqueServiceClient() {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstoqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EstoqueMVC.EstoqueServiceReference.Produto[] encontraTodos() {
            return base.Channel.encontraTodos();
        }
        
        public System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto[]> encontraTodosAsync() {
            return base.Channel.encontraTodosAsync();
        }
        
        public EstoqueMVC.EstoqueServiceReference.Produto encontra(int id) {
            return base.Channel.encontra(id);
        }
        
        public System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> encontraAsync(int id) {
            return base.Channel.encontraAsync(id);
        }
        
        public EstoqueMVC.EstoqueServiceReference.Produto novo(EstoqueMVC.EstoqueServiceReference.Produto produto) {
            return base.Channel.novo(produto);
        }
        
        public System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> novoAsync(EstoqueMVC.EstoqueServiceReference.Produto produto) {
            return base.Channel.novoAsync(produto);
        }
        
        public EstoqueMVC.EstoqueServiceReference.Produto atualiza(EstoqueMVC.EstoqueServiceReference.Produto produto) {
            return base.Channel.atualiza(produto);
        }
        
        public System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> atualizaAsync(EstoqueMVC.EstoqueServiceReference.Produto produto) {
            return base.Channel.atualizaAsync(produto);
        }
        
        public EstoqueMVC.EstoqueServiceReference.Produto deletaID(int id) {
            return base.Channel.deletaID(id);
        }
        
        public System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> deletaIDAsync(int id) {
            return base.Channel.deletaIDAsync(id);
        }
        
        public EstoqueMVC.EstoqueServiceReference.Produto deleta(EstoqueMVC.EstoqueServiceReference.Produto produto) {
            return base.Channel.deleta(produto);
        }
        
        public System.Threading.Tasks.Task<EstoqueMVC.EstoqueServiceReference.Produto> deletaAsync(EstoqueMVC.EstoqueServiceReference.Produto produto) {
            return base.Channel.deletaAsync(produto);
        }
    }
}
