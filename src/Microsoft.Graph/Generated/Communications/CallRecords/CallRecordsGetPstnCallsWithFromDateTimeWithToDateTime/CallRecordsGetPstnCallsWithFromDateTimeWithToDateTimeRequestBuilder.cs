using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Communications.CallRecords.CallRecordsGetPstnCallsWithFromDateTimeWithToDateTime {
    /// <summary>
    /// Provides operations to call the getPstnCalls method.
    /// </summary>
    public class CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="fromDateTime">Usage: fromDateTime={fromDateTime}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="toDateTime">Usage: toDateTime={toDateTime}</param>
        public CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, DateTimeOffset? fromDateTime = default, DateTimeOffset? toDateTime = default) : base(requestAdapter, "{+baseurl}/communications/callRecords/callRecords.getPstnCalls(fromDateTime={fromDateTime},toDateTime={toDateTime}){?%24top,%24skip,%24search,%24filter,%24count}", pathParameters) {
            if (fromDateTime is not null) PathParameters.Add("fromDateTime", fromDateTime);
            if (toDateTime is not null) PathParameters.Add("toDateTime", toDateTime);
        }
        /// <summary>
        /// Instantiates a new CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/communications/callRecords/callRecords.getPstnCalls(fromDateTime={fromDateTime},toDateTime={toDateTime}){?%24top,%24skip,%24search,%24filter,%24count}", rawUrl) {
        }
        /// <summary>
        /// Invoke function getPstnCalls
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetPstnCallsWithFromDateTimeWithToDateTimeResponse?> GetAsync(Action<CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GetPstnCallsWithFromDateTimeWithToDateTimeResponse> GetAsync(Action<CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetPstnCallsWithFromDateTimeWithToDateTimeResponse>(requestInfo, GetPstnCallsWithFromDateTimeWithToDateTimeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function getPstnCalls
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Invoke function getPstnCalls
        /// </summary>
        public class CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new callRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CallRecordsGetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
