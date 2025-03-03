using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Rate {
    public class RatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The fv property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Fv {
            get { return BackingStore?.Get<Json?>("fv"); }
            set { BackingStore?.Set("fv", value); }
        }
#nullable restore
#else
        public Json Fv {
            get { return BackingStore?.Get<Json>("fv"); }
            set { BackingStore?.Set("fv", value); }
        }
#endif
        /// <summary>The guess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Guess {
            get { return BackingStore?.Get<Json?>("guess"); }
            set { BackingStore?.Set("guess", value); }
        }
#nullable restore
#else
        public Json Guess {
            get { return BackingStore?.Get<Json>("guess"); }
            set { BackingStore?.Set("guess", value); }
        }
#endif
        /// <summary>The nper property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Nper {
            get { return BackingStore?.Get<Json?>("nper"); }
            set { BackingStore?.Set("nper", value); }
        }
#nullable restore
#else
        public Json Nper {
            get { return BackingStore?.Get<Json>("nper"); }
            set { BackingStore?.Set("nper", value); }
        }
#endif
        /// <summary>The pmt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Pmt {
            get { return BackingStore?.Get<Json?>("pmt"); }
            set { BackingStore?.Set("pmt", value); }
        }
#nullable restore
#else
        public Json Pmt {
            get { return BackingStore?.Get<Json>("pmt"); }
            set { BackingStore?.Set("pmt", value); }
        }
#endif
        /// <summary>The pv property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Pv {
            get { return BackingStore?.Get<Json?>("pv"); }
            set { BackingStore?.Set("pv", value); }
        }
#nullable restore
#else
        public Json Pv {
            get { return BackingStore?.Get<Json>("pv"); }
            set { BackingStore?.Set("pv", value); }
        }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Type {
            get { return BackingStore?.Get<Json?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public Json Type {
            get { return BackingStore?.Get<Json>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ratePostRequestBody and sets the default values.
        /// </summary>
        public RatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"fv", n => { Fv = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"guess", n => { Guess = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"nper", n => { Nper = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"pmt", n => { Pmt = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"pv", n => { Pv = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fv", Fv);
            writer.WriteObjectValue<Json>("guess", Guess);
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("pmt", Pmt);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
