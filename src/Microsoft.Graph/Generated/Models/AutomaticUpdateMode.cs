using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Possible values for automatic update mode.</summary>
    public enum AutomaticUpdateMode {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Notify on download.</summary>
        [EnumMember(Value = "notifyDownload")]
        NotifyDownload,
        /// <summary>Auto-install at maintenance time.</summary>
        [EnumMember(Value = "autoInstallAtMaintenanceTime")]
        AutoInstallAtMaintenanceTime,
        /// <summary>Auto-install and reboot at maintenance time.</summary>
        [EnumMember(Value = "autoInstallAndRebootAtMaintenanceTime")]
        AutoInstallAndRebootAtMaintenanceTime,
        /// <summary>Auto-install and reboot at scheduled time.</summary>
        [EnumMember(Value = "autoInstallAndRebootAtScheduledTime")]
        AutoInstallAndRebootAtScheduledTime,
        /// <summary>Auto-install and restart without end-user control</summary>
        [EnumMember(Value = "autoInstallAndRebootWithoutEndUserControl")]
        AutoInstallAndRebootWithoutEndUserControl,
    }
}
