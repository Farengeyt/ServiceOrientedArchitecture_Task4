﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task4.StudentListServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://www.mycompany.com/")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private float AvgMarkField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public float AvgMark {
            get {
                return this.AvgMarkField;
            }
            set {
                if ((this.AvgMarkField.Equals(value) != true)) {
                    this.AvgMarkField = value;
                    this.RaisePropertyChanged("AvgMark");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.mycompany.com/", ConfigurationName="StudentListServiceReference.MyWebServiceSoap")]
    public interface MyWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name text from namespace http://www.mycompany.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/HelloWorld", ReplyAction="*")]
        Task4.StudentListServiceReference.HelloWorldResponse HelloWorld(Task4.StudentListServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Task4.StudentListServiceReference.HelloWorldResponse> HelloWorldAsync(Task4.StudentListServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetStudentsGraterThanResult from namespace http://www.mycompany.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/GetStudentsGraterThan", ReplyAction="*")]
        Task4.StudentListServiceReference.GetStudentsGraterThanResponse GetStudentsGraterThan(Task4.StudentListServiceReference.GetStudentsGraterThanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/GetStudentsGraterThan", ReplyAction="*")]
        System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsGraterThanResponse> GetStudentsGraterThanAsync(Task4.StudentListServiceReference.GetStudentsGraterThanRequest request);
        
        // CODEGEN: Generating message contract since element name GetStudentsLowerThanResult from namespace http://www.mycompany.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/GetStudentsLowerThan", ReplyAction="*")]
        Task4.StudentListServiceReference.GetStudentsLowerThanResponse GetStudentsLowerThan(Task4.StudentListServiceReference.GetStudentsLowerThanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/GetStudentsLowerThan", ReplyAction="*")]
        System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsLowerThanResponse> GetStudentsLowerThanAsync(Task4.StudentListServiceReference.GetStudentsLowerThanRequest request);
        
        // CODEGEN: Generating message contract since element name GetStudentsInRangeResult from namespace http://www.mycompany.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/GetStudentsInRange", ReplyAction="*")]
        Task4.StudentListServiceReference.GetStudentsInRangeResponse GetStudentsInRange(Task4.StudentListServiceReference.GetStudentsInRangeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/GetStudentsInRange", ReplyAction="*")]
        System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsInRangeResponse> GetStudentsInRangeAsync(Task4.StudentListServiceReference.GetStudentsInRangeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://www.mycompany.com/", Order=0)]
        public Task4.StudentListServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Task4.StudentListServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mycompany.com/")]
    public partial class HelloWorldRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string text;
        
        public HelloWorldRequestBody() {
        }
        
        public HelloWorldRequestBody(string text) {
            this.text = text;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://www.mycompany.com/", Order=0)]
        public Task4.StudentListServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Task4.StudentListServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mycompany.com/")]
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
    public partial class GetStudentsGraterThanRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentsGraterThan", Namespace="http://www.mycompany.com/", Order=0)]
        public Task4.StudentListServiceReference.GetStudentsGraterThanRequestBody Body;
        
        public GetStudentsGraterThanRequest() {
        }
        
        public GetStudentsGraterThanRequest(Task4.StudentListServiceReference.GetStudentsGraterThanRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mycompany.com/")]
    public partial class GetStudentsGraterThanRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float mark;
        
        public GetStudentsGraterThanRequestBody() {
        }
        
        public GetStudentsGraterThanRequestBody(float mark) {
            this.mark = mark;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentsGraterThanResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentsGraterThanResponse", Namespace="http://www.mycompany.com/", Order=0)]
        public Task4.StudentListServiceReference.GetStudentsGraterThanResponseBody Body;
        
        public GetStudentsGraterThanResponse() {
        }
        
        public GetStudentsGraterThanResponse(Task4.StudentListServiceReference.GetStudentsGraterThanResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mycompany.com/")]
    public partial class GetStudentsGraterThanResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Task4.StudentListServiceReference.Student[] GetStudentsGraterThanResult;
        
        public GetStudentsGraterThanResponseBody() {
        }
        
        public GetStudentsGraterThanResponseBody(Task4.StudentListServiceReference.Student[] GetStudentsGraterThanResult) {
            this.GetStudentsGraterThanResult = GetStudentsGraterThanResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentsLowerThanRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentsLowerThan", Namespace="http://www.mycompany.com/", Order=0)]
        public Task4.StudentListServiceReference.GetStudentsLowerThanRequestBody Body;
        
        public GetStudentsLowerThanRequest() {
        }
        
        public GetStudentsLowerThanRequest(Task4.StudentListServiceReference.GetStudentsLowerThanRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mycompany.com/")]
    public partial class GetStudentsLowerThanRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float mark;
        
        public GetStudentsLowerThanRequestBody() {
        }
        
        public GetStudentsLowerThanRequestBody(float mark) {
            this.mark = mark;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentsLowerThanResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentsLowerThanResponse", Namespace="http://www.mycompany.com/", Order=0)]
        public Task4.StudentListServiceReference.GetStudentsLowerThanResponseBody Body;
        
        public GetStudentsLowerThanResponse() {
        }
        
        public GetStudentsLowerThanResponse(Task4.StudentListServiceReference.GetStudentsLowerThanResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mycompany.com/")]
    public partial class GetStudentsLowerThanResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Task4.StudentListServiceReference.Student[] GetStudentsLowerThanResult;
        
        public GetStudentsLowerThanResponseBody() {
        }
        
        public GetStudentsLowerThanResponseBody(Task4.StudentListServiceReference.Student[] GetStudentsLowerThanResult) {
            this.GetStudentsLowerThanResult = GetStudentsLowerThanResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentsInRangeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentsInRange", Namespace="http://www.mycompany.com/", Order=0)]
        public Task4.StudentListServiceReference.GetStudentsInRangeRequestBody Body;
        
        public GetStudentsInRangeRequest() {
        }
        
        public GetStudentsInRangeRequest(Task4.StudentListServiceReference.GetStudentsInRangeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mycompany.com/")]
    public partial class GetStudentsInRangeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float minMark;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public float maxMark;
        
        public GetStudentsInRangeRequestBody() {
        }
        
        public GetStudentsInRangeRequestBody(float minMark, float maxMark) {
            this.minMark = minMark;
            this.maxMark = maxMark;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentsInRangeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentsInRangeResponse", Namespace="http://www.mycompany.com/", Order=0)]
        public Task4.StudentListServiceReference.GetStudentsInRangeResponseBody Body;
        
        public GetStudentsInRangeResponse() {
        }
        
        public GetStudentsInRangeResponse(Task4.StudentListServiceReference.GetStudentsInRangeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mycompany.com/")]
    public partial class GetStudentsInRangeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Task4.StudentListServiceReference.Student[] GetStudentsInRangeResult;
        
        public GetStudentsInRangeResponseBody() {
        }
        
        public GetStudentsInRangeResponseBody(Task4.StudentListServiceReference.Student[] GetStudentsInRangeResult) {
            this.GetStudentsInRangeResult = GetStudentsInRangeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyWebServiceSoapChannel : Task4.StudentListServiceReference.MyWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyWebServiceSoapClient : System.ServiceModel.ClientBase<Task4.StudentListServiceReference.MyWebServiceSoap>, Task4.StudentListServiceReference.MyWebServiceSoap {
        
        public MyWebServiceSoapClient() {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Task4.StudentListServiceReference.HelloWorldResponse Task4.StudentListServiceReference.MyWebServiceSoap.HelloWorld(Task4.StudentListServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld(string text) {
            Task4.StudentListServiceReference.HelloWorldRequest inValue = new Task4.StudentListServiceReference.HelloWorldRequest();
            inValue.Body = new Task4.StudentListServiceReference.HelloWorldRequestBody();
            inValue.Body.text = text;
            Task4.StudentListServiceReference.HelloWorldResponse retVal = ((Task4.StudentListServiceReference.MyWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Task4.StudentListServiceReference.HelloWorldResponse> Task4.StudentListServiceReference.MyWebServiceSoap.HelloWorldAsync(Task4.StudentListServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Task4.StudentListServiceReference.HelloWorldResponse> HelloWorldAsync(string text) {
            Task4.StudentListServiceReference.HelloWorldRequest inValue = new Task4.StudentListServiceReference.HelloWorldRequest();
            inValue.Body = new Task4.StudentListServiceReference.HelloWorldRequestBody();
            inValue.Body.text = text;
            return ((Task4.StudentListServiceReference.MyWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Task4.StudentListServiceReference.GetStudentsGraterThanResponse Task4.StudentListServiceReference.MyWebServiceSoap.GetStudentsGraterThan(Task4.StudentListServiceReference.GetStudentsGraterThanRequest request) {
            return base.Channel.GetStudentsGraterThan(request);
        }
        
        public Task4.StudentListServiceReference.Student[] GetStudentsGraterThan(float mark) {
            Task4.StudentListServiceReference.GetStudentsGraterThanRequest inValue = new Task4.StudentListServiceReference.GetStudentsGraterThanRequest();
            inValue.Body = new Task4.StudentListServiceReference.GetStudentsGraterThanRequestBody();
            inValue.Body.mark = mark;
            Task4.StudentListServiceReference.GetStudentsGraterThanResponse retVal = ((Task4.StudentListServiceReference.MyWebServiceSoap)(this)).GetStudentsGraterThan(inValue);
            return retVal.Body.GetStudentsGraterThanResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsGraterThanResponse> Task4.StudentListServiceReference.MyWebServiceSoap.GetStudentsGraterThanAsync(Task4.StudentListServiceReference.GetStudentsGraterThanRequest request) {
            return base.Channel.GetStudentsGraterThanAsync(request);
        }
        
        public System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsGraterThanResponse> GetStudentsGraterThanAsync(float mark) {
            Task4.StudentListServiceReference.GetStudentsGraterThanRequest inValue = new Task4.StudentListServiceReference.GetStudentsGraterThanRequest();
            inValue.Body = new Task4.StudentListServiceReference.GetStudentsGraterThanRequestBody();
            inValue.Body.mark = mark;
            return ((Task4.StudentListServiceReference.MyWebServiceSoap)(this)).GetStudentsGraterThanAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Task4.StudentListServiceReference.GetStudentsLowerThanResponse Task4.StudentListServiceReference.MyWebServiceSoap.GetStudentsLowerThan(Task4.StudentListServiceReference.GetStudentsLowerThanRequest request) {
            return base.Channel.GetStudentsLowerThan(request);
        }
        
        public Task4.StudentListServiceReference.Student[] GetStudentsLowerThan(float mark) {
            Task4.StudentListServiceReference.GetStudentsLowerThanRequest inValue = new Task4.StudentListServiceReference.GetStudentsLowerThanRequest();
            inValue.Body = new Task4.StudentListServiceReference.GetStudentsLowerThanRequestBody();
            inValue.Body.mark = mark;
            Task4.StudentListServiceReference.GetStudentsLowerThanResponse retVal = ((Task4.StudentListServiceReference.MyWebServiceSoap)(this)).GetStudentsLowerThan(inValue);
            return retVal.Body.GetStudentsLowerThanResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsLowerThanResponse> Task4.StudentListServiceReference.MyWebServiceSoap.GetStudentsLowerThanAsync(Task4.StudentListServiceReference.GetStudentsLowerThanRequest request) {
            return base.Channel.GetStudentsLowerThanAsync(request);
        }
        
        public System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsLowerThanResponse> GetStudentsLowerThanAsync(float mark) {
            Task4.StudentListServiceReference.GetStudentsLowerThanRequest inValue = new Task4.StudentListServiceReference.GetStudentsLowerThanRequest();
            inValue.Body = new Task4.StudentListServiceReference.GetStudentsLowerThanRequestBody();
            inValue.Body.mark = mark;
            return ((Task4.StudentListServiceReference.MyWebServiceSoap)(this)).GetStudentsLowerThanAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Task4.StudentListServiceReference.GetStudentsInRangeResponse Task4.StudentListServiceReference.MyWebServiceSoap.GetStudentsInRange(Task4.StudentListServiceReference.GetStudentsInRangeRequest request) {
            return base.Channel.GetStudentsInRange(request);
        }
        
        public Task4.StudentListServiceReference.Student[] GetStudentsInRange(float minMark, float maxMark) {
            Task4.StudentListServiceReference.GetStudentsInRangeRequest inValue = new Task4.StudentListServiceReference.GetStudentsInRangeRequest();
            inValue.Body = new Task4.StudentListServiceReference.GetStudentsInRangeRequestBody();
            inValue.Body.minMark = minMark;
            inValue.Body.maxMark = maxMark;
            Task4.StudentListServiceReference.GetStudentsInRangeResponse retVal = ((Task4.StudentListServiceReference.MyWebServiceSoap)(this)).GetStudentsInRange(inValue);
            return retVal.Body.GetStudentsInRangeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsInRangeResponse> Task4.StudentListServiceReference.MyWebServiceSoap.GetStudentsInRangeAsync(Task4.StudentListServiceReference.GetStudentsInRangeRequest request) {
            return base.Channel.GetStudentsInRangeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Task4.StudentListServiceReference.GetStudentsInRangeResponse> GetStudentsInRangeAsync(float minMark, float maxMark) {
            Task4.StudentListServiceReference.GetStudentsInRangeRequest inValue = new Task4.StudentListServiceReference.GetStudentsInRangeRequest();
            inValue.Body = new Task4.StudentListServiceReference.GetStudentsInRangeRequestBody();
            inValue.Body.minMark = minMark;
            inValue.Body.maxMark = maxMark;
            return ((Task4.StudentListServiceReference.MyWebServiceSoap)(this)).GetStudentsInRangeAsync(inValue);
        }
    }
}
