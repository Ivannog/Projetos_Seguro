﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Negocio.ServiceCarro {
    using System.Runtime.Serialization;
    using System;
    
    
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCarro.ICarroService")]
    public interface ICarroService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarroService/ListCar", ReplyAction="http://tempuri.org/ICarroService/ListCarResponse")]
        Negocio.ServiceCarro.Carro[] ListCar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarroService/ListCar", ReplyAction="http://tempuri.org/ICarroService/ListCarResponse")]
        System.Threading.Tasks.Task<Negocio.ServiceCarro.Carro[]> ListCarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarroServiceChannel : Negocio.ServiceCarro.ICarroService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarroServiceClient : System.ServiceModel.ClientBase<Negocio.ServiceCarro.ICarroService>, Negocio.ServiceCarro.ICarroService {
        
        public CarroServiceClient() {
        }
        
        public CarroServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarroServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarroServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarroServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Negocio.ServiceCarro.Carro[] ListCar() {
            return base.Channel.ListCar();
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceCarro.Carro[]> ListCarAsync() {
            return base.Channel.ListCarAsync();
        }
    }
}
