// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// details available during the download
    /// </summary>
    public partial class UpdateDownloadProgress
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDownloadProgress class.
        /// </summary>
        public UpdateDownloadProgress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateDownloadProgress class.
        /// </summary>
        /// <param name="downloadPhase">The download phase. Possible values
        /// include: 'Unknown', 'Initializing', 'Downloading',
        /// 'Verifying'</param>
        /// <param name="percentComplete">Percentage of completion.</param>
        /// <param name="totalBytesToDownload">Total bytes to download.</param>
        /// <param name="totalBytesDownloaded">Total bytes downloaded.</param>
        /// <param name="numberOfUpdatesToDownload">Number of updates to
        /// download.</param>
        /// <param name="numberOfUpdatesDownloaded">Number of updates
        /// downloaded.</param>
        public UpdateDownloadProgress(DownloadPhase? downloadPhase = default(DownloadPhase?), int? percentComplete = default(int?), double? totalBytesToDownload = default(double?), double? totalBytesDownloaded = default(double?), int? numberOfUpdatesToDownload = default(int?), int? numberOfUpdatesDownloaded = default(int?))
        {
            DownloadPhase = downloadPhase;
            PercentComplete = percentComplete;
            TotalBytesToDownload = totalBytesToDownload;
            TotalBytesDownloaded = totalBytesDownloaded;
            NumberOfUpdatesToDownload = numberOfUpdatesToDownload;
            NumberOfUpdatesDownloaded = numberOfUpdatesDownloaded;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the download phase. Possible values include:
        /// 'Unknown', 'Initializing', 'Downloading', 'Verifying'
        /// </summary>
        [JsonProperty(PropertyName = "downloadPhase")]
        public DownloadPhase? DownloadPhase { get; set; }

        /// <summary>
        /// Gets or sets percentage of completion.
        /// </summary>
        [JsonProperty(PropertyName = "percentComplete")]
        public int? PercentComplete { get; set; }

        /// <summary>
        /// Gets or sets total bytes to download.
        /// </summary>
        [JsonProperty(PropertyName = "totalBytesToDownload")]
        public double? TotalBytesToDownload { get; set; }

        /// <summary>
        /// Gets or sets total bytes downloaded.
        /// </summary>
        [JsonProperty(PropertyName = "totalBytesDownloaded")]
        public double? TotalBytesDownloaded { get; set; }

        /// <summary>
        /// Gets or sets number of updates to download.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfUpdatesToDownload")]
        public int? NumberOfUpdatesToDownload { get; set; }

        /// <summary>
        /// Gets or sets number of updates downloaded.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfUpdatesDownloaded")]
        public int? NumberOfUpdatesDownloaded { get; set; }

    }
}
