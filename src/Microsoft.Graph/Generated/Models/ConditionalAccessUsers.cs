using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ConditionalAccessUsers : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Group IDs excluded from scope of policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeGroups {
            get { return BackingStore?.Get<List<string>?>("excludeGroups"); }
            set { BackingStore?.Set("excludeGroups", value); }
        }
#nullable restore
#else
        public List<string> ExcludeGroups {
            get { return BackingStore?.Get<List<string>>("excludeGroups"); }
            set { BackingStore?.Set("excludeGroups", value); }
        }
#endif
        /// <summary>The excludeGuestsOrExternalUsers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessGuestsOrExternalUsers? ExcludeGuestsOrExternalUsers {
            get { return BackingStore?.Get<ConditionalAccessGuestsOrExternalUsers?>("excludeGuestsOrExternalUsers"); }
            set { BackingStore?.Set("excludeGuestsOrExternalUsers", value); }
        }
#nullable restore
#else
        public ConditionalAccessGuestsOrExternalUsers ExcludeGuestsOrExternalUsers {
            get { return BackingStore?.Get<ConditionalAccessGuestsOrExternalUsers>("excludeGuestsOrExternalUsers"); }
            set { BackingStore?.Set("excludeGuestsOrExternalUsers", value); }
        }
#endif
        /// <summary>Role IDs excluded from scope of policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeRoles {
            get { return BackingStore?.Get<List<string>?>("excludeRoles"); }
            set { BackingStore?.Set("excludeRoles", value); }
        }
#nullable restore
#else
        public List<string> ExcludeRoles {
            get { return BackingStore?.Get<List<string>>("excludeRoles"); }
            set { BackingStore?.Set("excludeRoles", value); }
        }
#endif
        /// <summary>User IDs excluded from scope of policy and/or GuestsOrExternalUsers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeUsers {
            get { return BackingStore?.Get<List<string>?>("excludeUsers"); }
            set { BackingStore?.Set("excludeUsers", value); }
        }
#nullable restore
#else
        public List<string> ExcludeUsers {
            get { return BackingStore?.Get<List<string>>("excludeUsers"); }
            set { BackingStore?.Set("excludeUsers", value); }
        }
#endif
        /// <summary>Group IDs in scope of policy unless explicitly excluded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeGroups {
            get { return BackingStore?.Get<List<string>?>("includeGroups"); }
            set { BackingStore?.Set("includeGroups", value); }
        }
#nullable restore
#else
        public List<string> IncludeGroups {
            get { return BackingStore?.Get<List<string>>("includeGroups"); }
            set { BackingStore?.Set("includeGroups", value); }
        }
#endif
        /// <summary>The includeGuestsOrExternalUsers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessGuestsOrExternalUsers? IncludeGuestsOrExternalUsers {
            get { return BackingStore?.Get<ConditionalAccessGuestsOrExternalUsers?>("includeGuestsOrExternalUsers"); }
            set { BackingStore?.Set("includeGuestsOrExternalUsers", value); }
        }
#nullable restore
#else
        public ConditionalAccessGuestsOrExternalUsers IncludeGuestsOrExternalUsers {
            get { return BackingStore?.Get<ConditionalAccessGuestsOrExternalUsers>("includeGuestsOrExternalUsers"); }
            set { BackingStore?.Set("includeGuestsOrExternalUsers", value); }
        }
#endif
        /// <summary>Role IDs in scope of policy unless explicitly excluded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeRoles {
            get { return BackingStore?.Get<List<string>?>("includeRoles"); }
            set { BackingStore?.Set("includeRoles", value); }
        }
#nullable restore
#else
        public List<string> IncludeRoles {
            get { return BackingStore?.Get<List<string>>("includeRoles"); }
            set { BackingStore?.Set("includeRoles", value); }
        }
#endif
        /// <summary>User IDs in scope of policy unless explicitly excluded, None, All, or GuestsOrExternalUsers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeUsers {
            get { return BackingStore?.Get<List<string>?>("includeUsers"); }
            set { BackingStore?.Set("includeUsers", value); }
        }
#nullable restore
#else
        public List<string> IncludeUsers {
            get { return BackingStore?.Get<List<string>>("includeUsers"); }
            set { BackingStore?.Set("includeUsers", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new conditionalAccessUsers and sets the default values.
        /// </summary>
        public ConditionalAccessUsers() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessUsers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessUsers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeGroups", n => { ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"excludeGuestsOrExternalUsers", n => { ExcludeGuestsOrExternalUsers = n.GetObjectValue<ConditionalAccessGuestsOrExternalUsers>(ConditionalAccessGuestsOrExternalUsers.CreateFromDiscriminatorValue); } },
                {"excludeRoles", n => { ExcludeRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"excludeUsers", n => { ExcludeUsers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeGroups", n => { IncludeGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeGuestsOrExternalUsers", n => { IncludeGuestsOrExternalUsers = n.GetObjectValue<ConditionalAccessGuestsOrExternalUsers>(ConditionalAccessGuestsOrExternalUsers.CreateFromDiscriminatorValue); } },
                {"includeRoles", n => { IncludeRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeUsers", n => { IncludeUsers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeGroups", ExcludeGroups);
            writer.WriteObjectValue<ConditionalAccessGuestsOrExternalUsers>("excludeGuestsOrExternalUsers", ExcludeGuestsOrExternalUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeRoles", ExcludeRoles);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeUsers", ExcludeUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeGroups", IncludeGroups);
            writer.WriteObjectValue<ConditionalAccessGuestsOrExternalUsers>("includeGuestsOrExternalUsers", IncludeGuestsOrExternalUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeRoles", IncludeRoles);
            writer.WriteCollectionOfPrimitiveValues<string>("includeUsers", IncludeUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
