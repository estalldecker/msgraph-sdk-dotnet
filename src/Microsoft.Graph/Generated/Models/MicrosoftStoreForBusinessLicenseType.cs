using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum MicrosoftStoreForBusinessLicenseType {
        [EnumMember(Value = "offline")]
        Offline,
        [EnumMember(Value = "online")]
        Online,
    }
}
