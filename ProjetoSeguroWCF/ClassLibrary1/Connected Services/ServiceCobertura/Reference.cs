﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.27703.1
// 
namespace ClassLibrary1.ServiceCobertura {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cobertura", Namespace="http://schemas.datacontract.org/2004/07/ProjetoSeguroWCF.TO")]
    public partial class Cobertura : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string DescricaoField;
        
        private int IdCoberturaField;
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCobertura.ICoberturaService")]
    public interface ICoberturaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICoberturaService/ListCoberturas", ReplyAction="http://tempuri.org/ICoberturaService/ListCoberturasResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClassLibrary1.ServiceCobertura.Cobertura>> ListCoberturasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICoberturaServiceChannel : ClassLibrary1.ServiceCobertura.ICoberturaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CoberturaServiceClient : System.ServiceModel.ClientBase<ClassLibrary1.ServiceCobertura.ICoberturaService>, ClassLibrary1.ServiceCobertura.ICoberturaService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CoberturaServiceClient() : 
                base(CoberturaServiceClient.GetDefaultBinding(), CoberturaServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.EndCobertura.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CoberturaServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CoberturaServiceClient.GetBindingForEndpoint(endpointConfiguration), CoberturaServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CoberturaServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CoberturaServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CoberturaServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CoberturaServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CoberturaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClassLibrary1.ServiceCobertura.Cobertura>> ListCoberturasAsync() {
            return base.Channel.ListCoberturasAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.EndCobertura)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.EndCobertura)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:46815/CoberturaService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return CoberturaServiceClient.GetBindingForEndpoint(EndpointConfiguration.EndCobertura);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return CoberturaServiceClient.GetEndpointAddress(EndpointConfiguration.EndCobertura);
        }
        
        public enum EndpointConfiguration {
            
            EndCobertura,
        }
    }
}
