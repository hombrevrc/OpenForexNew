﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForexPlatformFrontEnd.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DeveloperMode {
            get {
                return ((bool)(this["DeveloperMode"]));
            }
            set {
                this["DeveloperMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SingleInstanceMode {
            get {
                return ((bool)(this["SingleInstanceMode"]));
            }
            set {
                this["SingleInstanceMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("net.tcp://localhost:13123/TradingAPI")]
        public string DefaultMT4IntegrationAddress {
            get {
                return ((string)(this["DefaultMT4IntegrationAddress"]));
            }
            set {
                this["DefaultMT4IntegrationAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("net.tcp://localhost:17992/Platform/")]
        public string PlatformUriAddress {
            get {
                return ((string)(this["PlatformUriAddress"]));
            }
            set {
                this["PlatformUriAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.openforexplatform.com/app/onlinedatasources.xml")]
        public string DataStoreOnlineSourcesXml {
            get {
                return ((string)(this["DataStoreOnlineSourcesXml"]));
            }
            set {
                this["DataStoreOnlineSourcesXml"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\Output.Logs\\Platform\\ForexPlatform.FrontEnd.{DateTime}.log")]
        public string TraceLogFile {
            get {
                return ((string)(this["TraceLogFile"]));
            }
            set {
                this["TraceLogFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\Files")]
        public string FilesFolder {
            get {
                return ((string)(this["FilesFolder"]));
            }
            set {
                this["FilesFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\Files.Data\\Experts")]
        public string ExpertsFolder {
            get {
                return ((string)(this["ExpertsFolder"]));
            }
            set {
                this["ExpertsFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\Files.Data\\platform.s3db")]
        public string PlatformDBPath {
            get {
                return ((string)(this["PlatformDBPath"]));
            }
            set {
                this["PlatformDBPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\Files.Data\\datastore.s3db")]
        public string DataStoreDBPath {
            get {
                return ((string)(this["DataStoreDBPath"]));
            }
            set {
                this["DataStoreDBPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\Files.Data\\events.s3db")]
        public string EventsDBPath {
            get {
                return ((string)(this["EventsDBPath"]));
            }
            set {
                this["EventsDBPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\Files.Data\\DataStore")]
        public string DataStoreFolder {
            get {
                return ((string)(this["DataStoreFolder"]));
            }
            set {
                this["DataStoreFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MT4Adapter.dll\r\nMBTradingAdapter.dll\r\nFXCMAdapter.dll")]
        public string OptionalModules {
            get {
                return ((string)(this["OptionalModules"]));
            }
            set {
                this["OptionalModules"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowPerformanceCounters {
            get {
                return ((bool)(this["AllowPerformanceCounters"]));
            }
            set {
                this["AllowPerformanceCounters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"http://www.forbes.com/business/index.xml
http://www.forbes.com/markets/index.xml
http://rss.businessweek.com/bw_rss/bwdaily
http://rss.businessweek.com/bw_rss/bwdaily
http://rss.businessweek.com/bw_rss/asiaindex
http://rss.businessweek.com/bw_rss/europeindex
http://rss.businessweek.com/bw_rss/investor
http://rss.cnn.com/rss/money_news_economy.rss
http://finance.yahoo.com/rss/CreditServices
http://feeds.reuters.com/reuters/businessNews?format=xml
http://feeds.marketwatch.com/marketwatch/bulletins?format=xml
http://feeds.marketwatch.com/marketwatch/realtimeheadlines/
http://news.google.com/?ned=us&topic=b&output=rss
http://www.federalreserve.gov/feeds/press_all.xml
http://www.telegraph.co.uk/finance/rss")]
        public string DefaultRSSFeeds {
            get {
                return ((string)(this["DefaultRSSFeeds"]));
            }
            set {
                this["DefaultRSSFeeds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"..\Output.Modules\HedgeExpertModule.dll
..\Output.Modules\IntegralAdapter.dll
..\Output.Modules\Experts.dll
..\Output.Modules\MTAS.dll
..\Output.Modules\DukasCopyAdapter.dll
..\Output.Modules\OFxP.SuperPoolIntegration.dll
..\Output.Modules\CommonFIX.dll
..\Output.Modules\MT4OrderDuplication.dll")]
        public string ExternalModules {
            get {
                return ((string)(this["ExternalModules"]));
            }
            set {
                this["ExternalModules"] = value;
            }
        }
    }
}
