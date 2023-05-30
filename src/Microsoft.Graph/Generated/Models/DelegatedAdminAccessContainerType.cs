using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum DelegatedAdminAccessContainerType {
        [EnumMember(Value = "securityGroup")]
        SecurityGroup,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
