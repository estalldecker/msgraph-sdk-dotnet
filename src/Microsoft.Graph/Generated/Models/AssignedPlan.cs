using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AssignedPlan : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The date and time at which the plan was assigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AssignedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("assignedDateTime"); }
            set { BackingStore?.Set("assignedDateTime", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Condition of the capability assignment. The possible values are Enabled, Warning, Suspended, Deleted, LockedOut. See a detailed description of each value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CapabilityStatus {
            get { return BackingStore?.Get<string?>("capabilityStatus"); }
            set { BackingStore?.Set("capabilityStatus", value); }
        }
#nullable restore
#else
        public string CapabilityStatus {
            get { return BackingStore?.Get<string>("capabilityStatus"); }
            set { BackingStore?.Set("capabilityStatus", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The name of the service; for example, exchange.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service {
            get { return BackingStore?.Get<string?>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#nullable restore
#else
        public string Service {
            get { return BackingStore?.Get<string>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#endif
        /// <summary>A GUID that identifies the service plan. For a complete list of GUIDs and their equivalent friendly service names, see Product names and service plan identifiers for licensing.</summary>
        public Guid? ServicePlanId {
            get { return BackingStore?.Get<Guid?>("servicePlanId"); }
            set { BackingStore?.Set("servicePlanId", value); }
        }
        /// <summary>
        /// Instantiates a new assignedPlan and sets the default values.
        /// </summary>
        public AssignedPlan() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignedPlan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignedPlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedDateTime", n => { AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"capabilityStatus", n => { CapabilityStatus = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"servicePlanId", n => { ServicePlanId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("assignedDateTime", AssignedDateTime);
            writer.WriteStringValue("capabilityStatus", CapabilityStatus);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("service", Service);
            writer.WriteGuidValue("servicePlanId", ServicePlanId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
