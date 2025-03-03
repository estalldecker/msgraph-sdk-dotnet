using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AuthenticationStrengthRoot : Entity, IParsable {
        /// <summary>Names and descriptions of all valid authentication method modes in the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodModeDetail>? AuthenticationMethodModes {
            get { return BackingStore?.Get<List<AuthenticationMethodModeDetail>?>("authenticationMethodModes"); }
            set { BackingStore?.Set("authenticationMethodModes", value); }
        }
#nullable restore
#else
        public List<AuthenticationMethodModeDetail> AuthenticationMethodModes {
            get { return BackingStore?.Get<List<AuthenticationMethodModeDetail>>("authenticationMethodModes"); }
            set { BackingStore?.Set("authenticationMethodModes", value); }
        }
#endif
        /// <summary>The combinations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.AuthenticationMethodModes?>? Combinations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.AuthenticationMethodModes?>?>("combinations"); }
            set { BackingStore?.Set("combinations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.AuthenticationMethodModes?> Combinations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.AuthenticationMethodModes?>>("combinations"); }
            set { BackingStore?.Set("combinations", value); }
        }
#endif
        /// <summary>A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationStrengthPolicy>? Policies {
            get { return BackingStore?.Get<List<AuthenticationStrengthPolicy>?>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
#nullable restore
#else
        public List<AuthenticationStrengthPolicy> Policies {
            get { return BackingStore?.Get<List<AuthenticationStrengthPolicy>>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthenticationStrengthRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationStrengthRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethodModes", n => { AuthenticationMethodModes = n.GetCollectionOfObjectValues<AuthenticationMethodModeDetail>(AuthenticationMethodModeDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"combinations", n => { Combinations = n.GetCollectionOfEnumValues<Microsoft.Graph.Models.AuthenticationMethodModes>()?.ToList(); } },
                {"policies", n => { Policies = n.GetCollectionOfObjectValues<AuthenticationStrengthPolicy>(AuthenticationStrengthPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodModeDetail>("authenticationMethodModes", AuthenticationMethodModes);
            writer.WriteCollectionOfEnumValues<Microsoft.Graph.Models.AuthenticationMethodModes>("combinations", Combinations);
            writer.WriteCollectionOfObjectValues<AuthenticationStrengthPolicy>("policies", Policies);
        }
    }
}
