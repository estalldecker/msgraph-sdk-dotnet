using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class FileObject : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Hashes of the file&apos;s binary content, if available. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Hashes? Hashes {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Hashes?>("hashes"); }
            set { BackingStore?.Set("hashes", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Hashes Hashes {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Hashes>("hashes"); }
            set { BackingStore?.Set("hashes", value); }
        }
#endif
        /// <summary>The MIME type for the file. This is determined by logic on the server and might not be the value provided when the file was uploaded. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MimeType {
            get { return BackingStore?.Get<string?>("mimeType"); }
            set { BackingStore?.Set("mimeType", value); }
        }
#nullable restore
#else
        public string MimeType {
            get { return BackingStore?.Get<string>("mimeType"); }
            set { BackingStore?.Set("mimeType", value); }
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
        /// <summary>The processingMetadata property</summary>
        public bool? ProcessingMetadata {
            get { return BackingStore?.Get<bool?>("processingMetadata"); }
            set { BackingStore?.Set("processingMetadata", value); }
        }
        /// <summary>
        /// Instantiates a new fileObject and sets the default values.
        /// </summary>
        public FileObject() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FileObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hashes", n => { Hashes = n.GetObjectValue<Microsoft.Graph.Models.Hashes>(Microsoft.Graph.Models.Hashes.CreateFromDiscriminatorValue); } },
                {"mimeType", n => { MimeType = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"processingMetadata", n => { ProcessingMetadata = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.Hashes>("hashes", Hashes);
            writer.WriteStringValue("mimeType", MimeType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("processingMetadata", ProcessingMetadata);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
