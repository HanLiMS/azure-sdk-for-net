// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metric Dimension v1.
    /// </summary>
    public partial class MetricDimensionV1
    {
        /// <summary>
        /// Initializes a new instance of the MetricDimensionV1 class.
        /// </summary>
        public MetricDimensionV1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDimensionV1 class.
        /// </summary>
        /// <param name="name">Name of the metrics dimension.</param>
        /// <param name="displayName">Display name of the metrics
        /// dimension.</param>
        /// <param name="toBeExportedForShoebox">To be exported to shoe
        /// box.</param>
        public MetricDimensionV1(string name = default(string), string displayName = default(string), bool? toBeExportedForShoebox = default(bool?))
        {
            Name = name;
            DisplayName = displayName;
            ToBeExportedForShoebox = toBeExportedForShoebox;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the metrics dimension.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets display name of the metrics dimension.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets to be exported to shoe box.
        /// </summary>
        [JsonProperty(PropertyName = "toBeExportedForShoebox")]
        public bool? ToBeExportedForShoebox { get; set; }

    }
}