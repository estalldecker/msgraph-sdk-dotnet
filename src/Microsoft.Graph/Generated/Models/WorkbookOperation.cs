using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class WorkbookOperation : Entity, IParsable {
        /// <summary>The error returned by the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookOperationError? Error {
            get { return BackingStore?.Get<WorkbookOperationError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public WorkbookOperationError Error {
            get { return BackingStore?.Get<WorkbookOperationError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>The resource URI for the result.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceLocation {
            get { return BackingStore?.Get<string?>("resourceLocation"); }
            set { BackingStore?.Set("resourceLocation", value); }
        }
#nullable restore
#else
        public string ResourceLocation {
            get { return BackingStore?.Get<string>("resourceLocation"); }
            set { BackingStore?.Set("resourceLocation", value); }
        }
#endif
        /// <summary>The status property</summary>
        public WorkbookOperationStatus? Status {
            get { return BackingStore?.Get<WorkbookOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"error", n => { Error = n.GetObjectValue<WorkbookOperationError>(WorkbookOperationError.CreateFromDiscriminatorValue); } },
                {"resourceLocation", n => { ResourceLocation = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<WorkbookOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookOperationError>("error", Error);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
            writer.WriteEnumValue<WorkbookOperationStatus>("status", Status);
        }
    }
}
