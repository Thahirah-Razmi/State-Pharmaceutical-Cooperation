﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace State_Pharmaceutical_Cooperation_Client.DrugServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DrugServiceReference.DrugWebServiceSoap")]
    public interface DrugWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoDrugID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AutoDrugID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoDrugID", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AutoDrugIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getDrugName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getDrugNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getDrugId(string DrugName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugId", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getDrugIdAsync(string DrugName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertDrug", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string insertDrug(string DrugID, string DrugName, string SupplierID, string Description, string Price, string Stock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertDrug", ReplyAction="*")]
        System.Threading.Tasks.Task<string> insertDrugAsync(string DrugID, string DrugName, string SupplierID, string Description, string Price, string Stock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSupplierName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getSupplierName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSupplierName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getSupplierNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSupplierId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getSupplierId(string SupplierName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSupplierId", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getSupplierIdAsync(string SupplierName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateStock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool UpdateStock(string DrugID, int newStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateStock", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> UpdateStockAsync(string DrugID, int newStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckStock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int CheckStock(string DrugID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckStock", ReplyAction="*")]
        System.Threading.Tasks.Task<int> CheckStockAsync(string DrugID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchDrug", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SearchDrug(string DrugID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchDrug", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchDrugAsync(string DrugID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoOrderID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AutoOrderID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoOrderID", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AutoOrderIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PlaceOrder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string PlaceOrder(string OrderID, string DrugID, int Quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PlaceOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<string> PlaceOrderAsync(string OrderID, string DrugID, int Quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchDrugByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SearchDrugByName(string DrugName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchDrugByName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchDrugByNameAsync(string DrugName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrders", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrders", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetOrdersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DrugWebServiceSoapChannel : State_Pharmaceutical_Cooperation_Client.DrugServiceReference.DrugWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DrugWebServiceSoapClient : System.ServiceModel.ClientBase<State_Pharmaceutical_Cooperation_Client.DrugServiceReference.DrugWebServiceSoap>, State_Pharmaceutical_Cooperation_Client.DrugServiceReference.DrugWebServiceSoap {
        
        public DrugWebServiceSoapClient() {
        }
        
        public DrugWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DrugWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DrugWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DrugWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AutoDrugID() {
            return base.Channel.AutoDrugID();
        }
        
        public System.Threading.Tasks.Task<string> AutoDrugIDAsync() {
            return base.Channel.AutoDrugIDAsync();
        }
        
        public System.Data.DataSet getDrugName() {
            return base.Channel.getDrugName();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getDrugNameAsync() {
            return base.Channel.getDrugNameAsync();
        }
        
        public string getDrugId(string DrugName) {
            return base.Channel.getDrugId(DrugName);
        }
        
        public System.Threading.Tasks.Task<string> getDrugIdAsync(string DrugName) {
            return base.Channel.getDrugIdAsync(DrugName);
        }
        
        public string insertDrug(string DrugID, string DrugName, string SupplierID, string Description, string Price, string Stock) {
            return base.Channel.insertDrug(DrugID, DrugName, SupplierID, Description, Price, Stock);
        }
        
        public System.Threading.Tasks.Task<string> insertDrugAsync(string DrugID, string DrugName, string SupplierID, string Description, string Price, string Stock) {
            return base.Channel.insertDrugAsync(DrugID, DrugName, SupplierID, Description, Price, Stock);
        }
        
        public System.Data.DataSet getSupplierName() {
            return base.Channel.getSupplierName();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getSupplierNameAsync() {
            return base.Channel.getSupplierNameAsync();
        }
        
        public string getSupplierId(string SupplierName) {
            return base.Channel.getSupplierId(SupplierName);
        }
        
        public System.Threading.Tasks.Task<string> getSupplierIdAsync(string SupplierName) {
            return base.Channel.getSupplierIdAsync(SupplierName);
        }
        
        public bool UpdateStock(string DrugID, int newStock) {
            return base.Channel.UpdateStock(DrugID, newStock);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateStockAsync(string DrugID, int newStock) {
            return base.Channel.UpdateStockAsync(DrugID, newStock);
        }
        
        public int CheckStock(string DrugID) {
            return base.Channel.CheckStock(DrugID);
        }
        
        public System.Threading.Tasks.Task<int> CheckStockAsync(string DrugID) {
            return base.Channel.CheckStockAsync(DrugID);
        }
        
        public System.Data.DataSet SearchDrug(string DrugID) {
            return base.Channel.SearchDrug(DrugID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchDrugAsync(string DrugID) {
            return base.Channel.SearchDrugAsync(DrugID);
        }
        
        public string AutoOrderID() {
            return base.Channel.AutoOrderID();
        }
        
        public System.Threading.Tasks.Task<string> AutoOrderIDAsync() {
            return base.Channel.AutoOrderIDAsync();
        }
        
        public string PlaceOrder(string OrderID, string DrugID, int Quantity) {
            return base.Channel.PlaceOrder(OrderID, DrugID, Quantity);
        }
        
        public System.Threading.Tasks.Task<string> PlaceOrderAsync(string OrderID, string DrugID, int Quantity) {
            return base.Channel.PlaceOrderAsync(OrderID, DrugID, Quantity);
        }
        
        public System.Data.DataSet SearchDrugByName(string DrugName) {
            return base.Channel.SearchDrugByName(DrugName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchDrugByNameAsync(string DrugName) {
            return base.Channel.SearchDrugByNameAsync(DrugName);
        }
        
        public System.Data.DataSet GetOrders() {
            return base.Channel.GetOrders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetOrdersAsync() {
            return base.Channel.GetOrdersAsync();
        }
    }
}
