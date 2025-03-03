using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class TeamsAsyncOperation : Entity, IParsable {
        /// <summary>Number of times the operation was attempted before being marked successful or failed.</summary>
        public int? AttemptsCount {
            get { return BackingStore?.Get<int?>("attemptsCount"); }
            set { BackingStore?.Set("attemptsCount", value); }
        }
        /// <summary>Time when the operation was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Any error that causes the async operation to fail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OperationError? Error {
            get { return BackingStore?.Get<OperationError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public OperationError Error {
            get { return BackingStore?.Get<OperationError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>Time when the async operation was last updated.</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The operationType property</summary>
        public TeamsAsyncOperationType? OperationType {
            get { return BackingStore?.Get<TeamsAsyncOperationType?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
        /// <summary>The status property</summary>
        public TeamsAsyncOperationStatus? Status {
            get { return BackingStore?.Get<TeamsAsyncOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The ID of the object that&apos;s created or modified as result of this async operation, typically a team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetResourceId {
            get { return BackingStore?.Get<string?>("targetResourceId"); }
            set { BackingStore?.Set("targetResourceId", value); }
        }
#nullable restore
#else
        public string TargetResourceId {
            get { return BackingStore?.Get<string>("targetResourceId"); }
            set { BackingStore?.Set("targetResourceId", value); }
        }
#endif
        /// <summary>The location of the object that&apos;s created or modified as result of this async operation. This URL should be treated as an opaque value and not parsed into its component paths.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetResourceLocation {
            get { return BackingStore?.Get<string?>("targetResourceLocation"); }
            set { BackingStore?.Set("targetResourceLocation", value); }
        }
#nullable restore
#else
        public string TargetResourceLocation {
            get { return BackingStore?.Get<string>("targetResourceLocation"); }
            set { BackingStore?.Set("targetResourceLocation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamsAsyncOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAsyncOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attemptsCount", n => { AttemptsCount = n.GetIntValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", n => { Error = n.GetObjectValue<OperationError>(OperationError.CreateFromDiscriminatorValue); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationType", n => { OperationType = n.GetEnumValue<TeamsAsyncOperationType>(); } },
                {"status", n => { Status = n.GetEnumValue<TeamsAsyncOperationStatus>(); } },
                {"targetResourceId", n => { TargetResourceId = n.GetStringValue(); } },
                {"targetResourceLocation", n => { TargetResourceLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("attemptsCount", AttemptsCount);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<OperationError>("error", Error);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteEnumValue<TeamsAsyncOperationType>("operationType", OperationType);
            writer.WriteEnumValue<TeamsAsyncOperationStatus>("status", Status);
            writer.WriteStringValue("targetResourceId", TargetResourceId);
            writer.WriteStringValue("targetResourceLocation", TargetResourceLocation);
        }
    }
}
