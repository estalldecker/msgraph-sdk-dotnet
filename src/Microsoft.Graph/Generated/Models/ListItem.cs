using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ListItem : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? Analytics {
            get { return BackingStore?.Get<ItemAnalytics?>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#nullable restore
#else
        public ItemAnalytics Analytics {
            get { return BackingStore?.Get<ItemAnalytics>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#endif
        /// <summary>The content type of this list item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentTypeInfo? ContentType {
            get { return BackingStore?.Get<ContentTypeInfo?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#nullable restore
#else
        public ContentTypeInfo ContentType {
            get { return BackingStore?.Get<ContentTypeInfo>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#endif
        /// <summary>Version information for a document set version created by a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DocumentSetVersion>? DocumentSetVersions {
            get { return BackingStore?.Get<List<DocumentSetVersion>?>("documentSetVersions"); }
            set { BackingStore?.Set("documentSetVersions", value); }
        }
#nullable restore
#else
        public List<DocumentSetVersion> DocumentSetVersions {
            get { return BackingStore?.Get<List<DocumentSetVersion>>("documentSetVersions"); }
            set { BackingStore?.Set("documentSetVersions", value); }
        }
#endif
        /// <summary>For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DriveItem? DriveItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DriveItem?>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DriveItem DriveItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DriveItem>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#endif
        /// <summary>The values of the columns set on this list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FieldValueSet? Fields {
            get { return BackingStore?.Get<FieldValueSet?>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#nullable restore
#else
        public FieldValueSet Fields {
            get { return BackingStore?.Get<FieldValueSet>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SharepointIds? SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SharepointIds?>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SharepointIds SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SharepointIds>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#endif
        /// <summary>The list of previous versions of the list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ListItemVersion>? Versions {
            get { return BackingStore?.Get<List<ListItemVersion>?>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
#nullable restore
#else
        public List<ListItemVersion> Versions {
            get { return BackingStore?.Get<List<ListItemVersion>>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new listItem and sets the default values.
        /// </summary>
        public ListItem() : base() {
            OdataType = "#microsoft.graph.listItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ListItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"contentType", n => { ContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"documentSetVersions", n => { DocumentSetVersions = n.GetCollectionOfObjectValues<DocumentSetVersion>(DocumentSetVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"driveItem", n => { DriveItem = n.GetObjectValue<Microsoft.Graph.Models.DriveItem>(Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"fields", n => { Fields = n.GetObjectValue<FieldValueSet>(FieldValueSet.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Models.SharepointIds>(Microsoft.Graph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<ListItemVersion>(ListItemVersion.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<ContentTypeInfo>("contentType", ContentType);
            writer.WriteCollectionOfObjectValues<DocumentSetVersion>("documentSetVersions", DocumentSetVersions);
            writer.WriteObjectValue<Microsoft.Graph.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<FieldValueSet>("fields", Fields);
            writer.WriteObjectValue<Microsoft.Graph.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<ListItemVersion>("versions", Versions);
        }
    }
}
