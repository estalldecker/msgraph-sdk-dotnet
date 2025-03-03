using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.InternalSponsors;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item {
    /// <summary>
    /// Provides operations to manage the connectedOrganizations property of the microsoft.graph.entitlementManagement entity.
    /// </summary>
    public class ConnectedOrganizationItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the externalSponsors property of the microsoft.graph.connectedOrganization entity.</summary>
        public ExternalSponsorsRequestBuilder ExternalSponsors { get =>
            new ExternalSponsorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the internalSponsors property of the microsoft.graph.connectedOrganization entity.</summary>
        public InternalSponsorsRequestBuilder InternalSponsors { get =>
            new InternalSponsorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ConnectedOrganizationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConnectedOrganizationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganization%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ConnectedOrganizationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConnectedOrganizationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganization%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property connectedOrganizations for identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<ConnectedOrganizationItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<ConnectedOrganizationItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// References to a directory or domain of another organization whose users can request access.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ConnectedOrganization?> GetAsync(Action<ConnectedOrganizationItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ConnectedOrganization> GetAsync(Action<ConnectedOrganizationItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ConnectedOrganization>(requestInfo, ConnectedOrganization.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property connectedOrganizations in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ConnectedOrganization?> PatchAsync(ConnectedOrganization body, Action<ConnectedOrganizationItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ConnectedOrganization> PatchAsync(ConnectedOrganization body, Action<ConnectedOrganizationItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ConnectedOrganization>(requestInfo, ConnectedOrganization.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property connectedOrganizations for identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ConnectedOrganizationItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ConnectedOrganizationItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ConnectedOrganizationItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// References to a directory or domain of another organization whose users can request access.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ConnectedOrganizationItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ConnectedOrganizationItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ConnectedOrganizationItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property connectedOrganizations in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ConnectedOrganization body, Action<ConnectedOrganizationItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ConnectedOrganization body, Action<ConnectedOrganizationItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ConnectedOrganizationItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ConnectedOrganizationItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ConnectedOrganizationItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ConnectedOrganizationItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// References to a directory or domain of another organization whose users can request access.
        /// </summary>
        public class ConnectedOrganizationItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ConnectedOrganizationItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ConnectedOrganizationItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ConnectedOrganizationItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ConnectedOrganizationItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ConnectedOrganizationItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ConnectedOrganizationItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ConnectedOrganizationItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ConnectedOrganizationItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
