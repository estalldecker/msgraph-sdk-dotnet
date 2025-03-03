using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ProvisioningObjectSummary : Entity, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>Unique ID of this change in this cycle.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeId {
            get { return BackingStore?.Get<string?>("changeId"); }
            set { BackingStore?.Set("changeId", value); }
        }
#nullable restore
#else
        public string ChangeId {
            get { return BackingStore?.Get<string>("changeId"); }
            set { BackingStore?.Set("changeId", value); }
        }
#endif
        /// <summary>Unique ID per job iteration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CycleId {
            get { return BackingStore?.Get<string?>("cycleId"); }
            set { BackingStore?.Set("cycleId", value); }
        }
#nullable restore
#else
        public string CycleId {
            get { return BackingStore?.Get<string>("cycleId"); }
            set { BackingStore?.Set("cycleId", value); }
        }
#endif
        /// <summary>Indicates how long this provisioning action took to finish. Measured in milliseconds.</summary>
        public int? DurationInMilliseconds {
            get { return BackingStore?.Get<int?>("durationInMilliseconds"); }
            set { BackingStore?.Set("durationInMilliseconds", value); }
        }
        /// <summary>Details of who initiated this provisioning.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Initiator? InitiatedBy {
            get { return BackingStore?.Get<Initiator?>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#nullable restore
#else
        public Initiator InitiatedBy {
            get { return BackingStore?.Get<Initiator>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#endif
        /// <summary>The unique ID for the whole provisioning job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobId {
            get { return BackingStore?.Get<string?>("jobId"); }
            set { BackingStore?.Set("jobId", value); }
        }
#nullable restore
#else
        public string JobId {
            get { return BackingStore?.Get<string>("jobId"); }
            set { BackingStore?.Set("jobId", value); }
        }
#endif
        /// <summary>Details of each property that was modified in this provisioning action on this object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ModifiedProperty>? ModifiedProperties {
            get { return BackingStore?.Get<List<ModifiedProperty>?>("modifiedProperties"); }
            set { BackingStore?.Set("modifiedProperties", value); }
        }
#nullable restore
#else
        public List<ModifiedProperty> ModifiedProperties {
            get { return BackingStore?.Get<List<ModifiedProperty>>("modifiedProperties"); }
            set { BackingStore?.Set("modifiedProperties", value); }
        }
#endif
        /// <summary>Indicates the activity name or the operation name. Possible values are: create, update, delete, stageddelete, disable, other and unknownFutureValue. For a list of activities logged, refer to Azure AD activity list.</summary>
        public Microsoft.Graph.Models.ProvisioningAction? ProvisioningAction {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ProvisioningAction?>("provisioningAction"); }
            set { BackingStore?.Set("provisioningAction", value); }
        }
        /// <summary>Details of provisioning status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ProvisioningStatusInfo? ProvisioningStatusInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ProvisioningStatusInfo?>("provisioningStatusInfo"); }
            set { BackingStore?.Set("provisioningStatusInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ProvisioningStatusInfo ProvisioningStatusInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ProvisioningStatusInfo>("provisioningStatusInfo"); }
            set { BackingStore?.Set("provisioningStatusInfo", value); }
        }
#endif
        /// <summary>Details of each step in provisioning.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProvisioningStep>? ProvisioningSteps {
            get { return BackingStore?.Get<List<ProvisioningStep>?>("provisioningSteps"); }
            set { BackingStore?.Set("provisioningSteps", value); }
        }
#nullable restore
#else
        public List<ProvisioningStep> ProvisioningSteps {
            get { return BackingStore?.Get<List<ProvisioningStep>>("provisioningSteps"); }
            set { BackingStore?.Set("provisioningSteps", value); }
        }
#endif
        /// <summary>Represents the service principal used for provisioning.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisioningServicePrincipal? ServicePrincipal {
            get { return BackingStore?.Get<ProvisioningServicePrincipal?>("servicePrincipal"); }
            set { BackingStore?.Set("servicePrincipal", value); }
        }
#nullable restore
#else
        public ProvisioningServicePrincipal ServicePrincipal {
            get { return BackingStore?.Get<ProvisioningServicePrincipal>("servicePrincipal"); }
            set { BackingStore?.Set("servicePrincipal", value); }
        }
#endif
        /// <summary>Details of source object being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisionedIdentity? SourceIdentity {
            get { return BackingStore?.Get<ProvisionedIdentity?>("sourceIdentity"); }
            set { BackingStore?.Set("sourceIdentity", value); }
        }
#nullable restore
#else
        public ProvisionedIdentity SourceIdentity {
            get { return BackingStore?.Get<ProvisionedIdentity>("sourceIdentity"); }
            set { BackingStore?.Set("sourceIdentity", value); }
        }
#endif
        /// <summary>Details of source system of the object being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisioningSystem? SourceSystem {
            get { return BackingStore?.Get<ProvisioningSystem?>("sourceSystem"); }
            set { BackingStore?.Set("sourceSystem", value); }
        }
#nullable restore
#else
        public ProvisioningSystem SourceSystem {
            get { return BackingStore?.Get<ProvisioningSystem>("sourceSystem"); }
            set { BackingStore?.Set("sourceSystem", value); }
        }
#endif
        /// <summary>Details of target object being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisionedIdentity? TargetIdentity {
            get { return BackingStore?.Get<ProvisionedIdentity?>("targetIdentity"); }
            set { BackingStore?.Set("targetIdentity", value); }
        }
#nullable restore
#else
        public ProvisionedIdentity TargetIdentity {
            get { return BackingStore?.Get<ProvisionedIdentity>("targetIdentity"); }
            set { BackingStore?.Set("targetIdentity", value); }
        }
#endif
        /// <summary>Details of target system of the object being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisioningSystem? TargetSystem {
            get { return BackingStore?.Get<ProvisioningSystem?>("targetSystem"); }
            set { BackingStore?.Set("targetSystem", value); }
        }
#nullable restore
#else
        public ProvisioningSystem TargetSystem {
            get { return BackingStore?.Get<ProvisioningSystem>("targetSystem"); }
            set { BackingStore?.Set("targetSystem", value); }
        }
#endif
        /// <summary>Unique Azure AD tenant ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProvisioningObjectSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisioningObjectSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"changeId", n => { ChangeId = n.GetStringValue(); } },
                {"cycleId", n => { CycleId = n.GetStringValue(); } },
                {"durationInMilliseconds", n => { DurationInMilliseconds = n.GetIntValue(); } },
                {"initiatedBy", n => { InitiatedBy = n.GetObjectValue<Initiator>(Initiator.CreateFromDiscriminatorValue); } },
                {"jobId", n => { JobId = n.GetStringValue(); } },
                {"modifiedProperties", n => { ModifiedProperties = n.GetCollectionOfObjectValues<ModifiedProperty>(ModifiedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"provisioningAction", n => { ProvisioningAction = n.GetEnumValue<ProvisioningAction>(); } },
                {"provisioningStatusInfo", n => { ProvisioningStatusInfo = n.GetObjectValue<Microsoft.Graph.Models.ProvisioningStatusInfo>(Microsoft.Graph.Models.ProvisioningStatusInfo.CreateFromDiscriminatorValue); } },
                {"provisioningSteps", n => { ProvisioningSteps = n.GetCollectionOfObjectValues<ProvisioningStep>(ProvisioningStep.CreateFromDiscriminatorValue)?.ToList(); } },
                {"servicePrincipal", n => { ServicePrincipal = n.GetObjectValue<ProvisioningServicePrincipal>(ProvisioningServicePrincipal.CreateFromDiscriminatorValue); } },
                {"sourceIdentity", n => { SourceIdentity = n.GetObjectValue<ProvisionedIdentity>(ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                {"sourceSystem", n => { SourceSystem = n.GetObjectValue<ProvisioningSystem>(ProvisioningSystem.CreateFromDiscriminatorValue); } },
                {"targetIdentity", n => { TargetIdentity = n.GetObjectValue<ProvisionedIdentity>(ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                {"targetSystem", n => { TargetSystem = n.GetObjectValue<ProvisioningSystem>(ProvisioningSystem.CreateFromDiscriminatorValue); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("changeId", ChangeId);
            writer.WriteStringValue("cycleId", CycleId);
            writer.WriteIntValue("durationInMilliseconds", DurationInMilliseconds);
            writer.WriteObjectValue<Initiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("jobId", JobId);
            writer.WriteCollectionOfObjectValues<ModifiedProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteEnumValue<ProvisioningAction>("provisioningAction", ProvisioningAction);
            writer.WriteObjectValue<Microsoft.Graph.Models.ProvisioningStatusInfo>("provisioningStatusInfo", ProvisioningStatusInfo);
            writer.WriteCollectionOfObjectValues<ProvisioningStep>("provisioningSteps", ProvisioningSteps);
            writer.WriteObjectValue<ProvisioningServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteObjectValue<ProvisionedIdentity>("sourceIdentity", SourceIdentity);
            writer.WriteObjectValue<ProvisioningSystem>("sourceSystem", SourceSystem);
            writer.WriteObjectValue<ProvisionedIdentity>("targetIdentity", TargetIdentity);
            writer.WriteObjectValue<ProvisioningSystem>("targetSystem", TargetSystem);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
