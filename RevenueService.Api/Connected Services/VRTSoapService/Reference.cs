﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VRTSoapService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="vrt", Namespace="https://rdws.rd.go.th/serviceRD3/vrtserviceRD3")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(VRTSoapService.ArrayOfAnyType))]
    public partial class vrt : object
    {
        
        private VRTSoapService.ArrayOfAnyType vBusinessNameField;
        
        private VRTSoapService.ArrayOfAnyType vBusinessTypeNameField;
        
        private VRTSoapService.ArrayOfAnyType vShopNameField;
        
        private VRTSoapService.ArrayOfAnyType vHouseNumberField;
        
        private VRTSoapService.ArrayOfAnyType vStreetNameField;
        
        private VRTSoapService.ArrayOfAnyType vThambolNameField;
        
        private VRTSoapService.ArrayOfAnyType vAmphurNameField;
        
        private VRTSoapService.ArrayOfAnyType vProvinceNameField;
        
        private VRTSoapService.ArrayOfAnyType vPostCodeField;
        
        private VRTSoapService.ArrayOfAnyType vmsgerrField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public VRTSoapService.ArrayOfAnyType vBusinessName
        {
            get
            {
                return this.vBusinessNameField;
            }
            set
            {
                this.vBusinessNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public VRTSoapService.ArrayOfAnyType vBusinessTypeName
        {
            get
            {
                return this.vBusinessTypeNameField;
            }
            set
            {
                this.vBusinessTypeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public VRTSoapService.ArrayOfAnyType vShopName
        {
            get
            {
                return this.vShopNameField;
            }
            set
            {
                this.vShopNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public VRTSoapService.ArrayOfAnyType vHouseNumber
        {
            get
            {
                return this.vHouseNumberField;
            }
            set
            {
                this.vHouseNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public VRTSoapService.ArrayOfAnyType vStreetName
        {
            get
            {
                return this.vStreetNameField;
            }
            set
            {
                this.vStreetNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public VRTSoapService.ArrayOfAnyType vThambolName
        {
            get
            {
                return this.vThambolNameField;
            }
            set
            {
                this.vThambolNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public VRTSoapService.ArrayOfAnyType vAmphurName
        {
            get
            {
                return this.vAmphurNameField;
            }
            set
            {
                this.vAmphurNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public VRTSoapService.ArrayOfAnyType vProvinceName
        {
            get
            {
                return this.vProvinceNameField;
            }
            set
            {
                this.vProvinceNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public VRTSoapService.ArrayOfAnyType vPostCode
        {
            get
            {
                return this.vPostCodeField;
            }
            set
            {
                this.vPostCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public VRTSoapService.ArrayOfAnyType vmsgerr
        {
            get
            {
                return this.vmsgerrField;
            }
            set
            {
                this.vmsgerrField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfAnyType", Namespace="https://rdws.rd.go.th/serviceRD3/vrtserviceRD3", ItemName="anyType")]
    public class ArrayOfAnyType : System.Collections.Generic.List<object>
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://rdws.rd.go.th/serviceRD3/vrtserviceRD3", ConfigurationName="VRTSoapService.vrtserviceRD3Soap")]
    public interface vrtserviceRD3Soap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://rdws.rd.go.th/serviceRD3/vrtserviceRD3/Service", ReplyAction="*")]
        System.Threading.Tasks.Task<VRTSoapService.ServiceResponse> ServiceAsync(VRTSoapService.ServiceRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Service", Namespace="https://rdws.rd.go.th/serviceRD3/vrtserviceRD3", Order=0)]
        public VRTSoapService.ServiceRequestBody Body;
        
        public ServiceRequest()
        {
        }
        
        public ServiceRequest(VRTSoapService.ServiceRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://rdws.rd.go.th/serviceRD3/vrtserviceRD3")]
    public partial class ServiceRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ShopName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string BusinessTypeCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int ProvinceCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int StreetCode;
        
        public ServiceRequestBody()
        {
        }
        
        public ServiceRequestBody(string username, string password, string ShopName, string BusinessTypeCode, int ProvinceCode, int StreetCode)
        {
            this.username = username;
            this.password = password;
            this.ShopName = ShopName;
            this.BusinessTypeCode = BusinessTypeCode;
            this.ProvinceCode = ProvinceCode;
            this.StreetCode = StreetCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceResponse", Namespace="https://rdws.rd.go.th/serviceRD3/vrtserviceRD3", Order=0)]
        public VRTSoapService.ServiceResponseBody Body;
        
        public ServiceResponse()
        {
        }
        
        public ServiceResponse(VRTSoapService.ServiceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://rdws.rd.go.th/serviceRD3/vrtserviceRD3")]
    public partial class ServiceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public VRTSoapService.vrt ServiceResult;
        
        public ServiceResponseBody()
        {
        }
        
        public ServiceResponseBody(VRTSoapService.vrt ServiceResult)
        {
            this.ServiceResult = ServiceResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface vrtserviceRD3SoapChannel : VRTSoapService.vrtserviceRD3Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class vrtserviceRD3SoapClient : System.ServiceModel.ClientBase<VRTSoapService.vrtserviceRD3Soap>, VRTSoapService.vrtserviceRD3Soap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public vrtserviceRD3SoapClient() : 
                base(vrtserviceRD3SoapClient.GetDefaultBinding(), vrtserviceRD3SoapClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.vrtserviceRD3Soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public vrtserviceRD3SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(vrtserviceRD3SoapClient.GetBindingForEndpoint(endpointConfiguration), vrtserviceRD3SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public vrtserviceRD3SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(vrtserviceRD3SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public vrtserviceRD3SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(vrtserviceRD3SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public vrtserviceRD3SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VRTSoapService.ServiceResponse> VRTSoapService.vrtserviceRD3Soap.ServiceAsync(VRTSoapService.ServiceRequest request)
        {
            return base.Channel.ServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<VRTSoapService.ServiceResponse> ServiceAsync(string username, string password, string ShopName, string BusinessTypeCode, int ProvinceCode, int StreetCode)
        {
            VRTSoapService.ServiceRequest inValue = new VRTSoapService.ServiceRequest();
            inValue.Body = new VRTSoapService.ServiceRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.ShopName = ShopName;
            inValue.Body.BusinessTypeCode = BusinessTypeCode;
            inValue.Body.ProvinceCode = ProvinceCode;
            inValue.Body.StreetCode = StreetCode;
            return ((VRTSoapService.vrtserviceRD3Soap)(this)).ServiceAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.vrtserviceRD3Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.vrtserviceRD3Soap))
            {
                return new System.ServiceModel.EndpointAddress("https://rdws.rd.go.th/serviceRD3/vrtserviceRD3.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return vrtserviceRD3SoapClient.GetBindingForEndpoint(EndpointConfiguration.vrtserviceRD3Soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return vrtserviceRD3SoapClient.GetEndpointAddress(EndpointConfiguration.vrtserviceRD3Soap);
        }
        
        public enum EndpointConfiguration
        {
            
            vrtserviceRD3Soap,
        }
    }
}