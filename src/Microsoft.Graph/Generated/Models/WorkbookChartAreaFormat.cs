using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class WorkbookChartAreaFormat : Entity, IParsable {
        /// <summary>Represents the fill format of an object, which includes background formatting information. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartFill? Fill {
            get { return BackingStore?.Get<WorkbookChartFill?>("fill"); }
            set { BackingStore?.Set("fill", value); }
        }
#nullable restore
#else
        public WorkbookChartFill Fill {
            get { return BackingStore?.Get<WorkbookChartFill>("fill"); }
            set { BackingStore?.Set("fill", value); }
        }
#endif
        /// <summary>Represents the font attributes (font name, font size, color, etc.) for the current object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartFont? Font {
            get { return BackingStore?.Get<WorkbookChartFont?>("font"); }
            set { BackingStore?.Set("font", value); }
        }
#nullable restore
#else
        public WorkbookChartFont Font {
            get { return BackingStore?.Get<WorkbookChartFont>("font"); }
            set { BackingStore?.Set("font", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookChartAreaFormat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartAreaFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fill", n => { Fill = n.GetObjectValue<WorkbookChartFill>(WorkbookChartFill.CreateFromDiscriminatorValue); } },
                {"font", n => { Font = n.GetObjectValue<WorkbookChartFont>(WorkbookChartFont.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartFill>("fill", Fill);
            writer.WriteObjectValue<WorkbookChartFont>("font", Font);
        }
    }
}
