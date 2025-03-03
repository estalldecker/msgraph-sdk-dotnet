using Microsoft.Graph.Groups.Item.Sites.Item.Analytics;
using Microsoft.Graph.Groups.Item.Sites.Item.Columns;
using Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes;
using Microsoft.Graph.Groups.Item.Sites.Item.Drive;
using Microsoft.Graph.Groups.Item.Sites.Item.Drives;
using Microsoft.Graph.Groups.Item.Sites.Item.ExternalColumns;
using Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByInterval;
using Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Groups.Item.Sites.Item.GetApplicableContentTypesForListWithListId;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath;
using Microsoft.Graph.Groups.Item.Sites.Item.Items;
using Microsoft.Graph.Groups.Item.Sites.Item.Lists;
using Microsoft.Graph.Groups.Item.Sites.Item.Onenote;
using Microsoft.Graph.Groups.Item.Sites.Item.Operations;
using Microsoft.Graph.Groups.Item.Sites.Item.Permissions;
using Microsoft.Graph.Groups.Item.Sites.Item.Sites;
using Microsoft.Graph.Groups.Item.Sites.Item.TermStore;
using Microsoft.Graph.Groups.Item.Sites.Item.TermStores;
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
namespace Microsoft.Graph.Groups.Item.Sites.Item {
    /// <summary>
    /// Provides operations to manage the sites property of the microsoft.graph.group entity.
    /// </summary>
    public class SiteItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.site entity.</summary>
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.site entity.</summary>
        public ColumnsRequestBuilder Columns { get =>
            new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentTypes property of the microsoft.graph.site entity.</summary>
        public ContentTypesRequestBuilder ContentTypes { get =>
            new ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.site entity.</summary>
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.site entity.</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalColumns property of the microsoft.graph.site entity.</summary>
        public ExternalColumnsRequestBuilder ExternalColumns { get =>
            new ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActivitiesByInterval method.</summary>
        public GetActivitiesByIntervalRequestBuilder GetActivitiesByInterval { get =>
            new GetActivitiesByIntervalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.site entity.</summary>
        public ItemsRequestBuilder Items { get =>
            new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lists property of the microsoft.graph.site entity.</summary>
        public ListsRequestBuilder Lists { get =>
            new ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.site entity.</summary>
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.site entity.</summary>
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.site entity.</summary>
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sites property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Groups.Item.Sites.Item.Sites.SitesRequestBuilder Sites { get =>
            new Microsoft.Graph.Groups.Item.Sites.Item.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStore property of the microsoft.graph.site entity.</summary>
        public TermStoreRequestBuilder TermStore { get =>
            new TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStores property of the microsoft.graph.site entity.</summary>
        public TermStoresRequestBuilder TermStores { get =>
            new TermStoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new SiteItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SiteItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SiteItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SiteItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// </summary>
        /// <param name="listId">Usage: listId=&apos;{listId}&apos;</param>
        public GetApplicableContentTypesForListWithListIdRequestBuilder GetApplicableContentTypesForListWithListId(string listId) {
            if(string.IsNullOrEmpty(listId)) throw new ArgumentNullException(nameof(listId));
            return new GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters, RequestAdapter, listId);
        }
        /// <summary>
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Site?> GetAsync(Action<SiteItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Site> GetAsync(Action<SiteItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Site>(requestInfo, Microsoft.Graph.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getByPath method.
        /// </summary>
        /// <param name="path">Usage: path=&apos;{path}&apos;</param>
        public GetByPathWithPathRequestBuilder GetByPathWithPath(string path) {
            if(string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
            return new GetByPathWithPathRequestBuilder(PathParameters, RequestAdapter, path);
        }
        /// <summary>
        /// Update the navigation property sites in groups
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Site?> PatchAsync(Microsoft.Graph.Models.Site body, Action<SiteItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Site> PatchAsync(Microsoft.Graph.Models.Site body, Action<SiteItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Site>(requestInfo, Microsoft.Graph.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<SiteItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<SiteItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SiteItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property sites in groups
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.Site body, Action<SiteItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.Site body, Action<SiteItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new SiteItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        public class SiteItemRequestBuilderGetQueryParameters {
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
        public class SiteItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SiteItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SiteItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new SiteItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SiteItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SiteItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new SiteItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public SiteItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
