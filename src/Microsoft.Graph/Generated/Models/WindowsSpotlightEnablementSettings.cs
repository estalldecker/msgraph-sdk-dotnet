using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Allows IT admind to set a predefined default search engine for MDM-Controlled devices</summary>
    public enum WindowsSpotlightEnablementSettings {
        /// <summary>Spotlight on lock screen is not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Disable Windows Spotlight on lock screen</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Enable Windows Spotlight on lock screen</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
    }
}
