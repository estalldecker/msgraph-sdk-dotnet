using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ExternalEmailOtpState {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
