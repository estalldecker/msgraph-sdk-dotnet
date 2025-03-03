using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum EducationFeedbackResourceOutcomeStatus {
        [EnumMember(Value = "notPublished")]
        NotPublished,
        [EnumMember(Value = "pendingPublish")]
        PendingPublish,
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "failedPublish")]
        FailedPublish,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
