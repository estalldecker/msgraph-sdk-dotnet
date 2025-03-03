using Microsoft.Graph.Places.Count;
using Microsoft.Graph.Places.GraphRoom;
using Microsoft.Graph.Places.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Places {
    /// <summary>
    /// Builds and executes requests for operations under \places
    /// </summary>
    public class PlacesRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to room.</summary>
        public GraphRoomRequestBuilder GraphRoom { get =>
            new GraphRoomRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of place entities.</summary>
        public PlaceItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("place%2Did", position);
            return new PlaceItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new PlacesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlacesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/places", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PlacesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlacesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/places", rawUrl) {
        }
    }
}
