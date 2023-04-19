using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class EdiscoveryEstimateOperation : CaseOperation, IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The estimated count of items for the search that matched the content query.</summary>
        public long? IndexedItemCount {
            get { return BackingStore?.Get<long?>("indexedItemCount"); }
            set { BackingStore?.Set("indexedItemCount", value); }
        }
        /// <summary>The estimated size of items for the search that matched the content query.</summary>
        public long? IndexedItemsSize {
            get { return BackingStore?.Get<long?>("indexedItemsSize"); }
            set { BackingStore?.Set("indexedItemsSize", value); }
        }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? MailboxCount {
            get { return BackingStore?.Get<int?>("mailboxCount"); }
            set { BackingStore?.Set("mailboxCount", value); }
        }
        /// <summary>eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoverySearch? Search {
            get { return BackingStore?.Get<EdiscoverySearch?>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#nullable restore
#else
        public EdiscoverySearch Search {
            get { return BackingStore?.Get<EdiscoverySearch>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#endif
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? SiteCount {
            get { return BackingStore?.Get<int?>("siteCount"); }
            set { BackingStore?.Set("siteCount", value); }
        }
        /// <summary>The estimated count of unindexed items for the collection.</summary>
        public long? UnindexedItemCount {
            get { return BackingStore?.Get<long?>("unindexedItemCount"); }
            set { BackingStore?.Set("unindexedItemCount", value); }
        }
        /// <summary>The estimated size of unindexed items for the collection.</summary>
        public long? UnindexedItemsSize {
            get { return BackingStore?.Get<long?>("unindexedItemsSize"); }
            set { BackingStore?.Set("unindexedItemsSize", value); }
        }
        /// <summary>
        /// Instantiates a new ediscoveryEstimateOperation and sets the default values.
        /// </summary>
        public EdiscoveryEstimateOperation() : base() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryEstimateOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryEstimateOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"indexedItemCount", n => { IndexedItemCount = n.GetLongValue(); } },
                {"indexedItemsSize", n => { IndexedItemsSize = n.GetLongValue(); } },
                {"mailboxCount", n => { MailboxCount = n.GetIntValue(); } },
                {"search", n => { Search = n.GetObjectValue<EdiscoverySearch>(EdiscoverySearch.CreateFromDiscriminatorValue); } },
                {"siteCount", n => { SiteCount = n.GetIntValue(); } },
                {"unindexedItemCount", n => { UnindexedItemCount = n.GetLongValue(); } },
                {"unindexedItemsSize", n => { UnindexedItemsSize = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("indexedItemCount", IndexedItemCount);
            writer.WriteLongValue("indexedItemsSize", IndexedItemsSize);
            writer.WriteIntValue("mailboxCount", MailboxCount);
            writer.WriteObjectValue<EdiscoverySearch>("search", Search);
            writer.WriteIntValue("siteCount", SiteCount);
            writer.WriteLongValue("unindexedItemCount", UnindexedItemCount);
            writer.WriteLongValue("unindexedItemsSize", UnindexedItemsSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
