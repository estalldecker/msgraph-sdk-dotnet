using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum TeamworkApplicationIdentityType {
        [EnumMember(Value = "aadApplication")]
        AadApplication,
        [EnumMember(Value = "bot")]
        Bot,
        [EnumMember(Value = "tenantBot")]
        TenantBot,
        [EnumMember(Value = "office365Connector")]
        Office365Connector,
        [EnumMember(Value = "outgoingWebhook")]
        OutgoingWebhook,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
