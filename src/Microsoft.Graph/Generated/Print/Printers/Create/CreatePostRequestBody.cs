using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Print.Printers.Create {
    public class CreatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The certificateSigningRequest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrintCertificateSigningRequest? CertificateSigningRequest {
            get { return BackingStore?.Get<PrintCertificateSigningRequest?>("certificateSigningRequest"); }
            set { BackingStore?.Set("certificateSigningRequest", value); }
        }
#nullable restore
#else
        public PrintCertificateSigningRequest CertificateSigningRequest {
            get { return BackingStore?.Get<PrintCertificateSigningRequest>("certificateSigningRequest"); }
            set { BackingStore?.Set("certificateSigningRequest", value); }
        }
#endif
        /// <summary>The connectorId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorId {
            get { return BackingStore?.Get<string?>("connectorId"); }
            set { BackingStore?.Set("connectorId", value); }
        }
#nullable restore
#else
        public string ConnectorId {
            get { return BackingStore?.Get<string>("connectorId"); }
            set { BackingStore?.Set("connectorId", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The hasPhysicalDevice property</summary>
        public bool? HasPhysicalDevice {
            get { return BackingStore?.Get<bool?>("hasPhysicalDevice"); }
            set { BackingStore?.Set("hasPhysicalDevice", value); }
        }
        /// <summary>The manufacturer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The model property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>The physicalDeviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhysicalDeviceId {
            get { return BackingStore?.Get<string?>("physicalDeviceId"); }
            set { BackingStore?.Set("physicalDeviceId", value); }
        }
#nullable restore
#else
        public string PhysicalDeviceId {
            get { return BackingStore?.Get<string>("physicalDeviceId"); }
            set { BackingStore?.Set("physicalDeviceId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new createPostRequestBody and sets the default values.
        /// </summary>
        public CreatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"certificateSigningRequest", n => { CertificateSigningRequest = n.GetObjectValue<PrintCertificateSigningRequest>(PrintCertificateSigningRequest.CreateFromDiscriminatorValue); } },
                {"connectorId", n => { ConnectorId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"hasPhysicalDevice", n => { HasPhysicalDevice = n.GetBoolValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"physicalDeviceId", n => { PhysicalDeviceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PrintCertificateSigningRequest>("certificateSigningRequest", CertificateSigningRequest);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hasPhysicalDevice", HasPhysicalDevice);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("physicalDeviceId", PhysicalDeviceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
