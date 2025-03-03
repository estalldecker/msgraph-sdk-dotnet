using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum TeamworkUserIdentityType {
        [EnumMember(Value = "aadUser")]
        AadUser,
        [EnumMember(Value = "onPremiseAadUser")]
        OnPremiseAadUser,
        [EnumMember(Value = "anonymousGuest")]
        AnonymousGuest,
        [EnumMember(Value = "federatedUser")]
        FederatedUser,
        [EnumMember(Value = "personalMicrosoftAccountUser")]
        PersonalMicrosoftAccountUser,
        [EnumMember(Value = "skypeUser")]
        SkypeUser,
        [EnumMember(Value = "phoneUser")]
        PhoneUser,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "emailUser")]
        EmailUser,
    }
}
