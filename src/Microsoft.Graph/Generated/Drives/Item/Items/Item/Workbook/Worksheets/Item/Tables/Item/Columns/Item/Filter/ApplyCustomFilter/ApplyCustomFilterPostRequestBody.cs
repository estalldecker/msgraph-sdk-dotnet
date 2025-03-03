using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.Filter.ApplyCustomFilter {
    public class ApplyCustomFilterPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The criteria1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Criteria1 {
            get { return BackingStore?.Get<string?>("criteria1"); }
            set { BackingStore?.Set("criteria1", value); }
        }
#nullable restore
#else
        public string Criteria1 {
            get { return BackingStore?.Get<string>("criteria1"); }
            set { BackingStore?.Set("criteria1", value); }
        }
#endif
        /// <summary>The criteria2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Criteria2 {
            get { return BackingStore?.Get<string?>("criteria2"); }
            set { BackingStore?.Set("criteria2", value); }
        }
#nullable restore
#else
        public string Criteria2 {
            get { return BackingStore?.Get<string>("criteria2"); }
            set { BackingStore?.Set("criteria2", value); }
        }
#endif
        /// <summary>The oper property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Oper {
            get { return BackingStore?.Get<string?>("oper"); }
            set { BackingStore?.Set("oper", value); }
        }
#nullable restore
#else
        public string Oper {
            get { return BackingStore?.Get<string>("oper"); }
            set { BackingStore?.Set("oper", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new applyCustomFilterPostRequestBody and sets the default values.
        /// </summary>
        public ApplyCustomFilterPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplyCustomFilterPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplyCustomFilterPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"criteria1", n => { Criteria1 = n.GetStringValue(); } },
                {"criteria2", n => { Criteria2 = n.GetStringValue(); } },
                {"oper", n => { Oper = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("criteria1", Criteria1);
            writer.WriteStringValue("criteria2", Criteria2);
            writer.WriteStringValue("oper", Oper);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
