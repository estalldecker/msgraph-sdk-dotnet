using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Rank_Avg {
    public class Rank_AvgPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Number {
            get { return BackingStore?.Get<Json?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public Json Number {
            get { return BackingStore?.Get<Json>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>The order property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Order {
            get { return BackingStore?.Get<Json?>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#nullable restore
#else
        public Json Order {
            get { return BackingStore?.Get<Json>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#endif
        /// <summary>The ref property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Ref {
            get { return BackingStore?.Get<Json?>("ref"); }
            set { BackingStore?.Set("ref", value); }
        }
#nullable restore
#else
        public Json Ref {
            get { return BackingStore?.Get<Json>("ref"); }
            set { BackingStore?.Set("ref", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new rank_AvgPostRequestBody and sets the default values.
        /// </summary>
        public Rank_AvgPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Rank_AvgPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Rank_AvgPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"number", n => { Number = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"order", n => { Order = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"ref", n => { Ref = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("order", Order);
            writer.WriteObjectValue<Json>("ref", Ref);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
