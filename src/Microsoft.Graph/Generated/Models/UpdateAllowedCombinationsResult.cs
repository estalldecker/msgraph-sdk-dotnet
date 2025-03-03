using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UpdateAllowedCombinationsResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Information about why the updateAllowedCombinations action was successful or failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation {
            get { return BackingStore?.Get<string?>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#nullable restore
#else
        public string AdditionalInformation {
            get { return BackingStore?.Get<string>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>References to existing Conditional Access policies that use this authentication strength.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ConditionalAccessReferences {
            get { return BackingStore?.Get<List<string>?>("conditionalAccessReferences"); }
            set { BackingStore?.Set("conditionalAccessReferences", value); }
        }
#nullable restore
#else
        public List<string> ConditionalAccessReferences {
            get { return BackingStore?.Get<List<string>>("conditionalAccessReferences"); }
            set { BackingStore?.Set("conditionalAccessReferences", value); }
        }
#endif
        /// <summary>The list of current authentication method combinations allowed by the authentication strength.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodModes?>? CurrentCombinations {
            get { return BackingStore?.Get<List<AuthenticationMethodModes?>?>("currentCombinations"); }
            set { BackingStore?.Set("currentCombinations", value); }
        }
#nullable restore
#else
        public List<AuthenticationMethodModes?> CurrentCombinations {
            get { return BackingStore?.Get<List<AuthenticationMethodModes?>>("currentCombinations"); }
            set { BackingStore?.Set("currentCombinations", value); }
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
        /// <summary>The list of former authentication method combinations allowed by the authentication strength before they were updated through the updateAllowedCombinations action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodModes?>? PreviousCombinations {
            get { return BackingStore?.Get<List<AuthenticationMethodModes?>?>("previousCombinations"); }
            set { BackingStore?.Set("previousCombinations", value); }
        }
#nullable restore
#else
        public List<AuthenticationMethodModes?> PreviousCombinations {
            get { return BackingStore?.Get<List<AuthenticationMethodModes?>>("previousCombinations"); }
            set { BackingStore?.Set("previousCombinations", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new updateAllowedCombinationsResult and sets the default values.
        /// </summary>
        public UpdateAllowedCombinationsResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateAllowedCombinationsResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAllowedCombinationsResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"conditionalAccessReferences", n => { ConditionalAccessReferences = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"currentCombinations", n => { CurrentCombinations = n.GetCollectionOfEnumValues<AuthenticationMethodModes>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"previousCombinations", n => { PreviousCombinations = n.GetCollectionOfEnumValues<AuthenticationMethodModes>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteCollectionOfPrimitiveValues<string>("conditionalAccessReferences", ConditionalAccessReferences);
            writer.WriteCollectionOfEnumValues<AuthenticationMethodModes>("currentCombinations", CurrentCombinations);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfEnumValues<AuthenticationMethodModes>("previousCombinations", PreviousCombinations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
