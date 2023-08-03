﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Gen.Metering {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Gen.Metering.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Tag name {0} is defined more than once. Metric tag names must be unique.
        /// </summary>
        internal static string ErrorDuplicateTagNameMessage {
            get {
                return ResourceManager.GetString("ErrorDuplicateTagNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A strong type object contains duplicate tag names.
        /// </summary>
        internal static string ErrorDuplicateTagNameTitle {
            get {
                return ResourceManager.GetString("ErrorDuplicateTagNameTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gauge is not supported yet by metering generator.
        /// </summary>
        internal static string ErrorGaugeNotSupportedMessage {
            get {
                return ResourceManager.GetString("ErrorGaugeNotSupportedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gauge is not supported yet.
        /// </summary>
        internal static string ErrorGaugeNotSupportedTitle {
            get {
                return ResourceManager.GetString("ErrorGaugeNotSupportedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A type &apos;{0}&apos; cannot be used as a metering attribute type argument.
        /// </summary>
        internal static string ErrorInvalidAttributeGenericTypeMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidAttributeGenericTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A metering attribute type argument is invalid.
        /// </summary>
        internal static string ErrorInvalidAttributeGenericTypeTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidAttributeGenericTypeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric method names cannot start with _.
        /// </summary>
        internal static string ErrorInvalidMethodNameMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric method names can&apos;t start with an underscore.
        /// </summary>
        internal static string ErrorInvalidMethodNameTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodNameTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric method &apos;{0}&apos; has return type &apos;{1}&apos; that is generic.
        /// </summary>
        internal static string ErrorInvalidMethodReturnTypeArityMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodReturnTypeArityMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods mustn&apos;t use any generic type as the return type.
        /// </summary>
        internal static string ErrorInvalidMethodReturnTypeArityTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodReturnTypeArityTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric method &apos;{0}&apos; has return type &apos;{1}&apos; that is defined in another namespace/class.
        /// </summary>
        internal static string ErrorInvalidMethodReturnTypeLocationMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodReturnTypeLocationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods mustn&apos;t use any external type as the return type.
        /// </summary>
        internal static string ErrorInvalidMethodReturnTypeLocationTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodReturnTypeLocationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods must not return &apos;{0}&apos; type.
        /// </summary>
        internal static string ErrorInvalidMethodReturnTypeMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodReturnTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods mustn&apos;t use any existing type as the return type.
        /// </summary>
        internal static string ErrorInvalidMethodReturnTypeTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodReturnTypeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric name {0} is invalid. It must be non empty and start with an alphabetic character.
        /// </summary>
        internal static string ErrorInvalidMetricNameMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidMetricNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric names must start with an uppercase alphabetic character.
        /// </summary>
        internal static string ErrorInvalidMetricNameTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidMetricNameTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric method parameter names cannot start with _.
        /// </summary>
        internal static string ErrorInvalidParameterNameMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidParameterNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric method parameter names can&apos;t start with an underscore.
        /// </summary>
        internal static string ErrorInvalidParameterNameTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidParameterNameTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tag names should contain alphanumeric characters and only allowed symbols.
        /// </summary>
        internal static string ErrorInvalidTagNamesMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidTagNamesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tag names should only contain alphanumeric characters and allowed symbols.
        /// </summary>
        internal static string ErrorInvalidTagNamesTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidTagNamesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tag name type. Valid types are string and enum.
        /// </summary>
        internal static string ErrorInvalidTagTypeMessage {
            get {
                return ResourceManager.GetString("ErrorInvalidTagTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A metric class contains an invalid tag name type.
        /// </summary>
        internal static string ErrorInvalidTagTypeTitle {
            get {
                return ResourceManager.GetString("ErrorInvalidTagTypeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods cannot have a body.
        /// </summary>
        internal static string ErrorMethodHasBodyMessage {
            get {
                return ResourceManager.GetString("ErrorMethodHasBodyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods can&apos;t have a body.
        /// </summary>
        internal static string ErrorMethodHasBodyTitle {
            get {
                return ResourceManager.GetString("ErrorMethodHasBodyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods cannot be generic.
        /// </summary>
        internal static string ErrorMethodIsGenericMessage {
            get {
                return ResourceManager.GetString("ErrorMethodIsGenericMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods can&apos;t be generic.
        /// </summary>
        internal static string ErrorMethodIsGenericTitle {
            get {
                return ResourceManager.GetString("ErrorMethodIsGenericTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple metric methods are using metric name {0}.
        /// </summary>
        internal static string ErrorMetricNameReuseMessage {
            get {
                return ResourceManager.GetString("ErrorMetricNameReuseMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple metric methods can&apos;t use the same metric name.
        /// </summary>
        internal static string ErrorMetricNameReuseTitle {
            get {
                return ResourceManager.GetString("ErrorMetricNameReuseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First parameter should be of System.Diagnostics.Metrics.Meter type.
        /// </summary>
        internal static string ErrorMissingMeterMessage {
            get {
                return ResourceManager.GetString("ErrorMissingMeterMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first parameter should be of type `System.Diagnostics.Metrics.Meter`.
        /// </summary>
        internal static string ErrorMissingMeterTitle {
            get {
                return ResourceManager.GetString("ErrorMissingMeterTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods must be partial.
        /// </summary>
        internal static string ErrorNotPartialMethodMessage {
            get {
                return ResourceManager.GetString("ErrorNotPartialMethodMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods must be partial.
        /// </summary>
        internal static string ErrorNotPartialMethodTitle {
            get {
                return ResourceManager.GetString("ErrorNotPartialMethodTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods must be static.
        /// </summary>
        internal static string ErrorNotStaticMethodMessage {
            get {
                return ResourceManager.GetString("ErrorNotStaticMethodMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metric methods must be static.
        /// </summary>
        internal static string ErrorNotStaticMethodTitle {
            get {
                return ResourceManager.GetString("ErrorNotStaticMethodTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} has a cycle in its hierarchy: {1} ⇆ {2}.
        /// </summary>
        internal static string ErrorTagTypeCycleDetectedMessage {
            get {
                return ResourceManager.GetString("ErrorTagTypeCycleDetectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A metric class has cycles in its type hierarchy.
        /// </summary>
        internal static string ErrorTagTypeCycleDetectedTitle {
            get {
                return ResourceManager.GetString("ErrorTagTypeCycleDetectedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} has too many tag names.
        /// </summary>
        internal static string ErrorTooManyTagNamesMessage {
            get {
                return ResourceManager.GetString("ErrorTooManyTagNamesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A metric class contains too many tag names.
        /// </summary>
        internal static string ErrorTooManyTagNamesTitle {
            get {
                return ResourceManager.GetString("ErrorTooManyTagNamesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Xml comment was not parsed correctly, exception {0} was thrown.
        /// </summary>
        internal static string ErrorXmlNotLoadedCorrectlyMessage {
            get {
                return ResourceManager.GetString("ErrorXmlNotLoadedCorrectlyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Xml comment was not parsed correctly.
        /// </summary>
        internal static string ErrorXmlNotLoadedCorrectlyTitle {
            get {
                return ResourceManager.GetString("ErrorXmlNotLoadedCorrectlyTitle", resourceCulture);
            }
        }
    }
}
