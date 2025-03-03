using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum PrintScaling {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "shrinkToFit")]
        ShrinkToFit,
        [EnumMember(Value = "fill")]
        Fill,
        [EnumMember(Value = "fit")]
        Fit,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
