using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.F_Dist_RT {
    public class F_Dist_RTPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The degFreedom1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? DegFreedom1 {
            get { return BackingStore?.Get<Json?>("degFreedom1"); }
            set { BackingStore?.Set("degFreedom1", value); }
        }
#nullable restore
#else
        public Json DegFreedom1 {
            get { return BackingStore?.Get<Json>("degFreedom1"); }
            set { BackingStore?.Set("degFreedom1", value); }
        }
#endif
        /// <summary>The degFreedom2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? DegFreedom2 {
            get { return BackingStore?.Get<Json?>("degFreedom2"); }
            set { BackingStore?.Set("degFreedom2", value); }
        }
#nullable restore
#else
        public Json DegFreedom2 {
            get { return BackingStore?.Get<Json>("degFreedom2"); }
            set { BackingStore?.Set("degFreedom2", value); }
        }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? X {
            get { return BackingStore?.Get<Json?>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#nullable restore
#else
        public Json X {
            get { return BackingStore?.Get<Json>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new f_Dist_RTPostRequestBody and sets the default values.
        /// </summary>
        public F_Dist_RTPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static F_Dist_RTPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new F_Dist_RTPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"degFreedom1", n => { DegFreedom1 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"degFreedom2", n => { DegFreedom2 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"x", n => { X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("degFreedom1", DegFreedom1);
            writer.WriteObjectValue<Json>("degFreedom2", DegFreedom2);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
