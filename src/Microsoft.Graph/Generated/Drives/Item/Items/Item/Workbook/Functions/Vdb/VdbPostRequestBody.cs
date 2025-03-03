using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Vdb {
    public class VdbPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cost {
            get { return BackingStore?.Get<Json?>("cost"); }
            set { BackingStore?.Set("cost", value); }
        }
#nullable restore
#else
        public Json Cost {
            get { return BackingStore?.Get<Json>("cost"); }
            set { BackingStore?.Set("cost", value); }
        }
#endif
        /// <summary>The endPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? EndPeriod {
            get { return BackingStore?.Get<Json?>("endPeriod"); }
            set { BackingStore?.Set("endPeriod", value); }
        }
#nullable restore
#else
        public Json EndPeriod {
            get { return BackingStore?.Get<Json>("endPeriod"); }
            set { BackingStore?.Set("endPeriod", value); }
        }
#endif
        /// <summary>The factor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Factor {
            get { return BackingStore?.Get<Json?>("factor"); }
            set { BackingStore?.Set("factor", value); }
        }
#nullable restore
#else
        public Json Factor {
            get { return BackingStore?.Get<Json>("factor"); }
            set { BackingStore?.Set("factor", value); }
        }
#endif
        /// <summary>The life property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Life {
            get { return BackingStore?.Get<Json?>("life"); }
            set { BackingStore?.Set("life", value); }
        }
#nullable restore
#else
        public Json Life {
            get { return BackingStore?.Get<Json>("life"); }
            set { BackingStore?.Set("life", value); }
        }
#endif
        /// <summary>The noSwitch property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NoSwitch {
            get { return BackingStore?.Get<Json?>("noSwitch"); }
            set { BackingStore?.Set("noSwitch", value); }
        }
#nullable restore
#else
        public Json NoSwitch {
            get { return BackingStore?.Get<Json>("noSwitch"); }
            set { BackingStore?.Set("noSwitch", value); }
        }
#endif
        /// <summary>The salvage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Salvage {
            get { return BackingStore?.Get<Json?>("salvage"); }
            set { BackingStore?.Set("salvage", value); }
        }
#nullable restore
#else
        public Json Salvage {
            get { return BackingStore?.Get<Json>("salvage"); }
            set { BackingStore?.Set("salvage", value); }
        }
#endif
        /// <summary>The startPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartPeriod {
            get { return BackingStore?.Get<Json?>("startPeriod"); }
            set { BackingStore?.Set("startPeriod", value); }
        }
#nullable restore
#else
        public Json StartPeriod {
            get { return BackingStore?.Get<Json>("startPeriod"); }
            set { BackingStore?.Set("startPeriod", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new vdbPostRequestBody and sets the default values.
        /// </summary>
        public VdbPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VdbPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VdbPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cost", n => { Cost = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"endPeriod", n => { EndPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"factor", n => { Factor = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"life", n => { Life = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"noSwitch", n => { NoSwitch = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"salvage", n => { Salvage = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startPeriod", n => { StartPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("endPeriod", EndPeriod);
            writer.WriteObjectValue<Json>("factor", Factor);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("noSwitch", NoSwitch);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteObjectValue<Json>("startPeriod", StartPeriod);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
