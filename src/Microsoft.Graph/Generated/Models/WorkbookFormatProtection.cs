using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class WorkbookFormatProtection : Entity, IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates if Excel hides the formula for the cells in the range. A null value indicates that the entire range doesn&apos;t have uniform formula hidden setting.</summary>
        public bool? FormulaHidden {
            get { return BackingStore?.Get<bool?>("formulaHidden"); }
            set { BackingStore?.Set("formulaHidden", value); }
        }
        /// <summary>Indicates if Excel locks the cells in the object. A null value indicates that the entire range doesn&apos;t have uniform lock setting.</summary>
        public bool? Locked {
            get { return BackingStore?.Get<bool?>("locked"); }
            set { BackingStore?.Set("locked", value); }
        }
        /// <summary>
        /// Instantiates a new WorkbookFormatProtection and sets the default values.
        /// </summary>
        public WorkbookFormatProtection() : base() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookFormatProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookFormatProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"formulaHidden", n => { FormulaHidden = n.GetBoolValue(); } },
                {"locked", n => { Locked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("formulaHidden", FormulaHidden);
            writer.WriteBoolValue("locked", Locked);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
