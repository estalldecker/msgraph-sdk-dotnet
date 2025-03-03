using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum CallTranscriptionState {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
