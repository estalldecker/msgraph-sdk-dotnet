using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class VisualInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Optional. JSON object used to represent an icon which represents the application used to generate the activity</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ImageInfo? Attribution {
            get { return BackingStore?.Get<ImageInfo?>("attribution"); }
            set { BackingStore?.Set("attribution", value); }
        }
#nullable restore
#else
        public ImageInfo Attribution {
            get { return BackingStore?.Get<ImageInfo>("attribution"); }
            set { BackingStore?.Set("attribution", value); }
        }
#endif
        /// <summary>Optional. Background color used to render the activity in the UI - brand color for the application source of the activity. Must be a valid hex color</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackgroundColor {
            get { return BackingStore?.Get<string?>("backgroundColor"); }
            set { BackingStore?.Set("backgroundColor", value); }
        }
#nullable restore
#else
        public string BackgroundColor {
            get { return BackingStore?.Get<string>("backgroundColor"); }
            set { BackingStore?.Set("backgroundColor", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Optional. Custom piece of data - JSON object used to provide custom content to render the activity in the Windows Shell UI</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Content {
            get { return BackingStore?.Get<Json?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public Json Content {
            get { return BackingStore?.Get<Json>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>Optional. Longer text description of the user&apos;s unique activity (example: document name, first sentence, and/or metadata)</summary>
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
        /// <summary>Required. Short text description of the user&apos;s unique activity (for example, document name in cases where an activity refers to document creation)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayText {
            get { return BackingStore?.Get<string?>("displayText"); }
            set { BackingStore?.Set("displayText", value); }
        }
#nullable restore
#else
        public string DisplayText {
            get { return BackingStore?.Get<string>("displayText"); }
            set { BackingStore?.Set("displayText", value); }
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
        /// <summary>
        /// Instantiates a new visualInfo and sets the default values.
        /// </summary>
        public VisualInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VisualInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VisualInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attribution", n => { Attribution = n.GetObjectValue<ImageInfo>(ImageInfo.CreateFromDiscriminatorValue); } },
                {"backgroundColor", n => { BackgroundColor = n.GetStringValue(); } },
                {"content", n => { Content = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayText", n => { DisplayText = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ImageInfo>("attribution", Attribution);
            writer.WriteStringValue("backgroundColor", BackgroundColor);
            writer.WriteObjectValue<Json>("content", Content);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayText", DisplayText);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
