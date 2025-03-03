using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Time {
    public class TimePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The hour property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Hour {
            get { return BackingStore?.Get<Json?>("hour"); }
            set { BackingStore?.Set("hour", value); }
        }
#nullable restore
#else
        public Json Hour {
            get { return BackingStore?.Get<Json>("hour"); }
            set { BackingStore?.Set("hour", value); }
        }
#endif
        /// <summary>The minute property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Minute {
            get { return BackingStore?.Get<Json?>("minute"); }
            set { BackingStore?.Set("minute", value); }
        }
#nullable restore
#else
        public Json Minute {
            get { return BackingStore?.Get<Json>("minute"); }
            set { BackingStore?.Set("minute", value); }
        }
#endif
        /// <summary>The second property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Second {
            get { return BackingStore?.Get<Json?>("second"); }
            set { BackingStore?.Set("second", value); }
        }
#nullable restore
#else
        public Json Second {
            get { return BackingStore?.Get<Json>("second"); }
            set { BackingStore?.Set("second", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new timePostRequestBody and sets the default values.
        /// </summary>
        public TimePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hour", n => { Hour = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"minute", n => { Minute = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"second", n => { Second = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("hour", Hour);
            writer.WriteObjectValue<Json>("minute", Minute);
            writer.WriteObjectValue<Json>("second", Second);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
