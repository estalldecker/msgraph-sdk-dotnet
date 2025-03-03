using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Lookup {
    public class LookupPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The lookupValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LookupValue {
            get { return BackingStore?.Get<Json?>("lookupValue"); }
            set { BackingStore?.Set("lookupValue", value); }
        }
#nullable restore
#else
        public Json LookupValue {
            get { return BackingStore?.Get<Json>("lookupValue"); }
            set { BackingStore?.Set("lookupValue", value); }
        }
#endif
        /// <summary>The lookupVector property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LookupVector {
            get { return BackingStore?.Get<Json?>("lookupVector"); }
            set { BackingStore?.Set("lookupVector", value); }
        }
#nullable restore
#else
        public Json LookupVector {
            get { return BackingStore?.Get<Json>("lookupVector"); }
            set { BackingStore?.Set("lookupVector", value); }
        }
#endif
        /// <summary>The resultVector property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ResultVector {
            get { return BackingStore?.Get<Json?>("resultVector"); }
            set { BackingStore?.Set("resultVector", value); }
        }
#nullable restore
#else
        public Json ResultVector {
            get { return BackingStore?.Get<Json>("resultVector"); }
            set { BackingStore?.Set("resultVector", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new lookupPostRequestBody and sets the default values.
        /// </summary>
        public LookupPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LookupPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LookupPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lookupValue", n => { LookupValue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"lookupVector", n => { LookupVector = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"resultVector", n => { ResultVector = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lookupValue", LookupValue);
            writer.WriteObjectValue<Json>("lookupVector", LookupVector);
            writer.WriteObjectValue<Json>("resultVector", ResultVector);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
