using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ScreenSharingRole {
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "sharer")]
        Sharer,
    }
}
