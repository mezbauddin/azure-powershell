// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>CsmPublishingCredentialsPoliciesCollection resource specific properties</summary>
    [System.ComponentModel.TypeConverter(typeof(CsmPublishingCredentialsPoliciesCollectionPropertiesTypeConverter))]
    public partial class CsmPublishingCredentialsPoliciesCollectionProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesCollectionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CsmPublishingCredentialsPoliciesCollectionProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Ftp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).Ftp = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesEntity) content.GetValueForProperty("Ftp",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).Ftp, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesEntityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Scm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).Scm = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesEntity) content.GetValueForProperty("Scm",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).Scm, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesEntityTypeConverter.ConvertFrom);
            }
            if (content.Contains("FtpId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpId = (string) content.GetValueForProperty("FtpId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpId, global::System.Convert.ToString);
            }
            if (content.Contains("FtpName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpName = (string) content.GetValueForProperty("FtpName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpName, global::System.Convert.ToString);
            }
            if (content.Contains("FtpKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpKind = (string) content.GetValueForProperty("FtpKind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpKind, global::System.Convert.ToString);
            }
            if (content.Contains("FtpType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpType = (string) content.GetValueForProperty("FtpType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpType, global::System.Convert.ToString);
            }
            if (content.Contains("FtpProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesEntityProperties) content.GetValueForProperty("FtpProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesEntityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmId = (string) content.GetValueForProperty("ScmId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmId, global::System.Convert.ToString);
            }
            if (content.Contains("ScmName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmName = (string) content.GetValueForProperty("ScmName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmName, global::System.Convert.ToString);
            }
            if (content.Contains("ScmKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmKind = (string) content.GetValueForProperty("ScmKind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmKind, global::System.Convert.ToString);
            }
            if (content.Contains("ScmType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmType = (string) content.GetValueForProperty("ScmType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmType, global::System.Convert.ToString);
            }
            if (content.Contains("ScmProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesEntityProperties) content.GetValueForProperty("ScmProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesEntityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("FtpPropertiesAllow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpPropertiesAllow = (bool) content.GetValueForProperty("FtpPropertiesAllow",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpPropertiesAllow, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ScmPropertiesAllow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmPropertiesAllow = (bool) content.GetValueForProperty("ScmPropertiesAllow",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmPropertiesAllow, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesCollectionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CsmPublishingCredentialsPoliciesCollectionProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Ftp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).Ftp = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesEntity) content.GetValueForProperty("Ftp",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).Ftp, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesEntityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Scm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).Scm = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesEntity) content.GetValueForProperty("Scm",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).Scm, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesEntityTypeConverter.ConvertFrom);
            }
            if (content.Contains("FtpId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpId = (string) content.GetValueForProperty("FtpId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpId, global::System.Convert.ToString);
            }
            if (content.Contains("FtpName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpName = (string) content.GetValueForProperty("FtpName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpName, global::System.Convert.ToString);
            }
            if (content.Contains("FtpKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpKind = (string) content.GetValueForProperty("FtpKind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpKind, global::System.Convert.ToString);
            }
            if (content.Contains("FtpType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpType = (string) content.GetValueForProperty("FtpType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpType, global::System.Convert.ToString);
            }
            if (content.Contains("FtpProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesEntityProperties) content.GetValueForProperty("FtpProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesEntityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmId = (string) content.GetValueForProperty("ScmId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmId, global::System.Convert.ToString);
            }
            if (content.Contains("ScmName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmName = (string) content.GetValueForProperty("ScmName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmName, global::System.Convert.ToString);
            }
            if (content.Contains("ScmKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmKind = (string) content.GetValueForProperty("ScmKind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmKind, global::System.Convert.ToString);
            }
            if (content.Contains("ScmType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmType = (string) content.GetValueForProperty("ScmType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmType, global::System.Convert.ToString);
            }
            if (content.Contains("ScmProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesEntityProperties) content.GetValueForProperty("ScmProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesEntityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("FtpPropertiesAllow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpPropertiesAllow = (bool) content.GetValueForProperty("FtpPropertiesAllow",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).FtpPropertiesAllow, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ScmPropertiesAllow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmPropertiesAllow = (bool) content.GetValueForProperty("ScmPropertiesAllow",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionPropertiesInternal)this).ScmPropertiesAllow, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesCollectionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CsmPublishingCredentialsPoliciesCollectionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CsmPublishingCredentialsPoliciesCollectionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CsmPublishingCredentialsPoliciesCollectionProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CsmPublishingCredentialsPoliciesCollectionProperties" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="CsmPublishingCredentialsPoliciesCollectionProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICsmPublishingCredentialsPoliciesCollectionProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// CsmPublishingCredentialsPoliciesCollection resource specific properties
    [System.ComponentModel.TypeConverter(typeof(CsmPublishingCredentialsPoliciesCollectionPropertiesTypeConverter))]
    public partial interface ICsmPublishingCredentialsPoliciesCollectionProperties

    {

    }
}