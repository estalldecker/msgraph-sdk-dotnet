using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Scheduled Action for Rule
    /// </summary>
    public class DeviceComplianceScheduledActionForRule : Entity, IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Name of the rule which this scheduled action applies to. Currently scheduled actions are created per policy instead of per rule, thus RuleName is always set to default value PasswordRequired.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleName {
            get { return BackingStore?.Get<string?>("ruleName"); }
            set { BackingStore?.Set("ruleName", value); }
        }
#nullable restore
#else
        public string RuleName {
            get { return BackingStore?.Get<string>("ruleName"); }
            set { BackingStore?.Set("ruleName", value); }
        }
#endif
        /// <summary>The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceComplianceActionItem>? ScheduledActionConfigurations {
            get { return BackingStore?.Get<List<DeviceComplianceActionItem>?>("scheduledActionConfigurations"); }
            set { BackingStore?.Set("scheduledActionConfigurations", value); }
        }
#nullable restore
#else
        public List<DeviceComplianceActionItem> ScheduledActionConfigurations {
            get { return BackingStore?.Get<List<DeviceComplianceActionItem>>("scheduledActionConfigurations"); }
            set { BackingStore?.Set("scheduledActionConfigurations", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceComplianceScheduledActionForRule and sets the default values.
        /// </summary>
        public DeviceComplianceScheduledActionForRule() : base() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceComplianceScheduledActionForRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScheduledActionForRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"ruleName", n => { RuleName = n.GetStringValue(); } },
                {"scheduledActionConfigurations", n => { ScheduledActionConfigurations = n.GetCollectionOfObjectValues<DeviceComplianceActionItem>(DeviceComplianceActionItem.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("ruleName", RuleName);
            writer.WriteCollectionOfObjectValues<DeviceComplianceActionItem>("scheduledActionConfigurations", ScheduledActionConfigurations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
