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
namespace Microsoft.Graph.Users.Item.ExportDeviceAndAppManagementDataWithSkipWithTop {
    /// <summary>
    /// Provides operations to call the exportDeviceAndAppManagementData method.
    /// </summary>
    public class ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="top">Usage: top={top}</param>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? skip = default, int? top = default) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/exportDeviceAndAppManagementData(skip={skip},top={top})", pathParameters) {
            if (skip is not null) PathParameters.Add("skip", skip);
            if (top is not null) PathParameters.Add("top", top);
        }
        /// <summary>
        /// Instantiates a new ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/exportDeviceAndAppManagementData(skip={skip},top={top})", rawUrl) {
        }
        /// <summary>
        /// Invoke function exportDeviceAndAppManagementData
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DeviceAndAppManagementData?> GetAsync(Action<ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DeviceAndAppManagementData> GetAsync(Action<ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceAndAppManagementData>(requestInfo, DeviceAndAppManagementData.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function exportDeviceAndAppManagementData
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new exportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
