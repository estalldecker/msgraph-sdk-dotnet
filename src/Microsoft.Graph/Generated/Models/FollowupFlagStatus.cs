using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum FollowupFlagStatus {
        [EnumMember(Value = "notFlagged")]
        NotFlagged,
        [EnumMember(Value = "complete")]
        Complete,
        [EnumMember(Value = "flagged")]
        Flagged,
    }
}
