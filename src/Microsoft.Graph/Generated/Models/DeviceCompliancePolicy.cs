using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// This is the base class for Compliance policy. Compliance policies are platform specific and individual per-platform compliance policies inherit from here. 
    /// </summary>
    public class DeviceCompliancePolicy : Entity, IParsable {
        /// <summary>The collection of assignments for this compliance policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicyAssignment>? Assignments {
            get { return BackingStore?.Get<List<DeviceCompliancePolicyAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<DeviceCompliancePolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<DeviceCompliancePolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Admin provided description of the Device Configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Compliance Setting State Device Summary</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SettingStateDeviceSummary>? DeviceSettingStateSummaries {
            get { return BackingStore?.Get<List<SettingStateDeviceSummary>?>("deviceSettingStateSummaries"); }
            set { BackingStore?.Set("deviceSettingStateSummaries", value); }
        }
#nullable restore
#else
        public List<SettingStateDeviceSummary> DeviceSettingStateSummaries {
            get { return BackingStore?.Get<List<SettingStateDeviceSummary>>("deviceSettingStateSummaries"); }
            set { BackingStore?.Set("deviceSettingStateSummaries", value); }
        }
#endif
        /// <summary>List of DeviceComplianceDeviceStatus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceComplianceDeviceStatus>? DeviceStatuses {
            get { return BackingStore?.Get<List<DeviceComplianceDeviceStatus>?>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
#nullable restore
#else
        public List<DeviceComplianceDeviceStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<DeviceComplianceDeviceStatus>>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
#endif
        /// <summary>Device compliance devices status overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceComplianceDeviceOverview? DeviceStatusOverview {
            get { return BackingStore?.Get<DeviceComplianceDeviceOverview?>("deviceStatusOverview"); }
            set { BackingStore?.Set("deviceStatusOverview", value); }
        }
#nullable restore
#else
        public DeviceComplianceDeviceOverview DeviceStatusOverview {
            get { return BackingStore?.Get<DeviceComplianceDeviceOverview>("deviceStatusOverview"); }
            set { BackingStore?.Set("deviceStatusOverview", value); }
        }
#endif
        /// <summary>Admin provided name of the device configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceComplianceScheduledActionForRule>? ScheduledActionsForRule {
            get { return BackingStore?.Get<List<DeviceComplianceScheduledActionForRule>?>("scheduledActionsForRule"); }
            set { BackingStore?.Set("scheduledActionsForRule", value); }
        }
#nullable restore
#else
        public List<DeviceComplianceScheduledActionForRule> ScheduledActionsForRule {
            get { return BackingStore?.Get<List<DeviceComplianceScheduledActionForRule>>("scheduledActionsForRule"); }
            set { BackingStore?.Set("scheduledActionsForRule", value); }
        }
#endif
        /// <summary>List of DeviceComplianceUserStatus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceComplianceUserStatus>? UserStatuses {
            get { return BackingStore?.Get<List<DeviceComplianceUserStatus>?>("userStatuses"); }
            set { BackingStore?.Set("userStatuses", value); }
        }
#nullable restore
#else
        public List<DeviceComplianceUserStatus> UserStatuses {
            get { return BackingStore?.Get<List<DeviceComplianceUserStatus>>("userStatuses"); }
            set { BackingStore?.Set("userStatuses", value); }
        }
#endif
        /// <summary>Device compliance users status overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceComplianceUserOverview? UserStatusOverview {
            get { return BackingStore?.Get<DeviceComplianceUserOverview?>("userStatusOverview"); }
            set { BackingStore?.Set("userStatusOverview", value); }
        }
#nullable restore
#else
        public DeviceComplianceUserOverview UserStatusOverview {
            get { return BackingStore?.Get<DeviceComplianceUserOverview>("userStatusOverview"); }
            set { BackingStore?.Set("userStatusOverview", value); }
        }
#endif
        /// <summary>Version of the device configuration.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidCompliancePolicy" => new AndroidCompliancePolicy(),
                "#microsoft.graph.androidWorkProfileCompliancePolicy" => new AndroidWorkProfileCompliancePolicy(),
                "#microsoft.graph.iosCompliancePolicy" => new IosCompliancePolicy(),
                "#microsoft.graph.macOSCompliancePolicy" => new MacOSCompliancePolicy(),
                "#microsoft.graph.windows10CompliancePolicy" => new Windows10CompliancePolicy(),
                "#microsoft.graph.windows10MobileCompliancePolicy" => new Windows10MobileCompliancePolicy(),
                "#microsoft.graph.windows81CompliancePolicy" => new Windows81CompliancePolicy(),
                "#microsoft.graph.windowsPhone81CompliancePolicy" => new WindowsPhone81CompliancePolicy(),
                _ => new DeviceCompliancePolicy(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceCompliancePolicyAssignment>(DeviceCompliancePolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", n => { DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<SettingStateDeviceSummary>(SettingStateDeviceSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<DeviceComplianceDeviceStatus>(DeviceComplianceDeviceStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceStatusOverview", n => { DeviceStatusOverview = n.GetObjectValue<DeviceComplianceDeviceOverview>(DeviceComplianceDeviceOverview.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"scheduledActionsForRule", n => { ScheduledActionsForRule = n.GetCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>(DeviceComplianceScheduledActionForRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<DeviceComplianceUserStatus>(DeviceComplianceUserStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userStatusOverview", n => { UserStatusOverview = n.GetObjectValue<DeviceComplianceUserOverview>(DeviceComplianceUserOverview.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<SettingStateDeviceSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceComplianceDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<DeviceComplianceDeviceOverview>("deviceStatusOverview", DeviceStatusOverview);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>("scheduledActionsForRule", ScheduledActionsForRule);
            writer.WriteCollectionOfObjectValues<DeviceComplianceUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<DeviceComplianceUserOverview>("userStatusOverview", UserStatusOverview);
            writer.WriteIntValue("version", Version);
        }
    }
}
