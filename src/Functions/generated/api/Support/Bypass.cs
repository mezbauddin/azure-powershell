// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices
    /// (For example, "Logging, Metrics"), or None to bypass none of those traffics.
    /// </summary>
    public partial struct Bypass :
        System.IEquatable<Bypass>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass AzureServices = @"AzureServices";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass Logging = @"Logging";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass Metrics = @"Metrics";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass None = @"None";

        /// <summary>the value for an instance of the <see cref="Bypass" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="Bypass"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private Bypass(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to Bypass</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Bypass" />.</param>
        internal static object CreateFrom(object value)
        {
            return new Bypass(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type Bypass</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type Bypass (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is Bypass && Equals((Bypass)obj);
        }

        /// <summary>Returns hashCode for enum Bypass</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for Bypass</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to Bypass</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Bypass" />.</param>

        public static implicit operator Bypass(string value)
        {
            return new Bypass(value);
        }

        /// <summary>Implicit operator to convert Bypass to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="Bypass" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum Bypass</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum Bypass</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Bypass e2)
        {
            return e2.Equals(e1);
        }
    }
}