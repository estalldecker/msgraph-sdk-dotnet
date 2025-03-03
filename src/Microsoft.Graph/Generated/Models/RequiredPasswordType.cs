using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Possible values of required passwords.</summary>
    public enum RequiredPasswordType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Alphanumeric password required.</summary>
        [EnumMember(Value = "alphanumeric")]
        Alphanumeric,
        /// <summary>Numeric password required.</summary>
        [EnumMember(Value = "numeric")]
        Numeric,
    }
}
