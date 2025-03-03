using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.TermStore {
    public enum TermGroupScope {
        [EnumMember(Value = "global")]
        Global,
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "siteCollection")]
        SiteCollection,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
