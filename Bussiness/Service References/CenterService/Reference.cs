﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bussiness.CenterService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServerData", Namespace="http://schemas.datacontract.org/2004/07/Center.Server")]
    [System.SerializableAttribute()]
    public partial class ServerData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LowestLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MustLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OnlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PortField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StateField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ip {
            get {
                return this.IpField;
            }
            set {
                if ((object.ReferenceEquals(this.IpField, value) != true)) {
                    this.IpField = value;
                    this.RaisePropertyChanged("Ip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LowestLevel {
            get {
                return this.LowestLevelField;
            }
            set {
                if ((this.LowestLevelField.Equals(value) != true)) {
                    this.LowestLevelField = value;
                    this.RaisePropertyChanged("LowestLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MustLevel {
            get {
                return this.MustLevelField;
            }
            set {
                if ((this.MustLevelField.Equals(value) != true)) {
                    this.MustLevelField = value;
                    this.RaisePropertyChanged("MustLevel");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Online {
            get {
                return this.OnlineField;
            }
            set {
                if ((this.OnlineField.Equals(value) != true)) {
                    this.OnlineField = value;
                    this.RaisePropertyChanged("Online");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Port {
            get {
                return this.PortField;
            }
            set {
                if ((this.PortField.Equals(value) != true)) {
                    this.PortField = value;
                    this.RaisePropertyChanged("Port");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CenterService.ICenterService")]
    public interface ICenterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/GetServerList", ReplyAction="http://tempuri.org/ICenterService/GetServerListResponse")]
        Bussiness.CenterService.ServerData[] GetServerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/ChargeMoney", ReplyAction="http://tempuri.org/ICenterService/ChargeMoneyResponse")]
        bool ChargeMoney(int userID, string chargeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/SystemNotice", ReplyAction="http://tempuri.org/ICenterService/SystemNoticeResponse")]
        bool SystemNotice(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/KitoffUser", ReplyAction="http://tempuri.org/ICenterService/KitoffUserResponse")]
        bool KitoffUser(int playerID, string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/ReLoadServerList", ReplyAction="http://tempuri.org/ICenterService/ReLoadServerListResponse")]
        bool ReLoadServerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/MailNotice", ReplyAction="http://tempuri.org/ICenterService/MailNoticeResponse")]
        bool MailNotice(int playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/ActivePlayer", ReplyAction="http://tempuri.org/ICenterService/ActivePlayerResponse")]
        bool ActivePlayer(bool isActive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/CreatePlayer", ReplyAction="http://tempuri.org/ICenterService/CreatePlayerResponse")]
        bool CreatePlayer(int id, string name, string password, bool isFirst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/ValidateLoginAndGetID", ReplyAction="http://tempuri.org/ICenterService/ValidateLoginAndGetIDResponse")]
        bool ValidateLoginAndGetID(string name, string password, ref int userID, ref bool isFirst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/AASUpdateState", ReplyAction="http://tempuri.org/ICenterService/AASUpdateStateResponse")]
        bool AASUpdateState(bool state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/AASGetState", ReplyAction="http://tempuri.org/ICenterService/AASGetStateResponse")]
        int AASGetState();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/ExperienceRateUpdate", ReplyAction="http://tempuri.org/ICenterService/ExperienceRateUpdateResponse")]
        int ExperienceRateUpdate(int serverId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/NoticeServerUpdate", ReplyAction="http://tempuri.org/ICenterService/NoticeServerUpdateResponse")]
        int NoticeServerUpdate(int serverId, int type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/UpdateConfigState", ReplyAction="http://tempuri.org/ICenterService/UpdateConfigStateResponse")]
        bool UpdateConfigState(int type, bool state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/GetConfigState", ReplyAction="http://tempuri.org/ICenterService/GetConfigStateResponse")]
        int GetConfigState(int type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICenterService/Reload", ReplyAction="http://tempuri.org/ICenterService/ReloadResponse")]
        bool Reload(string type);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICenterServiceChannel : Bussiness.CenterService.ICenterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CenterServiceClient : System.ServiceModel.ClientBase<Bussiness.CenterService.ICenterService>, Bussiness.CenterService.ICenterService {
        
        public CenterServiceClient() {
        }
        
        public CenterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CenterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CenterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CenterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Bussiness.CenterService.ServerData[] GetServerList() {
            return base.Channel.GetServerList();
        }
        
        public bool ChargeMoney(int userID, string chargeID) {
            return base.Channel.ChargeMoney(userID, chargeID);
        }
        
        public bool SystemNotice(string msg) {
            return base.Channel.SystemNotice(msg);
        }
        
        public bool KitoffUser(int playerID, string msg) {
            return base.Channel.KitoffUser(playerID, msg);
        }
        
        public bool ReLoadServerList() {
            return base.Channel.ReLoadServerList();
        }
        
        public bool MailNotice(int playerID) {
            return base.Channel.MailNotice(playerID);
        }
        
        public bool ActivePlayer(bool isActive) {
            return base.Channel.ActivePlayer(isActive);
        }
        
        public bool CreatePlayer(int id, string name, string password, bool isFirst) {
            return base.Channel.CreatePlayer(id, name, password, isFirst);
        }
        
        public bool ValidateLoginAndGetID(string name, string password, ref int userID, ref bool isFirst) {
            return base.Channel.ValidateLoginAndGetID(name, password, ref userID, ref isFirst);
        }
        
        public bool AASUpdateState(bool state) {
            return base.Channel.AASUpdateState(state);
        }
        
        public int AASGetState() {
            return base.Channel.AASGetState();
        }
        
        public int ExperienceRateUpdate(int serverId) {
            return base.Channel.ExperienceRateUpdate(serverId);
        }
        
        public int NoticeServerUpdate(int serverId, int type) {
            return base.Channel.NoticeServerUpdate(serverId, type);
        }
        
        public bool UpdateConfigState(int type, bool state) {
            return base.Channel.UpdateConfigState(type, state);
        }
        
        public int GetConfigState(int type) {
            return base.Channel.GetConfigState(type);
        }
        
        public bool Reload(string type) {
            return base.Channel.Reload(type);
        }
    }
}
