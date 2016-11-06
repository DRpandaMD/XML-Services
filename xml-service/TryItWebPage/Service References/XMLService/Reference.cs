﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryItWebPage.XMLService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="XMLService.IXmlService")]
    public interface IXmlService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IXmlService/generateHtml", ReplyAction="http://tempuri.org/IXmlService/generateHtmlResponse")]
        string generateHtml(string xmlURL, string xslURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IXmlService/generateHtml", ReplyAction="http://tempuri.org/IXmlService/generateHtmlResponse")]
        System.Threading.Tasks.Task<string> generateHtmlAsync(string xmlURL, string xslURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IXmlService/validateXML", ReplyAction="http://tempuri.org/IXmlService/validateXMLResponse")]
        string validateXML(string xmlURL, string xsdURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IXmlService/validateXML", ReplyAction="http://tempuri.org/IXmlService/validateXMLResponse")]
        System.Threading.Tasks.Task<string> validateXMLAsync(string xmlURL, string xsdURL);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IXmlServiceChannel : TryItWebPage.XMLService.IXmlService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XmlServiceClient : System.ServiceModel.ClientBase<TryItWebPage.XMLService.IXmlService>, TryItWebPage.XMLService.IXmlService {
        
        public XmlServiceClient() {
        }
        
        public XmlServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public XmlServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public XmlServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public XmlServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string generateHtml(string xmlURL, string xslURL) {
            return base.Channel.generateHtml(xmlURL, xslURL);
        }
        
        public System.Threading.Tasks.Task<string> generateHtmlAsync(string xmlURL, string xslURL) {
            return base.Channel.generateHtmlAsync(xmlURL, xslURL);
        }
        
        public string validateXML(string xmlURL, string xsdURL) {
            return base.Channel.validateXML(xmlURL, xsdURL);
        }
        
        public System.Threading.Tasks.Task<string> validateXMLAsync(string xmlURL, string xsdURL) {
            return base.Channel.validateXMLAsync(xmlURL, xsdURL);
        }
    }
}