using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ExternalAudienceScope {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "contactsOnly")]
        ContactsOnly,
        [EnumMember(Value = "all")]
        All,
    }
}
