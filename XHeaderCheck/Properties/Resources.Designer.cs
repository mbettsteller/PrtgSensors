﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrtgSensors.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PrtgSensors.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to  could not be found..
        /// </summary>
        internal static string could_not_be_found_ {
            get {
                return ResourceManager.GetString("could_not_be_found_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No URL specified!.
        /// </summary>
        internal static string No_URL_specified_ {
            get {
                return ResourceManager.GetString("No_URL_specified_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PRTGError.
        /// </summary>
        internal static string PRTGError {
            get {
                return ResourceManager.GetString("PRTGError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expected header .
        /// </summary>
        internal static string The_expected_header_ {
            get {
                return ResourceManager.GetString("The_expected_header_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to usage:
        ///.
        /// </summary>
        internal static string usage {
            get {
                return ResourceManager.GetString("usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  -url:&lt;URL&gt; -headers:&lt;header to get, if multiple, separated by comma&gt; [-proxy:&lt;PROXY&gt;]
        ///
        ///
        ///The PROXY parameter is optional, in case you have a server that expects a specific url. Example: you have a load balancer that is splitting your URL www.yourcompany.com/endpoint.html to the servers server1 and server2. Then you write the command parameters like this:
        ///
        /// -url:www.yourserver.com/endpoint.html -proxy:server1 -header:X-My-Header.
        /// </summary>
        internal static string XHeaderCheck_usage {
            get {
                return ResourceManager.GetString("XHeaderCheck_usage", resourceCulture);
            }
        }
    }
}
