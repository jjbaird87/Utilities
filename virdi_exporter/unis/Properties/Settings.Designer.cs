﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VIRDI_CLOCKING_COLLECTOR.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ANVJHB-PC\\DEV_SQLEXPRESS;Initial Catalog=UNIS;Persist Security Info=T" +
            "rue;User ID=jj")]
        public string UNISConnectionString {
            get {
                return ((string)(this["UNISConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.ListDictionary DeviceSettings {
            get {
                return ((global::System.Collections.Specialized.ListDictionary)(this["DeviceSettings"]));
            }
            set {
                this["DeviceSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.ArrayList Dataviewsetting {
            get {
                return ((global::System.Collections.ArrayList)(this["Dataviewsetting"]));
            }
            set {
                this["Dataviewsetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.ArrayList col1 {
            get {
                return ((global::System.Collections.ArrayList)(this["col1"]));
            }
            set {
                this["col1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.ArrayList col2 {
            get {
                return ((global::System.Collections.ArrayList)(this["col2"]));
            }
            set {
                this["col2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.ArrayList col3 {
            get {
                return ((global::System.Collections.ArrayList)(this["col3"]));
            }
            set {
                this["col3"] = value;
            }
        }
    }
}
