﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProtoMiddler.Tests.Resources {
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
    internal class Samples {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Samples() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProtoMiddler.Tests.Resources.Samples", typeof(Samples).Assembly);
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] proto {
            get {
                object obj = ResourceManager.GetObject("proto", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1: &quot;6016714f-a8a7-43cb-8d1f-761f088e18a7&quot;
        ///2: 0x08d271a2c7ae8777
        ///3: 0x08d271a2c7ae8777
        ///4: &quot;642c63d088a64d9b80c789d3b9ac89ef@diadoc.ru&quot;
        ///5: &quot;\320\242\320\265\321\201\321\202\320\276\320\262\320\260\321\217 \320\276\321\200\320\263\320\260\320\275\320\270\320\267\320\260\321\206\320\270\321\217 \342\204\2269962578&quot;
        ///6: &quot;e05395bc9f0c4883b127385e359a1ea3@diadoc.ru&quot;
        ///7: &quot;\320\242\320\265\321\201\321\202\320\276\320\262\320\260\321\217 \320\276\321\200\320\263\320\260\320\275\320\270\320\267\320\260\321\206\320 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string raw_schema {
            get {
                return ResourceManager.GetString("raw_schema", resourceCulture);
            }
        }
    }
}
