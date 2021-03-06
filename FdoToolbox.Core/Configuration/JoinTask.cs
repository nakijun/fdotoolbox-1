﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace FdoToolbox.Core.Configuration {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Join", Namespace="", IsNullable=false)]
    public partial class FdoJoinTaskDefinition : object, System.ComponentModel.INotifyPropertyChanged {
        
        private FdoJoinSource leftField;
        
        private FdoJoinSource rightField;
        
        private FdoJoinTarget targetField;
        
        private FdoJoinSettings joinSettingsField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FdoJoinSource Left {
            get {
                return this.leftField;
            }
            set {
                this.leftField = value;
                this.RaisePropertyChanged("Left");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FdoJoinSource Right {
            get {
                return this.rightField;
            }
            set {
                this.rightField = value;
                this.RaisePropertyChanged("Right");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FdoJoinTarget Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
                this.RaisePropertyChanged("Target");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FdoJoinSettings JoinSettings {
            get {
                return this.joinSettingsField;
            }
            set {
                this.joinSettingsField = value;
                this.RaisePropertyChanged("JoinSettings");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoJoinSource : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string providerField;
        
        private string connectionStringField;
        
        private string featureSchemaField;
        
        private string classField;
        
        private string[] propertyListField;
        
        private string prefixField;
        
        private string filterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Provider {
            get {
                return this.providerField;
            }
            set {
                this.providerField = value;
                this.RaisePropertyChanged("Provider");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ConnectionString {
            get {
                return this.connectionStringField;
            }
            set {
                this.connectionStringField = value;
                this.RaisePropertyChanged("ConnectionString");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FeatureSchema {
            get {
                return this.featureSchemaField;
            }
            set {
                this.featureSchemaField = value;
                this.RaisePropertyChanged("FeatureSchema");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
                this.RaisePropertyChanged("Class");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Property", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] PropertyList {
            get {
                return this.propertyListField;
            }
            set {
                this.propertyListField = value;
                this.RaisePropertyChanged("PropertyList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Prefix {
            get {
                return this.prefixField;
            }
            set {
                this.prefixField = value;
                this.RaisePropertyChanged("Prefix");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
                this.RaisePropertyChanged("Filter");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class JoinKey : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string leftField;
        
        private string rightField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string left {
            get {
                return this.leftField;
            }
            set {
                this.leftField = value;
                this.RaisePropertyChanged("left");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string right {
            get {
                return this.rightField;
            }
            set {
                this.rightField = value;
                this.RaisePropertyChanged("right");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoDesignatedGeometry : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string propertyField;
        
        private JoinSide sideField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
                this.RaisePropertyChanged("Property");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public JoinSide Side {
            get {
                return this.sideField;
            }
            set {
                this.sideField = value;
                this.RaisePropertyChanged("Side");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    public enum JoinSide {
        
        /// <remarks/>
        Left,
        
        /// <remarks/>
        Right,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoJoinSettings : object, System.ComponentModel.INotifyPropertyChanged {
        
        private JoinType joinTypeField;
        
        private FdoDesignatedGeometry designatedGeometryField;
        
        private JoinKey[] joinKeysField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public JoinType JoinType {
            get {
                return this.joinTypeField;
            }
            set {
                this.joinTypeField = value;
                this.RaisePropertyChanged("JoinType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FdoDesignatedGeometry DesignatedGeometry {
            get {
                return this.designatedGeometryField;
            }
            set {
                this.designatedGeometryField = value;
                this.RaisePropertyChanged("DesignatedGeometry");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Join", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public JoinKey[] JoinKeys {
            get {
                return this.joinKeysField;
            }
            set {
                this.joinKeysField = value;
                this.RaisePropertyChanged("JoinKeys");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    public enum JoinType {
        
        /// <remarks/>
        Inner,
        
        /// <remarks/>
        Left,
        
        /// <remarks/>
        Right,
        
        /// <remarks/>
        Full,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoJoinTarget : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string providerField;
        
        private string connectionStringField;
        
        private string featureSchemaField;
        
        private string classField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Provider {
            get {
                return this.providerField;
            }
            set {
                this.providerField = value;
                this.RaisePropertyChanged("Provider");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ConnectionString {
            get {
                return this.connectionStringField;
            }
            set {
                this.connectionStringField = value;
                this.RaisePropertyChanged("ConnectionString");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FeatureSchema {
            get {
                return this.featureSchemaField;
            }
            set {
                this.featureSchemaField = value;
                this.RaisePropertyChanged("FeatureSchema");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
                this.RaisePropertyChanged("Class");
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
}
