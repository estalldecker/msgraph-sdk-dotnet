using Microsoft.Graph.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.Queries.Item.SecurityApplyTags {
    public class ApplyTagsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The tagsToAdd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewTag>? TagsToAdd {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>?>("tagsToAdd"); }
            set { BackingStore?.Set("tagsToAdd", value); }
        }
#nullable restore
#else
        public List<EdiscoveryReviewTag> TagsToAdd {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>>("tagsToAdd"); }
            set { BackingStore?.Set("tagsToAdd", value); }
        }
#endif
        /// <summary>The tagsToRemove property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewTag>? TagsToRemove {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>?>("tagsToRemove"); }
            set { BackingStore?.Set("tagsToRemove", value); }
        }
#nullable restore
#else
        public List<EdiscoveryReviewTag> TagsToRemove {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>>("tagsToRemove"); }
            set { BackingStore?.Set("tagsToRemove", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new applyTagsPostRequestBody and sets the default values.
        /// </summary>
        public ApplyTagsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplyTagsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplyTagsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"tagsToAdd", n => { TagsToAdd = n.GetCollectionOfObjectValues<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tagsToRemove", n => { TagsToRemove = n.GetCollectionOfObjectValues<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewTag>("tagsToAdd", TagsToAdd);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewTag>("tagsToRemove", TagsToRemove);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
