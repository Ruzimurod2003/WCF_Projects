﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Client_2.Client_Math {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Client_Math.IMath_Service")]
    public interface IMath_Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath_Service/DoWork", ReplyAction="http://tempuri.org/IMath_Service/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath_Service/DoWork", ReplyAction="http://tempuri.org/IMath_Service/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMath_ServiceChannel : WCF_Client_2.Client_Math.IMath_Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Math_ServiceClient : System.ServiceModel.ClientBase<WCF_Client_2.Client_Math.IMath_Service>, WCF_Client_2.Client_Math.IMath_Service {
        
        public Math_ServiceClient() {
        }
        
        public Math_ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Math_ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Math_ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Math_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
    }
}
