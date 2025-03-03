using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum PrintJobStateDetail {
        [EnumMember(Value = "uploadPending")]
        UploadPending,
        [EnumMember(Value = "transforming")]
        Transforming,
        [EnumMember(Value = "completedSuccessfully")]
        CompletedSuccessfully,
        [EnumMember(Value = "completedWithWarnings")]
        CompletedWithWarnings,
        [EnumMember(Value = "completedWithErrors")]
        CompletedWithErrors,
        [EnumMember(Value = "releaseWait")]
        ReleaseWait,
        [EnumMember(Value = "interpreting")]
        Interpreting,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
