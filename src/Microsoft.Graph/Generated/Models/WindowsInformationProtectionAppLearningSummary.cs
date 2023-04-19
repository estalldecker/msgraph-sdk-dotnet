using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Windows Information Protection AppLearning Summary entity.
    /// </summary>
    public class WindowsInformationProtectionAppLearningSummary : Entity, IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Application Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationName {
            get { return BackingStore?.Get<string?>("applicationName"); }
            set { BackingStore?.Set("applicationName", value); }
        }
#nullable restore
#else
        public string ApplicationName {
            get { return BackingStore?.Get<string>("applicationName"); }
            set { BackingStore?.Set("applicationName", value); }
        }
#endif
        /// <summary>Possible types of Application</summary>
        public Microsoft.Graph.Models.ApplicationType? ApplicationType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ApplicationType?>("applicationType"); }
            set { BackingStore?.Set("applicationType", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device Count</summary>
        public int? DeviceCount {
            get { return BackingStore?.Get<int?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
        }
        /// <summary>
        /// Instantiates a new windowsInformationProtectionAppLearningSummary and sets the default values.
        /// </summary>
        public WindowsInformationProtectionAppLearningSummary() : base() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsInformationProtectionAppLearningSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionAppLearningSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationName", n => { ApplicationName = n.GetStringValue(); } },
                {"applicationType", n => { ApplicationType = n.GetEnumValue<ApplicationType>(); } },
                {"deviceCount", n => { DeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationName", ApplicationName);
            writer.WriteEnumValue<ApplicationType>("applicationType", ApplicationType);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
