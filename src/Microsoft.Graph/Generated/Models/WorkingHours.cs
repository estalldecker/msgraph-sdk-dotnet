using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class WorkingHours : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The days of the week on which the user works.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DayOfWeekObject?>? DaysOfWeek {
            get { return BackingStore?.Get<List<DayOfWeekObject?>?>("daysOfWeek"); }
            set { BackingStore?.Set("daysOfWeek", value); }
        }
#nullable restore
#else
        public List<DayOfWeekObject?> DaysOfWeek {
            get { return BackingStore?.Get<List<DayOfWeekObject?>>("daysOfWeek"); }
            set { BackingStore?.Set("daysOfWeek", value); }
        }
#endif
        /// <summary>The time of the day that the user stops working.</summary>
        public Time? EndTime {
            get { return BackingStore?.Get<Time?>("endTime"); }
            set { BackingStore?.Set("endTime", value); }
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
        /// <summary>The time of the day that the user starts working.</summary>
        public Time? StartTime {
            get { return BackingStore?.Get<Time?>("startTime"); }
            set { BackingStore?.Set("startTime", value); }
        }
        /// <summary>The time zone to which the working hours apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeZoneBase? TimeZone {
            get { return BackingStore?.Get<TimeZoneBase?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#nullable restore
#else
        public TimeZoneBase TimeZone {
            get { return BackingStore?.Get<TimeZoneBase>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new workingHours and sets the default values.
        /// </summary>
        public WorkingHours() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkingHours CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkingHours();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"daysOfWeek", n => { DaysOfWeek = n.GetCollectionOfEnumValues<DayOfWeekObject>()?.ToList(); } },
                {"endTime", n => { EndTime = n.GetTimeValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"startTime", n => { StartTime = n.GetTimeValue(); } },
                {"timeZone", n => { TimeZone = n.GetObjectValue<TimeZoneBase>(TimeZoneBase.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<DayOfWeekObject>("daysOfWeek", DaysOfWeek);
            writer.WriteTimeValue("endTime", EndTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteTimeValue("startTime", StartTime);
            writer.WriteObjectValue<TimeZoneBase>("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
