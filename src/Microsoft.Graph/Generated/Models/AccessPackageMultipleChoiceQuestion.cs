using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AccessPackageMultipleChoiceQuestion : AccessPackageQuestion, IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of answer choices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAnswerChoice>? Choices {
            get { return BackingStore?.Get<List<AccessPackageAnswerChoice>?>("choices"); }
            set { BackingStore?.Set("choices", value); }
        }
#nullable restore
#else
        public List<AccessPackageAnswerChoice> Choices {
            get { return BackingStore?.Get<List<AccessPackageAnswerChoice>>("choices"); }
            set { BackingStore?.Set("choices", value); }
        }
#endif
        /// <summary>Indicates whether requestor can select multiple choices as their answer.</summary>
        public bool? IsMultipleSelectionAllowed {
            get { return BackingStore?.Get<bool?>("isMultipleSelectionAllowed"); }
            set { BackingStore?.Set("isMultipleSelectionAllowed", value); }
        }
        /// <summary>
        /// Instantiates a new AccessPackageMultipleChoiceQuestion and sets the default values.
        /// </summary>
        public AccessPackageMultipleChoiceQuestion() : base() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.accessPackageMultipleChoiceQuestion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageMultipleChoiceQuestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageMultipleChoiceQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"choices", n => { Choices = n.GetCollectionOfObjectValues<AccessPackageAnswerChoice>(AccessPackageAnswerChoice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isMultipleSelectionAllowed", n => { IsMultipleSelectionAllowed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessPackageAnswerChoice>("choices", Choices);
            writer.WriteBoolValue("isMultipleSelectionAllowed", IsMultipleSelectionAllowed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
