using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ColumnTypes {
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "choice")]
        Choice,
        [EnumMember(Value = "multichoice")]
        Multichoice,
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "currency")]
        Currency,
        [EnumMember(Value = "dateTime")]
        DateTime,
        [EnumMember(Value = "lookup")]
        Lookup,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "calculated")]
        Calculated,
        [EnumMember(Value = "location")]
        Location,
        [EnumMember(Value = "geolocation")]
        Geolocation,
        [EnumMember(Value = "term")]
        Term,
        [EnumMember(Value = "multiterm")]
        Multiterm,
        [EnumMember(Value = "thumbnail")]
        Thumbnail,
        [EnumMember(Value = "approvalStatus")]
        ApprovalStatus,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
