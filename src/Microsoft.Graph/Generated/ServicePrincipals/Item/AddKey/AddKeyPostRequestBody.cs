using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.ServicePrincipals.Item.AddKey {
    public class AddKeyPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The keyCredential property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.KeyCredential? KeyCredential {
            get { return BackingStore?.Get<Microsoft.Graph.Models.KeyCredential?>("keyCredential"); }
            set { BackingStore?.Set("keyCredential", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.KeyCredential KeyCredential {
            get { return BackingStore?.Get<Microsoft.Graph.Models.KeyCredential>("keyCredential"); }
            set { BackingStore?.Set("keyCredential", value); }
        }
#endif
        /// <summary>The passwordCredential property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PasswordCredential? PasswordCredential {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PasswordCredential?>("passwordCredential"); }
            set { BackingStore?.Set("passwordCredential", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PasswordCredential PasswordCredential {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PasswordCredential>("passwordCredential"); }
            set { BackingStore?.Set("passwordCredential", value); }
        }
#endif
        /// <summary>The proof property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Proof {
            get { return BackingStore?.Get<string?>("proof"); }
            set { BackingStore?.Set("proof", value); }
        }
#nullable restore
#else
        public string Proof {
            get { return BackingStore?.Get<string>("proof"); }
            set { BackingStore?.Set("proof", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new addKeyPostRequestBody and sets the default values.
        /// </summary>
        public AddKeyPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AddKeyPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddKeyPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"keyCredential", n => { KeyCredential = n.GetObjectValue<Microsoft.Graph.Models.KeyCredential>(Microsoft.Graph.Models.KeyCredential.CreateFromDiscriminatorValue); } },
                {"passwordCredential", n => { PasswordCredential = n.GetObjectValue<Microsoft.Graph.Models.PasswordCredential>(Microsoft.Graph.Models.PasswordCredential.CreateFromDiscriminatorValue); } },
                {"proof", n => { Proof = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.KeyCredential>("keyCredential", KeyCredential);
            writer.WriteObjectValue<Microsoft.Graph.Models.PasswordCredential>("passwordCredential", PasswordCredential);
            writer.WriteStringValue("proof", Proof);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
