using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ConnectionDirection {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "inbound")]
        Inbound,
        [EnumMember(Value = "outbound")]
        Outbound,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
