using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SharedInsight : Entity, IParsable {
        /// <summary>Details about the shared item. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingDetail? LastShared {
            get { return BackingStore?.Get<SharingDetail?>("lastShared"); }
            set { BackingStore?.Set("lastShared", value); }
        }
#nullable restore
#else
        public SharingDetail LastShared {
            get { return BackingStore?.Get<SharingDetail>("lastShared"); }
            set { BackingStore?.Set("lastShared", value); }
        }
#endif
        /// <summary>The lastSharedMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? LastSharedMethod {
            get { return BackingStore?.Get<Entity?>("lastSharedMethod"); }
            set { BackingStore?.Set("lastSharedMethod", value); }
        }
#nullable restore
#else
        public Entity LastSharedMethod {
            get { return BackingStore?.Get<Entity>("lastSharedMethod"); }
            set { BackingStore?.Set("lastSharedMethod", value); }
        }
#endif
        /// <summary>Used for navigating to the item that was shared. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? Resource {
            get { return BackingStore?.Get<Entity?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public Entity Resource {
            get { return BackingStore?.Get<Entity>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>Reference properties of the shared document, such as the url and type of the document. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ResourceReference? ResourceReference {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResourceReference?>("resourceReference"); }
            set { BackingStore?.Set("resourceReference", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ResourceReference ResourceReference {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResourceReference>("resourceReference"); }
            set { BackingStore?.Set("resourceReference", value); }
        }
#endif
        /// <summary>Properties that you can use to visualize the document in your experience. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ResourceVisualization? ResourceVisualization {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResourceVisualization?>("resourceVisualization"); }
            set { BackingStore?.Set("resourceVisualization", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ResourceVisualization ResourceVisualization {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResourceVisualization>("resourceVisualization"); }
            set { BackingStore?.Set("resourceVisualization", value); }
        }
#endif
        /// <summary>The sharingHistory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SharingDetail>? SharingHistory {
            get { return BackingStore?.Get<List<SharingDetail>?>("sharingHistory"); }
            set { BackingStore?.Set("sharingHistory", value); }
        }
#nullable restore
#else
        public List<SharingDetail> SharingHistory {
            get { return BackingStore?.Get<List<SharingDetail>>("sharingHistory"); }
            set { BackingStore?.Set("sharingHistory", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharedInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastShared", n => { LastShared = n.GetObjectValue<SharingDetail>(SharingDetail.CreateFromDiscriminatorValue); } },
                {"lastSharedMethod", n => { LastSharedMethod = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", n => { ResourceReference = n.GetObjectValue<Microsoft.Graph.Models.ResourceReference>(Microsoft.Graph.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<Microsoft.Graph.Models.ResourceVisualization>(Microsoft.Graph.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
                {"sharingHistory", n => { SharingHistory = n.GetCollectionOfObjectValues<SharingDetail>(SharingDetail.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SharingDetail>("lastShared", LastShared);
            writer.WriteObjectValue<Entity>("lastSharedMethod", LastSharedMethod);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteCollectionOfObjectValues<SharingDetail>("sharingHistory", SharingHistory);
        }
    }
}
