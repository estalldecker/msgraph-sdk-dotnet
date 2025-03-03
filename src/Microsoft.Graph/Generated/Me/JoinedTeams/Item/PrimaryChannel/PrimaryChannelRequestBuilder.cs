using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.CompleteMigration;
using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalName;
using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.FilesFolder;
using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.Members;
using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.Messages;
using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.ProvisionEmail;
using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.RemoveEmail;
using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.SharedWithTeams;
using Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel.Tabs;
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
namespace Microsoft.Graph.Me.JoinedTeams.Item.PrimaryChannel {
    /// <summary>
    /// Provides operations to manage the primaryChannel property of the microsoft.graph.team entity.
    /// </summary>
    public class PrimaryChannelRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the completeMigration method.</summary>
        public CompleteMigrationRequestBuilder CompleteMigration { get =>
            new CompleteMigrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the doesUserHaveAccess method.</summary>
        public DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilder DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalName { get =>
            new DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the filesFolder property of the microsoft.graph.channel entity.</summary>
        public FilesFolderRequestBuilder FilesFolder { get =>
            new FilesFolderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the members property of the microsoft.graph.channel entity.</summary>
        public MembersRequestBuilder Members { get =>
            new MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the messages property of the microsoft.graph.channel entity.</summary>
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the provisionEmail method.</summary>
        public ProvisionEmailRequestBuilder ProvisionEmail { get =>
            new ProvisionEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeEmail method.</summary>
        public RemoveEmailRequestBuilder RemoveEmail { get =>
            new RemoveEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sharedWithTeams property of the microsoft.graph.channel entity.</summary>
        public SharedWithTeamsRequestBuilder SharedWithTeams { get =>
            new SharedWithTeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tabs property of the microsoft.graph.channel entity.</summary>
        public TabsRequestBuilder Tabs { get =>
            new TabsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new PrimaryChannelRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrimaryChannelRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/joinedTeams/{team%2Did}/primaryChannel{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PrimaryChannelRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrimaryChannelRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/joinedTeams/{team%2Did}/primaryChannel{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property primaryChannel for me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<PrimaryChannelRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<PrimaryChannelRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The general channel for the team.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Channel?> GetAsync(Action<PrimaryChannelRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Channel> GetAsync(Action<PrimaryChannelRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Channel>(requestInfo, Channel.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property primaryChannel in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Channel?> PatchAsync(Channel body, Action<PrimaryChannelRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Channel> PatchAsync(Channel body, Action<PrimaryChannelRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Channel>(requestInfo, Channel.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property primaryChannel for me
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<PrimaryChannelRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<PrimaryChannelRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new PrimaryChannelRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The general channel for the team.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<PrimaryChannelRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<PrimaryChannelRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new PrimaryChannelRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property primaryChannel in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Channel body, Action<PrimaryChannelRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Channel body, Action<PrimaryChannelRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new PrimaryChannelRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class PrimaryChannelRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new primaryChannelRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public PrimaryChannelRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The general channel for the team.
        /// </summary>
        public class PrimaryChannelRequestBuilderGetQueryParameters {
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
        public class PrimaryChannelRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public PrimaryChannelRequestBuilderGetQueryParameters QueryParameters { get; set; } = new PrimaryChannelRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new primaryChannelRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public PrimaryChannelRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class PrimaryChannelRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new primaryChannelRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public PrimaryChannelRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
