﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Negocio.ServiceCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/ProjetoSeguroWCF.TO")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPFField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Negocio.ServiceCliente.Carro CarroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Negocio.ServiceCliente.Cobertura CoberturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCarroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCoberturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
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
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPF {
            get {
                return this.CPFField;
            }
            set {
                if ((object.ReferenceEquals(this.CPFField, value) != true)) {
                    this.CPFField = value;
                    this.RaisePropertyChanged("CPF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Negocio.ServiceCliente.Carro Carro {
            get {
                return this.CarroField;
            }
            set {
                if ((object.ReferenceEquals(this.CarroField, value) != true)) {
                    this.CarroField = value;
                    this.RaisePropertyChanged("Carro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Negocio.ServiceCliente.Cobertura Cobertura {
            get {
                return this.CoberturaField;
            }
            set {
                if ((object.ReferenceEquals(this.CoberturaField, value) != true)) {
                    this.CoberturaField = value;
                    this.RaisePropertyChanged("Cobertura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCarro {
            get {
                return this.IdCarroField;
            }
            set {
                if ((this.IdCarroField.Equals(value) != true)) {
                    this.IdCarroField = value;
                    this.RaisePropertyChanged("IdCarro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCobertura {
            get {
                return this.IdCoberturaField;
            }
            set {
                if ((this.IdCoberturaField.Equals(value) != true)) {
                    this.IdCoberturaField = value;
                    this.RaisePropertyChanged("IdCobertura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Carro", Namespace="http://schemas.datacontract.org/2004/07/ProjetoSeguroWCF.TO")]
    [System.SerializableAttribute()]
    public partial class Carro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCarroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public int IdCarro {
            get {
                return this.IdCarroField;
            }
            set {
                if ((this.IdCarroField.Equals(value) != true)) {
                    this.IdCarroField = value;
                    this.RaisePropertyChanged("IdCarro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cobertura", Namespace="http://schemas.datacontract.org/2004/07/ProjetoSeguroWCF.TO")]
    [System.SerializableAttribute()]
    public partial class Cobertura : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCoberturaField;
        
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
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCobertura {
            get {
                return this.IdCoberturaField;
            }
            set {
                if ((this.IdCoberturaField.Equals(value) != true)) {
                    this.IdCoberturaField = value;
                    this.RaisePropertyChanged("IdCobertura");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCliente.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Add", ReplyAction="http://tempuri.org/IClienteService/AddResponse")]
        void Add(Negocio.ServiceCliente.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Add", ReplyAction="http://tempuri.org/IClienteService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Negocio.ServiceCliente.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/GetClienteByNome", ReplyAction="http://tempuri.org/IClienteService/GetClienteByNomeResponse")]
        Negocio.ServiceCliente.Cliente GetClienteByNome(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/GetClienteByNome", ReplyAction="http://tempuri.org/IClienteService/GetClienteByNomeResponse")]
        System.Threading.Tasks.Task<Negocio.ServiceCliente.Cliente> GetClienteByNomeAsync(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/GetClienteByCpf", ReplyAction="http://tempuri.org/IClienteService/GetClienteByCpfResponse")]
        Negocio.ServiceCliente.Cliente GetClienteByCpf(string cpf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/GetClienteByCpf", ReplyAction="http://tempuri.org/IClienteService/GetClienteByCpfResponse")]
        System.Threading.Tasks.Task<Negocio.ServiceCliente.Cliente> GetClienteByCpfAsync(string cpf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/GetClienteCotacao", ReplyAction="http://tempuri.org/IClienteService/GetClienteCotacaoResponse")]
        Negocio.ServiceCliente.Cliente[] GetClienteCotacao();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/GetClienteCotacao", ReplyAction="http://tempuri.org/IClienteService/GetClienteCotacaoResponse")]
        System.Threading.Tasks.Task<Negocio.ServiceCliente.Cliente[]> GetClienteCotacaoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : Negocio.ServiceCliente.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<Negocio.ServiceCliente.IClienteService>, Negocio.ServiceCliente.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Add(Negocio.ServiceCliente.Cliente c) {
            base.Channel.Add(c);
        }
        
        public System.Threading.Tasks.Task AddAsync(Negocio.ServiceCliente.Cliente c) {
            return base.Channel.AddAsync(c);
        }
        
        public Negocio.ServiceCliente.Cliente GetClienteByNome(string nome) {
            return base.Channel.GetClienteByNome(nome);
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceCliente.Cliente> GetClienteByNomeAsync(string nome) {
            return base.Channel.GetClienteByNomeAsync(nome);
        }
        
        public Negocio.ServiceCliente.Cliente GetClienteByCpf(string cpf) {
            return base.Channel.GetClienteByCpf(cpf);
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceCliente.Cliente> GetClienteByCpfAsync(string cpf) {
            return base.Channel.GetClienteByCpfAsync(cpf);
        }
        
        public Negocio.ServiceCliente.Cliente[] GetClienteCotacao() {
            return base.Channel.GetClienteCotacao();
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceCliente.Cliente[]> GetClienteCotacaoAsync() {
            return base.Channel.GetClienteCotacaoAsync();
        }
    }
}
