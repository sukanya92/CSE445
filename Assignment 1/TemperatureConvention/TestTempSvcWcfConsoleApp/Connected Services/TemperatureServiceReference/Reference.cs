﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestTempSvcWcfConsoleApp.TemperatureServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TemperatureServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/c2f", ReplyAction="http://tempuri.org/IService1/c2fResponse")]
        int c2f(int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/c2f", ReplyAction="http://tempuri.org/IService1/c2fResponse")]
        System.Threading.Tasks.Task<int> c2fAsync(int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/f2c", ReplyAction="http://tempuri.org/IService1/f2cResponse")]
        int f2c(int f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/f2c", ReplyAction="http://tempuri.org/IService1/f2cResponse")]
        System.Threading.Tasks.Task<int> f2cAsync(int f);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TestTempSvcWcfConsoleApp.TemperatureServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TestTempSvcWcfConsoleApp.TemperatureServiceReference.IService1>, TestTempSvcWcfConsoleApp.TemperatureServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public int c2f(int c) {
            return base.Channel.c2f(c);
        }
        
        public System.Threading.Tasks.Task<int> c2fAsync(int c) {
            return base.Channel.c2fAsync(c);
        }
        
        public int f2c(int f) {
            return base.Channel.f2c(f);
        }
        
        public System.Threading.Tasks.Task<int> f2cAsync(int f) {
            return base.Channel.f2cAsync(f);
        }
    }
}
