using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class PrinterLocation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The altitude, in meters, that the printer is located at.</summary>
        public int? AltitudeInMeters {
            get { return BackingStore?.Get<int?>("altitudeInMeters"); }
            set { BackingStore?.Set("altitudeInMeters", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The building that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Building {
            get { return BackingStore?.Get<string?>("building"); }
            set { BackingStore?.Set("building", value); }
        }
#nullable restore
#else
        public string Building {
            get { return BackingStore?.Get<string>("building"); }
            set { BackingStore?.Set("building", value); }
        }
#endif
        /// <summary>The city that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City {
            get { return BackingStore?.Get<string?>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#nullable restore
#else
        public string City {
            get { return BackingStore?.Get<string>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#endif
        /// <summary>The country or region that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion {
            get { return BackingStore?.Get<string?>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#nullable restore
#else
        public string CountryOrRegion {
            get { return BackingStore?.Get<string>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#endif
        /// <summary>The floor that the printer is located on. Only numerical values are supported right now.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Floor {
            get { return BackingStore?.Get<string?>("floor"); }
            set { BackingStore?.Set("floor", value); }
        }
#nullable restore
#else
        public string Floor {
            get { return BackingStore?.Get<string>("floor"); }
            set { BackingStore?.Set("floor", value); }
        }
#endif
        /// <summary>The description of the floor that the printer is located on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FloorDescription {
            get { return BackingStore?.Get<string?>("floorDescription"); }
            set { BackingStore?.Set("floorDescription", value); }
        }
#nullable restore
#else
        public string FloorDescription {
            get { return BackingStore?.Get<string>("floorDescription"); }
            set { BackingStore?.Set("floorDescription", value); }
        }
#endif
        /// <summary>The latitude that the printer is located at.</summary>
        public double? Latitude {
            get { return BackingStore?.Get<double?>("latitude"); }
            set { BackingStore?.Set("latitude", value); }
        }
        /// <summary>The longitude that the printer is located at.</summary>
        public double? Longitude {
            get { return BackingStore?.Get<double?>("longitude"); }
            set { BackingStore?.Set("longitude", value); }
        }
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
        /// <summary>The organizational hierarchy that the printer belongs to. The elements should be in hierarchical order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Organization {
            get { return BackingStore?.Get<List<string>?>("organization"); }
            set { BackingStore?.Set("organization", value); }
        }
#nullable restore
#else
        public List<string> Organization {
            get { return BackingStore?.Get<List<string>>("organization"); }
            set { BackingStore?.Set("organization", value); }
        }
#endif
        /// <summary>The postal code that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode {
            get { return BackingStore?.Get<string?>("postalCode"); }
            set { BackingStore?.Set("postalCode", value); }
        }
#nullable restore
#else
        public string PostalCode {
            get { return BackingStore?.Get<string>("postalCode"); }
            set { BackingStore?.Set("postalCode", value); }
        }
#endif
        /// <summary>The description of the room that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoomDescription {
            get { return BackingStore?.Get<string?>("roomDescription"); }
            set { BackingStore?.Set("roomDescription", value); }
        }
#nullable restore
#else
        public string RoomDescription {
            get { return BackingStore?.Get<string>("roomDescription"); }
            set { BackingStore?.Set("roomDescription", value); }
        }
#endif
        /// <summary>The room that the printer is located in. Only numerical values are supported right now.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoomName {
            get { return BackingStore?.Get<string?>("roomName"); }
            set { BackingStore?.Set("roomName", value); }
        }
#nullable restore
#else
        public string RoomName {
            get { return BackingStore?.Get<string>("roomName"); }
            set { BackingStore?.Set("roomName", value); }
        }
#endif
        /// <summary>The site that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Site {
            get { return BackingStore?.Get<string?>("site"); }
            set { BackingStore?.Set("site", value); }
        }
#nullable restore
#else
        public string Site {
            get { return BackingStore?.Get<string>("site"); }
            set { BackingStore?.Set("site", value); }
        }
#endif
        /// <summary>The state or province that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateOrProvince {
            get { return BackingStore?.Get<string?>("stateOrProvince"); }
            set { BackingStore?.Set("stateOrProvince", value); }
        }
#nullable restore
#else
        public string StateOrProvince {
            get { return BackingStore?.Get<string>("stateOrProvince"); }
            set { BackingStore?.Set("stateOrProvince", value); }
        }
#endif
        /// <summary>The street address where the printer is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StreetAddress {
            get { return BackingStore?.Get<string?>("streetAddress"); }
            set { BackingStore?.Set("streetAddress", value); }
        }
#nullable restore
#else
        public string StreetAddress {
            get { return BackingStore?.Get<string>("streetAddress"); }
            set { BackingStore?.Set("streetAddress", value); }
        }
#endif
        /// <summary>The subdivision that the printer is located in. The elements should be in hierarchical order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Subdivision {
            get { return BackingStore?.Get<List<string>?>("subdivision"); }
            set { BackingStore?.Set("subdivision", value); }
        }
#nullable restore
#else
        public List<string> Subdivision {
            get { return BackingStore?.Get<List<string>>("subdivision"); }
            set { BackingStore?.Set("subdivision", value); }
        }
#endif
        /// <summary>The subunit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Subunit {
            get { return BackingStore?.Get<List<string>?>("subunit"); }
            set { BackingStore?.Set("subunit", value); }
        }
#nullable restore
#else
        public List<string> Subunit {
            get { return BackingStore?.Get<List<string>>("subunit"); }
            set { BackingStore?.Set("subunit", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new printerLocation and sets the default values.
        /// </summary>
        public PrinterLocation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrinterLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"altitudeInMeters", n => { AltitudeInMeters = n.GetIntValue(); } },
                {"building", n => { Building = n.GetStringValue(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"floor", n => { Floor = n.GetStringValue(); } },
                {"floorDescription", n => { FloorDescription = n.GetStringValue(); } },
                {"latitude", n => { Latitude = n.GetDoubleValue(); } },
                {"longitude", n => { Longitude = n.GetDoubleValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organization", n => { Organization = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"roomDescription", n => { RoomDescription = n.GetStringValue(); } },
                {"roomName", n => { RoomName = n.GetStringValue(); } },
                {"site", n => { Site = n.GetStringValue(); } },
                {"stateOrProvince", n => { StateOrProvince = n.GetStringValue(); } },
                {"streetAddress", n => { StreetAddress = n.GetStringValue(); } },
                {"subdivision", n => { Subdivision = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"subunit", n => { Subunit = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("altitudeInMeters", AltitudeInMeters);
            writer.WriteStringValue("building", Building);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteStringValue("floor", Floor);
            writer.WriteStringValue("floorDescription", FloorDescription);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("organization", Organization);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("roomDescription", RoomDescription);
            writer.WriteStringValue("roomName", RoomName);
            writer.WriteStringValue("site", Site);
            writer.WriteStringValue("stateOrProvince", StateOrProvince);
            writer.WriteStringValue("streetAddress", StreetAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("subdivision", Subdivision);
            writer.WriteCollectionOfPrimitiveValues<string>("subunit", Subunit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
