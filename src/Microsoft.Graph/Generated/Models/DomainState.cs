using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class DomainState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Timestamp for when the last activity occurred. The value is updated when an operation is scheduled, the asynchronous task starts, and when the operation completes.</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
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
        /// <summary>Type of asynchronous operation. The values can be ForceDelete or Verification</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operation {
            get { return BackingStore?.Get<string?>("operation"); }
            set { BackingStore?.Set("operation", value); }
        }
#nullable restore
#else
        public string Operation {
            get { return BackingStore?.Get<string>("operation"); }
            set { BackingStore?.Set("operation", value); }
        }
#endif
        /// <summary>Current status of the operation.  Scheduled - Operation has been scheduled but has not started.  InProgress - Task has started and is in progress.  Failed - Operation has failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new domainState and sets the default values.
        /// </summary>
        public DomainState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DomainState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DomainState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operation", n => { Operation = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operation", Operation);
            writer.WriteStringValue("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
