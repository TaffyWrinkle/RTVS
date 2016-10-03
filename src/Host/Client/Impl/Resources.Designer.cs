﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.R.Host.Client {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.R.Host.Client.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 32 bit.
        /// </summary>
        internal static string Bits32 {
            get {
                return ResourceManager.GetString("Bits32", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 64 bit.
        /// </summary>
        internal static string Bits64 {
            get {
                return ResourceManager.GetString("Bits64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** Connected ***.
        /// </summary>
        internal static string Connected {
            get {
                return ResourceManager.GetString("Connected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The machine appears to be online, but the Remote R Service is not running..
        /// </summary>
        internal static string Error_BrokerNotRunning {
            get {
                return ResourceManager.GetString("Error_BrokerNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host did not respond to a ping.
        ///The machine may be offline or the network has been disconnected. Error: {0}.
        /// </summary>
        internal static string Error_HostNotResponding {
            get {
                return ResourceManager.GetString("Error_HostNotResponding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified R interpreter was not found.
        /// </summary>
        internal static string Error_InterpreterNotFound {
            get {
                return ResourceManager.GetString("Error_InterpreterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No R Interpreters installed.
        /// </summary>
        internal static string Error_NoRInterpreters {
            get {
                return ResourceManager.GetString("Error_NoRInterpreters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remote R host process did not start:  {0}.
        /// </summary>
        internal static string Error_UnableToStartHostException {
            get {
                return ResourceManager.GetString("Error_UnableToStartHostException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error.
        /// </summary>
        internal static string Error_UnknownError {
            get {
                return ResourceManager.GetString("Error_UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Free Physical Memory: {0} MB.
        /// </summary>
        internal static string FreePhysicalMemory {
            get {
                return ResourceManager.GetString("FreePhysicalMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Free Virtual Memory: {0} MB.
        /// </summary>
        internal static string FreeVirtualMemory {
            get {
                return ResourceManager.GetString("FreeVirtualMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP error while creating session: {0}.
        /// </summary>
        internal static string HttpErrorCreatingSession {
            get {
                return ResourceManager.GetString("HttpErrorCreatingSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installed R:.
        /// </summary>
        internal static string InstalledInterpreters {
            get {
                return ResourceManager.GetString("InstalledInterpreters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operating System: {0}.
        /// </summary>
        internal static string OperatingSystem {
            get {
                return ResourceManager.GetString("OperatingSystem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Platform: {0}.
        /// </summary>
        internal static string PlatformBits {
            get {
                return ResourceManager.GetString("PlatformBits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to R Process: {0}.
        /// </summary>
        internal static string ProcessBits {
            get {
                return ResourceManager.GetString("ProcessBits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CPU Count: {0}.
        /// </summary>
        internal static string ProcessorCount {
            get {
                return ResourceManager.GetString("ProcessorCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interactive Window is disconnected from R Session.
        ///Open Workspaces window and either select local R interpreter or try connecting to a remote machine..
        /// </summary>
        internal static string RHostDisconnected {
            get {
                return ResourceManager.GetString("RHostDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to R Services Information:.
        /// </summary>
        internal static string RServices_Information {
            get {
                return ResourceManager.GetString("RServices_Information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting to R Workspace failed.
        ///Reason: {0}.
        /// </summary>
        internal static string RSessionProvider_ConnectionFailed {
            get {
                return ResourceManager.GetString("RSessionProvider_ConnectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Physical Memory: {0} MB.
        /// </summary>
        internal static string TotalPhysicalMemory {
            get {
                return ResourceManager.GetString("TotalPhysicalMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Virtual Memory: {0} MB.
        /// </summary>
        internal static string TotalVirtualMemory {
            get {
                return ResourceManager.GetString("TotalVirtualMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version: {0}.
        /// </summary>
        internal static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture);
            }
        }
    }
}
