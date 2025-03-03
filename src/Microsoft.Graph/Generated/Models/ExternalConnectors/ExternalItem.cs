using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.ExternalConnectors {
    public class ExternalItem : Entity, IParsable {
        /// <summary>An array of access control entries. Each entry specifies the access granted to a user or group. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.ExternalConnectors.Acl>? Acl {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ExternalConnectors.Acl>?>("acl"); }
            set { BackingStore?.Set("acl", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.ExternalConnectors.Acl> Acl {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ExternalConnectors.Acl>>("acl"); }
            set { BackingStore?.Set("acl", value); }
        }
#endif
        /// <summary>A plain-text  representation of the contents of the item. The text in this property is full-text indexed. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExternalItemContent? Content {
            get { return BackingStore?.Get<ExternalItemContent?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public ExternalItemContent Content {
            get { return BackingStore?.Get<ExternalItemContent>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>A property bag with the properties of the item. The properties MUST conform to the schema defined for the externalConnection. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ExternalConnectors.Properties? Properties {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ExternalConnectors.Properties?>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ExternalConnectors.Properties Properties {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ExternalConnectors.Properties>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acl", n => { Acl = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.ExternalConnectors.Acl>(Microsoft.Graph.Models.ExternalConnectors.Acl.CreateFromDiscriminatorValue)?.ToList(); } },
                {"content", n => { Content = n.GetObjectValue<ExternalItemContent>(ExternalItemContent.CreateFromDiscriminatorValue); } },
                {"properties", n => { Properties = n.GetObjectValue<Microsoft.Graph.Models.ExternalConnectors.Properties>(Microsoft.Graph.Models.ExternalConnectors.Properties.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.ExternalConnectors.Acl>("acl", Acl);
            writer.WriteObjectValue<ExternalItemContent>("content", Content);
            writer.WriteObjectValue<Microsoft.Graph.Models.ExternalConnectors.Properties>("properties", Properties);
        }
    }
}
