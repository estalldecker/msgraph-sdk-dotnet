using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Solutions.BookingBusinesses.Item.GetStaffAvailability {
    public class GetStaffAvailabilityPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The endDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? EndDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone EndDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#endif
        /// <summary>The staffIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StaffIds {
            get { return BackingStore?.Get<List<string>?>("staffIds"); }
            set { BackingStore?.Set("staffIds", value); }
        }
#nullable restore
#else
        public List<string> StaffIds {
            get { return BackingStore?.Get<List<string>>("staffIds"); }
            set { BackingStore?.Set("staffIds", value); }
        }
#endif
        /// <summary>The startDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new getStaffAvailabilityPostRequestBody and sets the default values.
        /// </summary>
        public GetStaffAvailabilityPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetStaffAvailabilityPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetStaffAvailabilityPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endDateTime", n => { EndDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"staffIds", n => { StaffIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("staffIds", StaffIds);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
