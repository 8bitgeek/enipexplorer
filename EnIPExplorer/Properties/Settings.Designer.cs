﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.17929
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnIPExplorer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int TCP_LAN_Timeout {
            get {
                return ((int)(this["TCP_LAN_Timeout"]));
            }
            set {
                this["TCP_LAN_Timeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int TCP_WAN_TimeOut {
            get {
                return ((int)(this["TCP_WAN_TimeOut"]));
            }
            set {
                this["TCP_WAN_TimeOut"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConfirmDeleteDevice {
            get {
                return ((bool)(this["ConfirmDeleteDevice"]));
            }
            set {
                this["ConfirmDeleteDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ConfirmDeleteOthers {
            get {
                return ((bool)(this["ConfirmDeleteOthers"]));
            }
            set {
                this["ConfirmDeleteOthers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultTreeFile {
            get {
                return ((string)(this["DefaultTreeFile"]));
            }
            set {
                this["DefaultTreeFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Size GUI_FormSize {
            get {
                return ((global::System.Drawing.Size)(this["GUI_FormSize"]));
            }
            set {
                this["GUI_FormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultRemoteDevice {
            get {
                return ((string)(this["DefaultRemoteDevice"]));
            }
            set {
                this["DefaultRemoteDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(";")]
        public char CSVSeparator {
            get {
                return ((char)(this["CSVSeparator"]));
            }
            set {
                this["CSVSeparator"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState GUI_State {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["GUI_State"]));
            }
            set {
                this["GUI_State"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowNodeToolTip {
            get {
                return ((bool)(this["ShowNodeToolTip"]));
            }
            set {
                this["ShowNodeToolTip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public uint ForwardOpenPeriod_ms {
            get {
                return ((uint)(this["ForwardOpenPeriod_ms"]));
            }
            set {
                this["ForwardOpenPeriod_ms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public byte ForwardOpenDuration_s {
            get {
                return ((byte)(this["ForwardOpenDuration_s"]));
            }
            set {
                this["ForwardOpenDuration_s"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int PeriodicUpdateRate {
            get {
                return ((int)(this["PeriodicUpdateRate"]));
            }
            set {
                this["PeriodicUpdateRate"] = value;
            }
        }
    }
}
