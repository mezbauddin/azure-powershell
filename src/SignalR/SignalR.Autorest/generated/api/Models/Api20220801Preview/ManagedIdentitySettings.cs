// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Managed identity settings for upstream.</summary>
    public partial class ManagedIdentitySettings :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IManagedIdentitySettings,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IManagedIdentitySettingsInternal
    {

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private string _resource;

        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string Resource { get => this._resource; set => this._resource = value; }

        /// <summary>Creates an new <see cref="ManagedIdentitySettings" /> instance.</summary>
        public ManagedIdentitySettings()
        {

        }
    }
    /// Managed identity settings for upstream.
    public partial interface IManagedIdentitySettings :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Resource indicating the App ID URI of the target resource.
        It also appears in the aud (audience) claim of the issued token.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string Resource { get; set; }

    }
    /// Managed identity settings for upstream.
    internal partial interface IManagedIdentitySettingsInternal

    {
        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        string Resource { get; set; }

    }
}