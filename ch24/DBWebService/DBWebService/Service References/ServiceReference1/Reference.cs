﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBWebService.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SelectBook();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectBook", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectBookAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void InsertBook(string 書號, string 書名, int 單價, int 數量);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertBook", ReplyAction="*")]
        System.Threading.Tasks.Task InsertBookAsync(string 書號, string 書名, int 單價, int 數量);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateBook(string 書號, string 書名, int 單價, int 數量);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateBook", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateBookAsync(string 書號, string 書名, int 單價, int 數量);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void DeleteBook(string 書號);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteBook", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteBookAsync(string 書號);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : DBWebService.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<DBWebService.ServiceReference1.WebService1Soap>, DBWebService.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet SelectBook() {
            return base.Channel.SelectBook();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectBookAsync() {
            return base.Channel.SelectBookAsync();
        }
        
        public void InsertBook(string 書號, string 書名, int 單價, int 數量) {
            base.Channel.InsertBook(書號, 書名, 單價, 數量);
        }
        
        public System.Threading.Tasks.Task InsertBookAsync(string 書號, string 書名, int 單價, int 數量) {
            return base.Channel.InsertBookAsync(書號, 書名, 單價, 數量);
        }
        
        public void UpdateBook(string 書號, string 書名, int 單價, int 數量) {
            base.Channel.UpdateBook(書號, 書名, 單價, 數量);
        }
        
        public System.Threading.Tasks.Task UpdateBookAsync(string 書號, string 書名, int 單價, int 數量) {
            return base.Channel.UpdateBookAsync(書號, 書名, 單價, 數量);
        }
        
        public void DeleteBook(string 書號) {
            base.Channel.DeleteBook(書號);
        }
        
        public System.Threading.Tasks.Task DeleteBookAsync(string 書號) {
            return base.Channel.DeleteBookAsync(書號);
        }
    }
}