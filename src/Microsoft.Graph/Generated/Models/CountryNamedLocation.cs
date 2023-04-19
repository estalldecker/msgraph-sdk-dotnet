using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CountryNamedLocation : NamedLocation, IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of countries and/or regions in two-letter format specified by ISO 3166-2. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CountriesAndRegions {
            get { return BackingStore?.Get<List<string>?>("countriesAndRegions"); }
            set { BackingStore?.Set("countriesAndRegions", value); }
        }
#nullable restore
#else
        public List<string> CountriesAndRegions {
            get { return BackingStore?.Get<List<string>>("countriesAndRegions"); }
            set { BackingStore?.Set("countriesAndRegions", value); }
        }
#endif
        /// <summary>Determines what method is used to decide which country the user is located in. Possible values are clientIpAddress(default) and authenticatorAppGps. Note: authenticatorAppGps is not yet supported in the Microsoft Cloud for US Government.</summary>
        public CountryLookupMethodType? CountryLookupMethod {
            get { return BackingStore?.Get<CountryLookupMethodType?>("countryLookupMethod"); }
            set { BackingStore?.Set("countryLookupMethod", value); }
        }
        /// <summary>true if IP addresses that don&apos;t map to a country or region should be included in the named location. Optional. Default value is false.</summary>
        public bool? IncludeUnknownCountriesAndRegions {
            get { return BackingStore?.Get<bool?>("includeUnknownCountriesAndRegions"); }
            set { BackingStore?.Set("includeUnknownCountriesAndRegions", value); }
        }
        /// <summary>
        /// Instantiates a new CountryNamedLocation and sets the default values.
        /// </summary>
        public CountryNamedLocation() : base() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CountryNamedLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CountryNamedLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"countriesAndRegions", n => { CountriesAndRegions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"countryLookupMethod", n => { CountryLookupMethod = n.GetEnumValue<CountryLookupMethodType>(); } },
                {"includeUnknownCountriesAndRegions", n => { IncludeUnknownCountriesAndRegions = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("countriesAndRegions", CountriesAndRegions);
            writer.WriteEnumValue<CountryLookupMethodType>("countryLookupMethod", CountryLookupMethod);
            writer.WriteBoolValue("includeUnknownCountriesAndRegions", IncludeUnknownCountriesAndRegions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
