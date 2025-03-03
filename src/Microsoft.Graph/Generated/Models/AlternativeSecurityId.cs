using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AlternativeSecurityId : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>For internal use only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityProvider {
            get { return BackingStore?.Get<string?>("identityProvider"); }
            set { BackingStore?.Set("identityProvider", value); }
        }
#nullable restore
#else
        public string IdentityProvider {
            get { return BackingStore?.Get<string>("identityProvider"); }
            set { BackingStore?.Set("identityProvider", value); }
        }
#endif
        /// <summary>For internal use only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Key {
            get { return BackingStore?.Get<byte[]?>("key"); }
            set { BackingStore?.Set("key", value); }
        }
#nullable restore
#else
        public byte[] Key {
            get { return BackingStore?.Get<byte[]>("key"); }
            set { BackingStore?.Set("key", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>For internal use only</summary>
        public int? Type {
            get { return BackingStore?.Get<int?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new alternativeSecurityId and sets the default values.
        /// </summary>
        public AlternativeSecurityId() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AlternativeSecurityId CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlternativeSecurityId();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"identityProvider", n => { IdentityProvider = n.GetStringValue(); } },
                {"key", n => { Key = n.GetByteArrayValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"type", n => { Type = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("identityProvider", IdentityProvider);
            writer.WriteByteArrayValue("key", Key);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
