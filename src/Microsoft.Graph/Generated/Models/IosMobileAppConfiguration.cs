using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class IosMobileAppConfiguration : ManagedDeviceMobileAppConfiguration, IParsable {
        /// <summary>mdm app configuration Base64 binary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? EncodedSettingXml {
            get { return BackingStore?.Get<byte[]?>("encodedSettingXml"); }
            set { BackingStore?.Set("encodedSettingXml", value); }
        }
#nullable restore
#else
        public byte[] EncodedSettingXml {
            get { return BackingStore?.Get<byte[]>("encodedSettingXml"); }
            set { BackingStore?.Set("encodedSettingXml", value); }
        }
#endif
        /// <summary>app configuration setting items.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppConfigurationSettingItem>? Settings {
            get { return BackingStore?.Get<List<AppConfigurationSettingItem>?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public List<AppConfigurationSettingItem> Settings {
            get { return BackingStore?.Get<List<AppConfigurationSettingItem>>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new IosMobileAppConfiguration and sets the default values.
        /// </summary>
        public IosMobileAppConfiguration() : base() {
            OdataType = "#microsoft.graph.iosMobileAppConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosMobileAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosMobileAppConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"encodedSettingXml", n => { EncodedSettingXml = n.GetByteArrayValue(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<AppConfigurationSettingItem>(AppConfigurationSettingItem.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("encodedSettingXml", EncodedSettingXml);
            writer.WriteCollectionOfObjectValues<AppConfigurationSettingItem>("settings", Settings);
        }
    }
}
