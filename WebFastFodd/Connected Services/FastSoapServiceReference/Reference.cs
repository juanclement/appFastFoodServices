﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastSoapServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/AppFastFoodService.Model")]
    public partial class Cliente : object
    {
        
        private string ApellidosField;
        
        private string ContraseniaField;
        
        private string DireccionField;
        
        private string DocIdField;
        
        private string EmailField;
        
        private System.Nullable<System.DateTime> FechaCreacionField;
        
        private System.Nullable<System.DateTime> FechaModifacionField;
        
        private System.Nullable<System.DateTime> FechaNacField;
        
        private int IdClienteField;
        
        private string IdDepartamentoField;
        
        private string IdDistritoField;
        
        private string IdProvinciaField;
        
        private string IndAutorizaDatoField;
        
        private string NombresField;
        
        private string NumerocelularField;
        
        private string TipoDocIdField;
        
        private string UsuarioCreacionField;
        
        private string UsuarioModificacionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellidos
        {
            get
            {
                return this.ApellidosField;
            }
            set
            {
                this.ApellidosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contrasenia
        {
            get
            {
                return this.ContraseniaField;
            }
            set
            {
                this.ContraseniaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion
        {
            get
            {
                return this.DireccionField;
            }
            set
            {
                this.DireccionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocId
        {
            get
            {
                return this.DocIdField;
            }
            set
            {
                this.DocIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaCreacion
        {
            get
            {
                return this.FechaCreacionField;
            }
            set
            {
                this.FechaCreacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaModifacion
        {
            get
            {
                return this.FechaModifacionField;
            }
            set
            {
                this.FechaModifacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaNac
        {
            get
            {
                return this.FechaNacField;
            }
            set
            {
                this.FechaNacField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCliente
        {
            get
            {
                return this.IdClienteField;
            }
            set
            {
                this.IdClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDepartamento
        {
            get
            {
                return this.IdDepartamentoField;
            }
            set
            {
                this.IdDepartamentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDistrito
        {
            get
            {
                return this.IdDistritoField;
            }
            set
            {
                this.IdDistritoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdProvincia
        {
            get
            {
                return this.IdProvinciaField;
            }
            set
            {
                this.IdProvinciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IndAutorizaDato
        {
            get
            {
                return this.IndAutorizaDatoField;
            }
            set
            {
                this.IndAutorizaDatoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres
        {
            get
            {
                return this.NombresField;
            }
            set
            {
                this.NombresField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numerocelular
        {
            get
            {
                return this.NumerocelularField;
            }
            set
            {
                this.NumerocelularField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDocId
        {
            get
            {
                return this.TipoDocIdField;
            }
            set
            {
                this.TipoDocIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioCreacion
        {
            get
            {
                return this.UsuarioCreacionField;
            }
            set
            {
                this.UsuarioCreacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioModificacion
        {
            get
            {
                return this.UsuarioModificacionField;
            }
            set
            {
                this.UsuarioModificacionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PedidoFastFood", Namespace="http://schemas.datacontract.org/2004/07/AppFastFoodService.Model")]
    public partial class PedidoFastFood : object
    {
        
        private string CodigoPedidoField;
        
        private System.Nullable<System.DateTime> FechaEntregaField;
        
        private System.DateTime FechaPedidoField;
        
        private int IdClienteField;
        
        private string IdEstadoPedidoField;
        
        private int IdProveedorField;
        
        private decimal ImporteTotField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoPedido
        {
            get
            {
                return this.CodigoPedidoField;
            }
            set
            {
                this.CodigoPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaEntrega
        {
            get
            {
                return this.FechaEntregaField;
            }
            set
            {
                this.FechaEntregaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaPedido
        {
            get
            {
                return this.FechaPedidoField;
            }
            set
            {
                this.FechaPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCliente
        {
            get
            {
                return this.IdClienteField;
            }
            set
            {
                this.IdClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdEstadoPedido
        {
            get
            {
                return this.IdEstadoPedidoField;
            }
            set
            {
                this.IdEstadoPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProveedor
        {
            get
            {
                return this.IdProveedorField;
            }
            set
            {
                this.IdProveedorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ImporteTot
        {
            get
            {
                return this.ImporteTotField;
            }
            set
            {
                this.ImporteTotField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FastSoapServiceReference.IPedidosFastFoodServices")]
    public interface IPedidosFastFoodServices
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidosFastFoodServices/registrarcliente", ReplyAction="http://tempuri.org/IPedidosFastFoodServices/registrarclienteResponse")]
        System.Threading.Tasks.Task<FastSoapServiceReference.Cliente> registrarclienteAsync(FastSoapServiceReference.Cliente objcliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidosFastFoodServices/registrarPedido", ReplyAction="http://tempuri.org/IPedidosFastFoodServices/registrarPedidoResponse")]
        System.Threading.Tasks.Task<FastSoapServiceReference.PedidoFastFood> registrarPedidoAsync(FastSoapServiceReference.PedidoFastFood pedidoFastFood);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidosFastFoodServices/listaPedidos", ReplyAction="http://tempuri.org/IPedidosFastFoodServices/listaPedidosResponse")]
        System.Threading.Tasks.Task<FastSoapServiceReference.PedidoFastFood[]> listaPedidosAsync(int idcliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidosFastFoodServices/actualizarEstadoPedido", ReplyAction="http://tempuri.org/IPedidosFastFoodServices/actualizarEstadoPedidoResponse")]
        System.Threading.Tasks.Task<FastSoapServiceReference.PedidoFastFood> actualizarEstadoPedidoAsync(FastSoapServiceReference.PedidoFastFood pedidoFastFood);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IPedidosFastFoodServicesChannel : FastSoapServiceReference.IPedidosFastFoodServices, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class PedidosFastFoodServicesClient : System.ServiceModel.ClientBase<FastSoapServiceReference.IPedidosFastFoodServices>, FastSoapServiceReference.IPedidosFastFoodServices
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PedidosFastFoodServicesClient() : 
                base(PedidosFastFoodServicesClient.GetDefaultBinding(), PedidosFastFoodServicesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPedidosFastFoodServices.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PedidosFastFoodServicesClient(EndpointConfiguration endpointConfiguration) : 
                base(PedidosFastFoodServicesClient.GetBindingForEndpoint(endpointConfiguration), PedidosFastFoodServicesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PedidosFastFoodServicesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PedidosFastFoodServicesClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PedidosFastFoodServicesClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PedidosFastFoodServicesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PedidosFastFoodServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<FastSoapServiceReference.Cliente> registrarclienteAsync(FastSoapServiceReference.Cliente objcliente)
        {
            return base.Channel.registrarclienteAsync(objcliente);
        }
        
        public System.Threading.Tasks.Task<FastSoapServiceReference.PedidoFastFood> registrarPedidoAsync(FastSoapServiceReference.PedidoFastFood pedidoFastFood)
        {
            return base.Channel.registrarPedidoAsync(pedidoFastFood);
        }
        
        public System.Threading.Tasks.Task<FastSoapServiceReference.PedidoFastFood[]> listaPedidosAsync(int idcliente)
        {
            return base.Channel.listaPedidosAsync(idcliente);
        }
        
        public System.Threading.Tasks.Task<FastSoapServiceReference.PedidoFastFood> actualizarEstadoPedidoAsync(FastSoapServiceReference.PedidoFastFood pedidoFastFood)
        {
            return base.Channel.actualizarEstadoPedidoAsync(pedidoFastFood);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPedidosFastFoodServices))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPedidosFastFoodServices))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:65518/PedidosFastFoodServices.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PedidosFastFoodServicesClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPedidosFastFoodServices);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PedidosFastFoodServicesClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPedidosFastFoodServices);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPedidosFastFoodServices,
        }
    }
}