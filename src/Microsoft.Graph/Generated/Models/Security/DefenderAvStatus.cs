using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum DefenderAvStatus {
        [EnumMember(Value = "notReporting")]
        NotReporting,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "notUpdated")]
        NotUpdated,
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "notSupported")]
        NotSupported,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
