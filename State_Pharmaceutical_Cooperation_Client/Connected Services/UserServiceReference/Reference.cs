﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace State_Pharmaceutical_Cooperation_Client.UserServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.UserWebServiceSoap")]
    public interface UserWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name AutoSupplierIDResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoSupplierID", ReplyAction="*")]
        State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDResponse AutoSupplierID(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoSupplierID", ReplyAction="*")]
        System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDResponse> AutoSupplierIDAsync(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequest request);
        
        // CODEGEN: Generating message contract since element name AutoUserIDResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoUserID", ReplyAction="*")]
        State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDResponse AutoUserID(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoUserID", ReplyAction="*")]
        System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDResponse> AutoUserIDAsync(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequest request);
        
        // CODEGEN: Generating message contract since element name SupplierID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegisterSupplier", ReplyAction="*")]
        State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierResponse RegisterSupplier(State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegisterSupplier", ReplyAction="*")]
        System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierResponse> RegisterSupplierAsync(State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequest request);
        
        // CODEGEN: Generating message contract since element name Username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUser", ReplyAction="*")]
        State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserResponse AuthenticateUser(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserResponse> AuthenticateUserAsync(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AutoSupplierIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AutoSupplierID", Namespace="http://tempuri.org/", Order=0)]
        public State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequestBody Body;
        
        public AutoSupplierIDRequest() {
        }
        
        public AutoSupplierIDRequest(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AutoSupplierIDRequestBody {
        
        public AutoSupplierIDRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AutoSupplierIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AutoSupplierIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDResponseBody Body;
        
        public AutoSupplierIDResponse() {
        }
        
        public AutoSupplierIDResponse(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AutoSupplierIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AutoSupplierIDResult;
        
        public AutoSupplierIDResponseBody() {
        }
        
        public AutoSupplierIDResponseBody(string AutoSupplierIDResult) {
            this.AutoSupplierIDResult = AutoSupplierIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AutoUserIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AutoUserID", Namespace="http://tempuri.org/", Order=0)]
        public State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequestBody Body;
        
        public AutoUserIDRequest() {
        }
        
        public AutoUserIDRequest(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AutoUserIDRequestBody {
        
        public AutoUserIDRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AutoUserIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AutoUserIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDResponseBody Body;
        
        public AutoUserIDResponse() {
        }
        
        public AutoUserIDResponse(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AutoUserIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AutoUserIDResult;
        
        public AutoUserIDResponseBody() {
        }
        
        public AutoUserIDResponseBody(string AutoUserIDResult) {
            this.AutoUserIDResult = AutoUserIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterSupplierRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegisterSupplier", Namespace="http://tempuri.org/", Order=0)]
        public State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequestBody Body;
        
        public RegisterSupplierRequest() {
        }
        
        public RegisterSupplierRequest(State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterSupplierRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SupplierID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string SupplierName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ContactNumber;
        
        public RegisterSupplierRequestBody() {
        }
        
        public RegisterSupplierRequestBody(string SupplierID, string SupplierName, string Username, string Password, string ContactNumber) {
            this.SupplierID = SupplierID;
            this.SupplierName = SupplierName;
            this.Username = Username;
            this.Password = Password;
            this.ContactNumber = ContactNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterSupplierResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegisterSupplierResponse", Namespace="http://tempuri.org/", Order=0)]
        public State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierResponseBody Body;
        
        public RegisterSupplierResponse() {
        }
        
        public RegisterSupplierResponse(State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterSupplierResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RegisterSupplierResult;
        
        public RegisterSupplierResponseBody() {
        }
        
        public RegisterSupplierResponseBody(string RegisterSupplierResult) {
            this.RegisterSupplierResult = RegisterSupplierResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUser", Namespace="http://tempuri.org/", Order=0)]
        public State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequestBody Body;
        
        public AuthenticateUserRequest() {
        }
        
        public AuthenticateUserRequest(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        public AuthenticateUserRequestBody() {
        }
        
        public AuthenticateUserRequestBody(string Username, string Password) {
            this.Username = Username;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserResponseBody Body;
        
        public AuthenticateUserResponse() {
        }
        
        public AuthenticateUserResponse(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AuthenticateUserResult;
        
        public AuthenticateUserResponseBody() {
        }
        
        public AuthenticateUserResponseBody(string AuthenticateUserResult) {
            this.AuthenticateUserResult = AuthenticateUserResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserWebServiceSoapChannel : State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserWebServiceSoapClient : System.ServiceModel.ClientBase<State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap>, State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap {
        
        public UserWebServiceSoapClient() {
        }
        
        public UserWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDResponse State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap.AutoSupplierID(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequest request) {
            return base.Channel.AutoSupplierID(request);
        }
        
        public string AutoSupplierID() {
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequest inValue = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequest();
            inValue.Body = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequestBody();
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDResponse retVal = ((State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap)(this)).AutoSupplierID(inValue);
            return retVal.Body.AutoSupplierIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDResponse> State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap.AutoSupplierIDAsync(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequest request) {
            return base.Channel.AutoSupplierIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDResponse> AutoSupplierIDAsync() {
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequest inValue = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequest();
            inValue.Body = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoSupplierIDRequestBody();
            return ((State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap)(this)).AutoSupplierIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDResponse State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap.AutoUserID(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequest request) {
            return base.Channel.AutoUserID(request);
        }
        
        public string AutoUserID() {
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequest inValue = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequest();
            inValue.Body = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequestBody();
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDResponse retVal = ((State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap)(this)).AutoUserID(inValue);
            return retVal.Body.AutoUserIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDResponse> State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap.AutoUserIDAsync(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequest request) {
            return base.Channel.AutoUserIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDResponse> AutoUserIDAsync() {
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequest inValue = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequest();
            inValue.Body = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AutoUserIDRequestBody();
            return ((State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap)(this)).AutoUserIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierResponse State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap.RegisterSupplier(State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequest request) {
            return base.Channel.RegisterSupplier(request);
        }
        
        public string RegisterSupplier(string SupplierID, string SupplierName, string Username, string Password, string ContactNumber) {
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequest inValue = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequest();
            inValue.Body = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequestBody();
            inValue.Body.SupplierID = SupplierID;
            inValue.Body.SupplierName = SupplierName;
            inValue.Body.Username = Username;
            inValue.Body.Password = Password;
            inValue.Body.ContactNumber = ContactNumber;
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierResponse retVal = ((State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap)(this)).RegisterSupplier(inValue);
            return retVal.Body.RegisterSupplierResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierResponse> State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap.RegisterSupplierAsync(State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequest request) {
            return base.Channel.RegisterSupplierAsync(request);
        }
        
        public System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierResponse> RegisterSupplierAsync(string SupplierID, string SupplierName, string Username, string Password, string ContactNumber) {
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequest inValue = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequest();
            inValue.Body = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.RegisterSupplierRequestBody();
            inValue.Body.SupplierID = SupplierID;
            inValue.Body.SupplierName = SupplierName;
            inValue.Body.Username = Username;
            inValue.Body.Password = Password;
            inValue.Body.ContactNumber = ContactNumber;
            return ((State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap)(this)).RegisterSupplierAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserResponse State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap.AuthenticateUser(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequest request) {
            return base.Channel.AuthenticateUser(request);
        }
        
        public string AuthenticateUser(string Username, string Password) {
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequest inValue = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequest();
            inValue.Body = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequestBody();
            inValue.Body.Username = Username;
            inValue.Body.Password = Password;
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserResponse retVal = ((State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap)(this)).AuthenticateUser(inValue);
            return retVal.Body.AuthenticateUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserResponse> State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap.AuthenticateUserAsync(State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequest request) {
            return base.Channel.AuthenticateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserResponse> AuthenticateUserAsync(string Username, string Password) {
            State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequest inValue = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequest();
            inValue.Body = new State_Pharmaceutical_Cooperation_Client.UserServiceReference.AuthenticateUserRequestBody();
            inValue.Body.Username = Username;
            inValue.Body.Password = Password;
            return ((State_Pharmaceutical_Cooperation_Client.UserServiceReference.UserWebServiceSoap)(this)).AuthenticateUserAsync(inValue);
        }
    }
}
