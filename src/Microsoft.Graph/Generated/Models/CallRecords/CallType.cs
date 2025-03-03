using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.CallRecords {
    public enum CallType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "groupCall")]
        GroupCall,
        [EnumMember(Value = "peerToPeer")]
        PeerToPeer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
