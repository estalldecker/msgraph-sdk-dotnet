using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum IosUpdatesInstallStatus {
        [EnumMember(Value = "deviceOsHigherThanDesiredOsVersion")]
        DeviceOsHigherThanDesiredOsVersion,
        [EnumMember(Value = "sharedDeviceUserLoggedInError")]
        SharedDeviceUserLoggedInError,
        [EnumMember(Value = "notSupportedOperation")]
        NotSupportedOperation,
        [EnumMember(Value = "installFailed")]
        InstallFailed,
        [EnumMember(Value = "installPhoneCallInProgress")]
        InstallPhoneCallInProgress,
        [EnumMember(Value = "installInsufficientPower")]
        InstallInsufficientPower,
        [EnumMember(Value = "installInsufficientSpace")]
        InstallInsufficientSpace,
        [EnumMember(Value = "installing")]
        Installing,
        [EnumMember(Value = "downloadInsufficientNetwork")]
        DownloadInsufficientNetwork,
        [EnumMember(Value = "downloadInsufficientPower")]
        DownloadInsufficientPower,
        [EnumMember(Value = "downloadInsufficientSpace")]
        DownloadInsufficientSpace,
        [EnumMember(Value = "downloadRequiresComputer")]
        DownloadRequiresComputer,
        [EnumMember(Value = "downloadFailed")]
        DownloadFailed,
        [EnumMember(Value = "downloading")]
        Downloading,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "idle")]
        Idle,
        [EnumMember(Value = "unknown")]
        Unknown,
    }
}
