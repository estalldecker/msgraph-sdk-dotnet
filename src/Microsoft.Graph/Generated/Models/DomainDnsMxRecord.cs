using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class DomainDnsMxRecord : DomainDnsRecord, IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Value used when configuring the answer/destination/value of the MX record at the DNS host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailExchange {
            get { return BackingStore?.Get<string?>("mailExchange"); }
            set { BackingStore?.Set("mailExchange", value); }
        }
#nullable restore
#else
        public string MailExchange {
            get { return BackingStore?.Get<string>("mailExchange"); }
            set { BackingStore?.Set("mailExchange", value); }
        }
#endif
        /// <summary>Value used when configuring the Preference/Priority property of the MX record at the DNS host.</summary>
        public int? Preference {
            get { return BackingStore?.Get<int?>("preference"); }
            set { BackingStore?.Set("preference", value); }
        }
        /// <summary>
        /// Instantiates a new DomainDnsMxRecord and sets the default values.
        /// </summary>
        public DomainDnsMxRecord() : base() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DomainDnsMxRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DomainDnsMxRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"mailExchange", n => { MailExchange = n.GetStringValue(); } },
                {"preference", n => { Preference = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("mailExchange", MailExchange);
            writer.WriteIntValue("preference", Preference);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
