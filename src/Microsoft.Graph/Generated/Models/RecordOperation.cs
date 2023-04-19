using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class RecordOperation : CommsOperation, IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The access token required to retrieve the recording.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingAccessToken {
            get { return BackingStore?.Get<string?>("recordingAccessToken"); }
            set { BackingStore?.Set("recordingAccessToken", value); }
        }
#nullable restore
#else
        public string RecordingAccessToken {
            get { return BackingStore?.Get<string>("recordingAccessToken"); }
            set { BackingStore?.Set("recordingAccessToken", value); }
        }
#endif
        /// <summary>The location where the recording is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingLocation {
            get { return BackingStore?.Get<string?>("recordingLocation"); }
            set { BackingStore?.Set("recordingLocation", value); }
        }
#nullable restore
#else
        public string RecordingLocation {
            get { return BackingStore?.Get<string>("recordingLocation"); }
            set { BackingStore?.Set("recordingLocation", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new RecordOperation and sets the default values.
        /// </summary>
        public RecordOperation() : base() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RecordOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecordOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"recordingAccessToken", n => { RecordingAccessToken = n.GetStringValue(); } },
                {"recordingLocation", n => { RecordingLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("recordingAccessToken", RecordingAccessToken);
            writer.WriteStringValue("recordingLocation", RecordingLocation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
