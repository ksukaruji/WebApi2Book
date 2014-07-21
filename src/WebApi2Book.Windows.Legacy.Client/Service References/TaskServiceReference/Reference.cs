﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi2Book.Windows.Legacy.Client.TaskServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Task", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Task : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<long> TaskIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        private System.Nullable<System.DateTime> StartDateField;
        
        private System.Nullable<System.DateTime> DueDateField;
        
        private System.Nullable<System.DateTime> CreatedDateField;
        
        private System.Nullable<System.DateTime> CompletedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Status StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApi2Book.Windows.Legacy.Client.TaskServiceReference.User[] AssigneesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Link[] LinksField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<long> TaskId {
            get {
                return this.TaskIdField;
            }
            set {
                if ((this.TaskIdField.Equals(value) != true)) {
                    this.TaskIdField = value;
                    this.RaisePropertyChanged("TaskId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<System.DateTime> StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<System.DateTime> DueDate {
            get {
                return this.DueDateField;
            }
            set {
                if ((this.DueDateField.Equals(value) != true)) {
                    this.DueDateField = value;
                    this.RaisePropertyChanged("DueDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<System.DateTime> CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<System.DateTime> CompletedDate {
            get {
                return this.CompletedDateField;
            }
            set {
                if ((this.CompletedDateField.Equals(value) != true)) {
                    this.CompletedDateField = value;
                    this.RaisePropertyChanged("CompletedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Status Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.User[] Assignees {
            get {
                return this.AssigneesField;
            }
            set {
                if ((object.ReferenceEquals(this.AssigneesField, value) != true)) {
                    this.AssigneesField = value;
                    this.RaisePropertyChanged("Assignees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Link[] Links {
            get {
                return this.LinksField;
            }
            set {
                if ((object.ReferenceEquals(this.LinksField, value) != true)) {
                    this.LinksField = value;
                    this.RaisePropertyChanged("Links");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Status : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long StatusIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int OrdinalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Link[] LinksField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long StatusId {
            get {
                return this.StatusIdField;
            }
            set {
                if ((this.StatusIdField.Equals(value) != true)) {
                    this.StatusIdField = value;
                    this.RaisePropertyChanged("StatusId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Ordinal {
            get {
                return this.OrdinalField;
            }
            set {
                if ((this.OrdinalField.Equals(value) != true)) {
                    this.OrdinalField = value;
                    this.RaisePropertyChanged("Ordinal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Link[] Links {
            get {
                return this.LinksField;
            }
            set {
                if ((object.ReferenceEquals(this.LinksField, value) != true)) {
                    this.LinksField = value;
                    this.RaisePropertyChanged("Links");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Link[] LinksField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Link[] Links {
            get {
                return this.LinksField;
            }
            set {
                if ((object.ReferenceEquals(this.LinksField, value) != true)) {
                    this.LinksField = value;
                    this.RaisePropertyChanged("Links");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Link", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Link : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HrefField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MethodField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Rel {
            get {
                return this.RelField;
            }
            set {
                if ((object.ReferenceEquals(this.RelField, value) != true)) {
                    this.RelField = value;
                    this.RaisePropertyChanged("Rel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Href {
            get {
                return this.HrefField;
            }
            set {
                if ((object.ReferenceEquals(this.HrefField, value) != true)) {
                    this.HrefField = value;
                    this.RaisePropertyChanged("Href");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Method {
            get {
                return this.MethodField;
            }
            set {
                if ((object.ReferenceEquals(this.MethodField, value) != true)) {
                    this.MethodField = value;
                    this.RaisePropertyChanged("Method");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TaskServiceReference.TeamTaskServiceSoap")]
    public interface TeamTaskServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetTasksResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTasks", ReplyAction="*")]
        WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksResponse GetTasks(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTasks", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksResponse> GetTasksAsync(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequest request);
        
        // CODEGEN: Generating message contract since element name GetTaskByIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTaskById", ReplyAction="*")]
        WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdResponse GetTaskById(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTaskById", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdResponse> GetTaskByIdAsync(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTasksRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTasks", Namespace="http://tempuri.org/", Order=0)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequestBody Body;
        
        public GetTasksRequest() {
        }
        
        public GetTasksRequest(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetTasksRequestBody {
        
        public GetTasksRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTasksResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTasksResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksResponseBody Body;
        
        public GetTasksResponse() {
        }
        
        public GetTasksResponse(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTasksResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Task[] GetTasksResult;
        
        public GetTasksResponseBody() {
        }
        
        public GetTasksResponseBody(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Task[] GetTasksResult) {
            this.GetTasksResult = GetTasksResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTaskByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTaskById", Namespace="http://tempuri.org/", Order=0)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequestBody Body;
        
        public GetTaskByIdRequest() {
        }
        
        public GetTaskByIdRequest(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTaskByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int taskId;
        
        public GetTaskByIdRequestBody() {
        }
        
        public GetTaskByIdRequestBody(int taskId) {
            this.taskId = taskId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTaskByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTaskByIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdResponseBody Body;
        
        public GetTaskByIdResponse() {
        }
        
        public GetTaskByIdResponse(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTaskByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Task GetTaskByIdResult;
        
        public GetTaskByIdResponseBody() {
        }
        
        public GetTaskByIdResponseBody(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Task GetTaskByIdResult) {
            this.GetTaskByIdResult = GetTaskByIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TeamTaskServiceSoapChannel : WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TeamTaskServiceSoapClient : System.ServiceModel.ClientBase<WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap>, WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap {
        
        public TeamTaskServiceSoapClient() {
        }
        
        public TeamTaskServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TeamTaskServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TeamTaskServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TeamTaskServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksResponse WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap.GetTasks(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequest request) {
            return base.Channel.GetTasks(request);
        }
        
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Task[] GetTasks() {
            WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequest inValue = new WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequest();
            inValue.Body = new WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequestBody();
            WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksResponse retVal = ((WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap)(this)).GetTasks(inValue);
            return retVal.Body.GetTasksResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksResponse> WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap.GetTasksAsync(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequest request) {
            return base.Channel.GetTasksAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksResponse> GetTasksAsync() {
            WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequest inValue = new WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequest();
            inValue.Body = new WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTasksRequestBody();
            return ((WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap)(this)).GetTasksAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdResponse WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap.GetTaskById(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequest request) {
            return base.Channel.GetTaskById(request);
        }
        
        public WebApi2Book.Windows.Legacy.Client.TaskServiceReference.Task GetTaskById(int taskId) {
            WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequest inValue = new WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequest();
            inValue.Body = new WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequestBody();
            inValue.Body.taskId = taskId;
            WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdResponse retVal = ((WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap)(this)).GetTaskById(inValue);
            return retVal.Body.GetTaskByIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdResponse> WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap.GetTaskByIdAsync(WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequest request) {
            return base.Channel.GetTaskByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdResponse> GetTaskByIdAsync(int taskId) {
            WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequest inValue = new WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequest();
            inValue.Body = new WebApi2Book.Windows.Legacy.Client.TaskServiceReference.GetTaskByIdRequestBody();
            inValue.Body.taskId = taskId;
            return ((WebApi2Book.Windows.Legacy.Client.TaskServiceReference.TeamTaskServiceSoap)(this)).GetTaskByIdAsync(inValue);
        }
    }
}