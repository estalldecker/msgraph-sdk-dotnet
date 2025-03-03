using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.CallRecords {
    public enum VideoCodec {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "av1")]
        Av1,
        [EnumMember(Value = "h263")]
        H263,
        [EnumMember(Value = "h264")]
        H264,
        [EnumMember(Value = "h264s")]
        H264s,
        [EnumMember(Value = "h264uc")]
        H264uc,
        [EnumMember(Value = "h265")]
        H265,
        [EnumMember(Value = "rtvc1")]
        Rtvc1,
        [EnumMember(Value = "rtVideo")]
        RtVideo,
        [EnumMember(Value = "xrtvc1")]
        Xrtvc1,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
