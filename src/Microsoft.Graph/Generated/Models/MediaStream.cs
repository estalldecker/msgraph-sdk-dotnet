using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class MediaStream : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The direction property</summary>
        public MediaDirection? Direction {
            get { return BackingStore?.Get<MediaDirection?>("direction"); }
            set { BackingStore?.Set("direction", value); }
        }
        /// <summary>The media stream label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label {
            get { return BackingStore?.Get<string?>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#nullable restore
#else
        public string Label {
            get { return BackingStore?.Get<string>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#endif
        /// <summary>The mediaType property</summary>
        public Modality? MediaType {
            get { return BackingStore?.Get<Modality?>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
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
        /// <summary>If the media is muted by the server.</summary>
        public bool? ServerMuted {
            get { return BackingStore?.Get<bool?>("serverMuted"); }
            set { BackingStore?.Set("serverMuted", value); }
        }
        /// <summary>The source ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceId {
            get { return BackingStore?.Get<string?>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#nullable restore
#else
        public string SourceId {
            get { return BackingStore?.Get<string>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new mediaStream and sets the default values.
        /// </summary>
        public MediaStream() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MediaStream CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaStream();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"direction", n => { Direction = n.GetEnumValue<MediaDirection>(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetEnumValue<Modality>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"serverMuted", n => { ServerMuted = n.GetBoolValue(); } },
                {"sourceId", n => { SourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MediaDirection>("direction", Direction);
            writer.WriteStringValue("label", Label);
            writer.WriteEnumValue<Modality>("mediaType", MediaType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("serverMuted", ServerMuted);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
