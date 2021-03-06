// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Copy progress.
    /// </summary>
    public partial class CopyProgress
    {
        /// <summary>
        /// Initializes a new instance of the CopyProgress class.
        /// </summary>
        public CopyProgress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CopyProgress class.
        /// </summary>
        /// <param name="storageAccountName">Name of the storage account where
        /// the data needs to be uploaded.</param>
        /// <param name="accountId">Id of the account where the data needs to
        /// be uploaded.</param>
        /// <param name="bytesSentToCloud">Amount of data uploaded by the job
        /// as of now.</param>
        /// <param name="totalBytesToProcess">Total amount of data to be
        /// processed by the job.</param>
        public CopyProgress(string storageAccountName = default(string), string accountId = default(string), long? bytesSentToCloud = default(long?), long? totalBytesToProcess = default(long?))
        {
            StorageAccountName = storageAccountName;
            AccountId = accountId;
            BytesSentToCloud = bytesSentToCloud;
            TotalBytesToProcess = totalBytesToProcess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the storage account where the data needs to be
        /// uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountName")]
        public string StorageAccountName { get; private set; }

        /// <summary>
        /// Gets id of the account where the data needs to be uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets amount of data uploaded by the job as of now.
        /// </summary>
        [JsonProperty(PropertyName = "bytesSentToCloud")]
        public long? BytesSentToCloud { get; private set; }

        /// <summary>
        /// Gets total amount of data to be processed by the job.
        /// </summary>
        [JsonProperty(PropertyName = "totalBytesToProcess")]
        public long? TotalBytesToProcess { get; private set; }

    }
}
