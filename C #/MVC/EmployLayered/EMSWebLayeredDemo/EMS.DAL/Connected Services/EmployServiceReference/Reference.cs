﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS.DAL.EmployServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employ", Namespace="http://schemas.datacontract.org/2004/07/EMS.WcfService")]
    [System.SerializableAttribute()]
    public partial class Employ : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BasicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeptField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DesigField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmpnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Basic {
            get {
                return this.BasicField;
            }
            set {
                if ((this.BasicField.Equals(value) != true)) {
                    this.BasicField = value;
                    this.RaisePropertyChanged("Basic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dept {
            get {
                return this.DeptField;
            }
            set {
                if ((object.ReferenceEquals(this.DeptField, value) != true)) {
                    this.DeptField = value;
                    this.RaisePropertyChanged("Dept");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Desig {
            get {
                return this.DesigField;
            }
            set {
                if ((object.ReferenceEquals(this.DesigField, value) != true)) {
                    this.DesigField = value;
                    this.RaisePropertyChanged("Desig");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Empno {
            get {
                return this.EmpnoField;
            }
            set {
                if ((this.EmpnoField.Equals(value) != true)) {
                    this.EmpnoField = value;
                    this.RaisePropertyChanged("Empno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployServiceReference.IEmployService")]
    public interface IEmployService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/AddEmploy", ReplyAction="http://tempuri.org/IEmployService/AddEmployResponse")]
        bool AddEmploy(EMS.DAL.EmployServiceReference.Employ employ);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/AddEmploy", ReplyAction="http://tempuri.org/IEmployService/AddEmployResponse")]
        System.Threading.Tasks.Task<bool> AddEmployAsync(EMS.DAL.EmployServiceReference.Employ employ);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/UpdateEmploy", ReplyAction="http://tempuri.org/IEmployService/UpdateEmployResponse")]
        bool UpdateEmploy(EMS.DAL.EmployServiceReference.Employ employ);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/UpdateEmploy", ReplyAction="http://tempuri.org/IEmployService/UpdateEmployResponse")]
        System.Threading.Tasks.Task<bool> UpdateEmployAsync(EMS.DAL.EmployServiceReference.Employ employ);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/DeleteEmploy", ReplyAction="http://tempuri.org/IEmployService/DeleteEmployResponse")]
        string DeleteEmploy(int Empno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/DeleteEmploy", ReplyAction="http://tempuri.org/IEmployService/DeleteEmployResponse")]
        System.Threading.Tasks.Task<string> DeleteEmployAsync(int Empno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/SearchEmploy", ReplyAction="http://tempuri.org/IEmployService/SearchEmployResponse")]
        EMS.DAL.EmployServiceReference.Employ SearchEmploy(int Empno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/SearchEmploy", ReplyAction="http://tempuri.org/IEmployService/SearchEmployResponse")]
        System.Threading.Tasks.Task<EMS.DAL.EmployServiceReference.Employ> SearchEmployAsync(int Empno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/ShowEmploy", ReplyAction="http://tempuri.org/IEmployService/ShowEmployResponse")]
        EMS.DAL.EmployServiceReference.Employ[] ShowEmploy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployService/ShowEmploy", ReplyAction="http://tempuri.org/IEmployService/ShowEmployResponse")]
        System.Threading.Tasks.Task<EMS.DAL.EmployServiceReference.Employ[]> ShowEmployAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployServiceChannel : EMS.DAL.EmployServiceReference.IEmployService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployServiceClient : System.ServiceModel.ClientBase<EMS.DAL.EmployServiceReference.IEmployService>, EMS.DAL.EmployServiceReference.IEmployService {
        
        public EmployServiceClient() {
        }
        
        public EmployServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddEmploy(EMS.DAL.EmployServiceReference.Employ employ) {
            return base.Channel.AddEmploy(employ);
        }
        
        public System.Threading.Tasks.Task<bool> AddEmployAsync(EMS.DAL.EmployServiceReference.Employ employ) {
            return base.Channel.AddEmployAsync(employ);
        }
        
        public bool UpdateEmploy(EMS.DAL.EmployServiceReference.Employ employ) {
            return base.Channel.UpdateEmploy(employ);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateEmployAsync(EMS.DAL.EmployServiceReference.Employ employ) {
            return base.Channel.UpdateEmployAsync(employ);
        }
        
        public string DeleteEmploy(int Empno) {
            return base.Channel.DeleteEmploy(Empno);
        }
        
        public System.Threading.Tasks.Task<string> DeleteEmployAsync(int Empno) {
            return base.Channel.DeleteEmployAsync(Empno);
        }
        
        public EMS.DAL.EmployServiceReference.Employ SearchEmploy(int Empno) {
            return base.Channel.SearchEmploy(Empno);
        }
        
        public System.Threading.Tasks.Task<EMS.DAL.EmployServiceReference.Employ> SearchEmployAsync(int Empno) {
            return base.Channel.SearchEmployAsync(Empno);
        }
        
        public EMS.DAL.EmployServiceReference.Employ[] ShowEmploy() {
            return base.Channel.ShowEmploy();
        }
        
        public System.Threading.Tasks.Task<EMS.DAL.EmployServiceReference.Employ[]> ShowEmployAsync() {
            return base.Channel.ShowEmployAsync();
        }
    }
}