using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.ODataErrors {
    public class InnerError : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Client request Id as sent by the client application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientRequestId {
            get { return BackingStore?.Get<string?>("client-request-id"); }
            set { BackingStore?.Set("client-request-id", value); }
        }
#nullable restore
#else
        public string ClientRequestId {
            get { return BackingStore?.Get<string>("client-request-id"); }
            set { BackingStore?.Set("client-request-id", value); }
        }
#endif
        /// <summary>Date when the error occured.</summary>
        public DateTimeOffset? Date {
            get { return BackingStore?.Get<DateTimeOffset?>("Date"); }
            set { BackingStore?.Set("Date", value); }
        }
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
        /// <summary>Request Id as tracked internally by the service</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestId {
            get { return BackingStore?.Get<string?>("request-id"); }
            set { BackingStore?.Set("request-id", value); }
        }
#nullable restore
#else
        public string RequestId {
            get { return BackingStore?.Get<string>("request-id"); }
            set { BackingStore?.Set("request-id", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new InnerError and sets the default values.
        /// </summary>
        public InnerError() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InnerError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InnerError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"client-request-id", n => { ClientRequestId = n.GetStringValue(); } },
                {"Date", n => { Date = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"request-id", n => { RequestId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("client-request-id", ClientRequestId);
            writer.WriteDateTimeOffsetValue("Date", Date);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("request-id", RequestId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
