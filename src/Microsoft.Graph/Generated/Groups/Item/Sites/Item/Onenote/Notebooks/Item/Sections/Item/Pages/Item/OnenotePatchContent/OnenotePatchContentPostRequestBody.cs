using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.Sections.Item.Pages.Item.OnenotePatchContent {
    public class OnenotePatchContentPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The commands property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenotePatchContentCommand>? Commands {
            get { return BackingStore?.Get<List<OnenotePatchContentCommand>?>("commands"); }
            set { BackingStore?.Set("commands", value); }
        }
#nullable restore
#else
        public List<OnenotePatchContentCommand> Commands {
            get { return BackingStore?.Get<List<OnenotePatchContentCommand>>("commands"); }
            set { BackingStore?.Set("commands", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onenotePatchContentPostRequestBody and sets the default values.
        /// </summary>
        public OnenotePatchContentPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnenotePatchContentPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnenotePatchContentPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"commands", n => { Commands = n.GetCollectionOfObjectValues<OnenotePatchContentCommand>(OnenotePatchContentCommand.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<OnenotePatchContentCommand>("commands", Commands);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
