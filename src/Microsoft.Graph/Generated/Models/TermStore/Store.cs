using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.TermStore {
    public class Store : Entity, IParsable {
        /// <summary>Default language of the term store.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultLanguageTag {
            get { return BackingStore?.Get<string?>("defaultLanguageTag"); }
            set { BackingStore?.Set("defaultLanguageTag", value); }
        }
#nullable restore
#else
        public string DefaultLanguageTag {
            get { return BackingStore?.Get<string>("defaultLanguageTag"); }
            set { BackingStore?.Set("defaultLanguageTag", value); }
        }
#endif
        /// <summary>Collection of all groups available in the term store.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Group>? Groups {
            get { return BackingStore?.Get<List<Group>?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#nullable restore
#else
        public List<Group> Groups {
            get { return BackingStore?.Get<List<Group>>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#endif
        /// <summary>List of languages for the term store.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LanguageTags {
            get { return BackingStore?.Get<List<string>?>("languageTags"); }
            set { BackingStore?.Set("languageTags", value); }
        }
#nullable restore
#else
        public List<string> LanguageTags {
            get { return BackingStore?.Get<List<string>>("languageTags"); }
            set { BackingStore?.Set("languageTags", value); }
        }
#endif
        /// <summary>Collection of all sets available in the term store. This relationship can only be used to load a specific term set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Set>? Sets {
            get { return BackingStore?.Get<List<Set>?>("sets"); }
            set { BackingStore?.Set("sets", value); }
        }
#nullable restore
#else
        public List<Set> Sets {
            get { return BackingStore?.Get<List<Set>>("sets"); }
            set { BackingStore?.Set("sets", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Store CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Store();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultLanguageTag", n => { DefaultLanguageTag = n.GetStringValue(); } },
                {"groups", n => { Groups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue)?.ToList(); } },
                {"languageTags", n => { LanguageTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sets", n => { Sets = n.GetCollectionOfObjectValues<Set>(Set.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultLanguageTag", DefaultLanguageTag);
            writer.WriteCollectionOfObjectValues<Group>("groups", Groups);
            writer.WriteCollectionOfPrimitiveValues<string>("languageTags", LanguageTags);
            writer.WriteCollectionOfObjectValues<Set>("sets", Sets);
        }
    }
}
