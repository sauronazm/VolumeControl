﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VolumeControl.Client.VolumeControlService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VolumeControlService.IVolumeControlWCFService")]
    public interface IVolumeControlWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVolumeControlWCFService/MuteOrUnmute", ReplyAction="http://tempuri.org/IVolumeControlWCFService/MuteOrUnmuteResponse")]
        void MuteOrUnmute();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVolumeControlWCFServiceChannel : VolumeControl.Client.VolumeControlService.IVolumeControlWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VolumeControlWCFServiceClient : System.ServiceModel.ClientBase<VolumeControl.Client.VolumeControlService.IVolumeControlWCFService>, VolumeControl.Client.VolumeControlService.IVolumeControlWCFService {
        
        public VolumeControlWCFServiceClient() {
        }
        
        public VolumeControlWCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VolumeControlWCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VolumeControlWCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VolumeControlWCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void MuteOrUnmute() {
            base.Channel.MuteOrUnmute();
        }
    }
}