using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.CallRecords {
    public enum PstnCallDurationSource {
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "operator")]
        Operator,
    }
}
