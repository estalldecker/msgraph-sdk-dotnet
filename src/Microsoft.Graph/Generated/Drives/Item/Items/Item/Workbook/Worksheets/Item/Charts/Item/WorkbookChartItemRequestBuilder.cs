using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Axes;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.DataLabels;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Format;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Image;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.ImageWithWidth;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.ImageWithWidthWithHeight;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.ImageWithWidthWithHeightWithFittingMode;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Legend;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.SetData;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.SetPosition;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Title;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Worksheet;
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
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item {
    /// <summary>
    /// Provides operations to manage the charts property of the microsoft.graph.workbookWorksheet entity.
    /// </summary>
    public class WorkbookChartItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the axes property of the microsoft.graph.workbookChart entity.</summary>
        public AxesRequestBuilder Axes { get =>
            new AxesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dataLabels property of the microsoft.graph.workbookChart entity.</summary>
        public DataLabelsRequestBuilder DataLabels { get =>
            new DataLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookChart entity.</summary>
        public FormatRequestBuilder Format { get =>
            new FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the image method.</summary>
        public ImageRequestBuilder Image { get =>
            new ImageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the legend property of the microsoft.graph.workbookChart entity.</summary>
        public LegendRequestBuilder Legend { get =>
            new LegendRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the series property of the microsoft.graph.workbookChart entity.</summary>
        public SeriesRequestBuilder Series { get =>
            new SeriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setData method.</summary>
        public SetDataRequestBuilder SetData { get =>
            new SetDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setPosition method.</summary>
        public SetPositionRequestBuilder SetPosition { get =>
            new SetPositionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the title property of the microsoft.graph.workbookChart entity.</summary>
        public TitleRequestBuilder Title { get =>
            new TitleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookChart entity.</summary>
        public WorksheetRequestBuilder Worksheet { get =>
            new WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WorkbookChartItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookChartItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/{workbookChart%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WorkbookChartItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookChartItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/{workbookChart%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property charts for drives
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<WorkbookChartItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<WorkbookChartItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkbookChart?> GetAsync(Action<WorkbookChartItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkbookChart> GetAsync(Action<WorkbookChartItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WorkbookChart>(requestInfo, WorkbookChart.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <param name="width">Usage: width={width}</param>
        public ImageWithWidthRequestBuilder ImageWithWidth(int? width) {
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthRequestBuilder(PathParameters, RequestAdapter, width);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        public ImageWithWidthWithHeightRequestBuilder ImageWithWidthWithHeight(int? height, int? width) {
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthWithHeightRequestBuilder(PathParameters, RequestAdapter, height, width);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <param name="fittingMode">Usage: fittingMode=&apos;{fittingMode}&apos;</param>
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        public ImageWithWidthWithHeightWithFittingModeRequestBuilder ImageWithWidthWithHeightWithFittingMode(string fittingMode, int? height, int? width) {
            if(string.IsNullOrEmpty(fittingMode)) throw new ArgumentNullException(nameof(fittingMode));
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthWithHeightWithFittingModeRequestBuilder(PathParameters, RequestAdapter, fittingMode, height, width);
        }
        /// <summary>
        /// Update the navigation property charts in drives
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkbookChart?> PatchAsync(WorkbookChart body, Action<WorkbookChartItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkbookChart> PatchAsync(WorkbookChart body, Action<WorkbookChartItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WorkbookChart>(requestInfo, WorkbookChart.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property charts for drives
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<WorkbookChartItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<WorkbookChartItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WorkbookChartItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WorkbookChartItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WorkbookChartItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WorkbookChartItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property charts in drives
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(WorkbookChart body, Action<WorkbookChartItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(WorkbookChart body, Action<WorkbookChartItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new WorkbookChartItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WorkbookChartItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WorkbookChartItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public WorkbookChartItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// </summary>
        public class WorkbookChartItemRequestBuilderGetQueryParameters {
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
        public class WorkbookChartItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WorkbookChartItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WorkbookChartItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WorkbookChartItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WorkbookChartItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WorkbookChartItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WorkbookChartItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public WorkbookChartItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
