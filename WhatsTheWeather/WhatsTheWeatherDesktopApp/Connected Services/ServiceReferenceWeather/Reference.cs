﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhatsTheWeatherDesktopApp.ServiceReferenceWeather {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceWeather.WeatherServiceASMXSoap")]
    public interface WeatherServiceASMXSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldResponse HelloWorld(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldResponse> HelloWorldAsync(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name city from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWeatherInfo", ReplyAction="*")]
        WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoResponse GetWeatherInfo(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWeatherInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoResponse> GetWeatherInfoAsync(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWeatherInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWeatherInfo", Namespace="http://tempuri.org/", Order=0)]
        public WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequestBody Body;
        
        public GetWeatherInfoRequest() {
        }
        
        public GetWeatherInfoRequest(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWeatherInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string city;
        
        public GetWeatherInfoRequestBody() {
        }
        
        public GetWeatherInfoRequestBody(string city) {
            this.city = city;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWeatherInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWeatherInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoResponseBody Body;
        
        public GetWeatherInfoResponse() {
        }
        
        public GetWeatherInfoResponse(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetWeatherInfoResponseBody {
        
        public GetWeatherInfoResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WeatherServiceASMXSoapChannel : WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceASMXSoapClient : System.ServiceModel.ClientBase<WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap>, WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap {
        
        public WeatherServiceASMXSoapClient() {
        }
        
        public WeatherServiceASMXSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServiceASMXSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceASMXSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceASMXSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldResponse WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap.HelloWorld(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequest inValue = new WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequest();
            inValue.Body = new WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequestBody();
            WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldResponse retVal = ((WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldResponse> WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap.HelloWorldAsync(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldResponse> HelloWorldAsync() {
            WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequest inValue = new WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequest();
            inValue.Body = new WhatsTheWeatherDesktopApp.ServiceReferenceWeather.HelloWorldRequestBody();
            return ((WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoResponse WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap.GetWeatherInfo(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequest request) {
            return base.Channel.GetWeatherInfo(request);
        }
        
        public void GetWeatherInfo(string city) {
            WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequest inValue = new WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequest();
            inValue.Body = new WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequestBody();
            inValue.Body.city = city;
            WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoResponse retVal = ((WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap)(this)).GetWeatherInfo(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoResponse> WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap.GetWeatherInfoAsync(WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequest request) {
            return base.Channel.GetWeatherInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoResponse> GetWeatherInfoAsync(string city) {
            WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequest inValue = new WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequest();
            inValue.Body = new WhatsTheWeatherDesktopApp.ServiceReferenceWeather.GetWeatherInfoRequestBody();
            inValue.Body.city = city;
            return ((WhatsTheWeatherDesktopApp.ServiceReferenceWeather.WeatherServiceASMXSoap)(this)).GetWeatherInfoAsync(inValue);
        }
    }
}
