using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.DeviceManagement.Reports.GetCachedReport {
    public class GetCachedReportPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The groupBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GroupBy {
            get { return BackingStore?.Get<List<string>?>("groupBy"); }
            set { BackingStore?.Set("groupBy", value); }
        }
#nullable restore
#else
        public List<string> GroupBy {
            get { return BackingStore?.Get<List<string>>("groupBy"); }
            set { BackingStore?.Set("groupBy", value); }
        }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>The orderBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OrderBy {
            get { return BackingStore?.Get<List<string>?>("orderBy"); }
            set { BackingStore?.Set("orderBy", value); }
        }
#nullable restore
#else
        public List<string> OrderBy {
            get { return BackingStore?.Get<List<string>>("orderBy"); }
            set { BackingStore?.Set("orderBy", value); }
        }
#endif
        /// <summary>The search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Search {
            get { return BackingStore?.Get<string?>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#nullable restore
#else
        public string Search {
            get { return BackingStore?.Get<string>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#endif
        /// <summary>The select property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Select {
            get { return BackingStore?.Get<List<string>?>("select"); }
            set { BackingStore?.Set("select", value); }
        }
#nullable restore
#else
        public List<string> Select {
            get { return BackingStore?.Get<List<string>>("select"); }
            set { BackingStore?.Set("select", value); }
        }
#endif
        /// <summary>The skip property</summary>
        public int? Skip {
            get { return BackingStore?.Get<int?>("skip"); }
            set { BackingStore?.Set("skip", value); }
        }
        /// <summary>The top property</summary>
        public int? Top {
            get { return BackingStore?.Get<int?>("top"); }
            set { BackingStore?.Set("top", value); }
        }
        /// <summary>
        /// Instantiates a new getCachedReportPostRequestBody and sets the default values.
        /// </summary>
        public GetCachedReportPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetCachedReportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetCachedReportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"groupBy", n => { GroupBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"search", n => { Search = n.GetStringValue(); } },
                {"select", n => { Select = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"skip", n => { Skip = n.GetIntValue(); } },
                {"top", n => { Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("groupBy", GroupBy);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteStringValue("search", Search);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
