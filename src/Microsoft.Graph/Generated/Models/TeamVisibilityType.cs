using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum TeamVisibilityType {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "hiddenMembership")]
        HiddenMembership,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
