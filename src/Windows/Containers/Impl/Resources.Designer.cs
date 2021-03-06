﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.R.Containers {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.R.Containers.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Failed to delete container with id: {0}
        ///{1}.
        /// </summary>
        internal static string Error_ContainerDeleteFailed {
            get {
                return ResourceManager.GetString("Error_ContainerDeleteFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid container id: {0}.
        /// </summary>
        internal static string Error_ContainerIdInvalid {
            get {
                return ResourceManager.GetString("Error_ContainerIdInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start container with id: {0}
        ///{1}.
        /// </summary>
        internal static string Error_ContainerStartFailed {
            get {
                return ResourceManager.GetString("Error_ContainerStartFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to stop container with id: {0}
        ///{1}.
        /// </summary>
        internal static string Error_ContainerStopFailed {
            get {
                return ResourceManager.GetString("Error_ContainerStopFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Docker for windows.exe&quot; is not running..
        /// </summary>
        internal static string Error_DockerForWindowsNotRunning {
            get {
                return ResourceManager.GetString("Error_DockerForWindowsNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find Docker installation at &quot;{0}&quot;..
        /// </summary>
        internal static string Error_DockerNotFound {
            get {
                return ResourceManager.GetString("Error_DockerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Docker windows service &quot;com.docker.service&quot; is not running, status: {0}.
        /// </summary>
        internal static string Error_DockerServiceNotRunning {
            get {
                return ResourceManager.GetString("Error_DockerServiceNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the required Docker command at &quot;{0}&quot;..
        /// </summary>
        internal static string Error_NoDockerCommand {
            get {
                return ResourceManager.GetString("Error_NoDockerCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container service is not available. Check if &quot;{0}&quot; is installed and running..
        /// </summary>
        internal static string Error_ServiceNotAvailable {
            get {
                return ResourceManager.GetString("Error_ServiceNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You don&apos;t have permissions to use docker. Please add user &quot;{0}&quot; to &quot;{1}&quot; group..
        /// </summary>
        internal static string Error_UserNotInDockerUsersGroup {
            get {
                return ResourceManager.GetString("Error_UserNotInDockerUsersGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container service is available..
        /// </summary>
        internal static string Info_ServiceAvailable {
            get {
                return ResourceManager.GetString("Info_ServiceAvailable", resourceCulture);
            }
        }
    }
}
