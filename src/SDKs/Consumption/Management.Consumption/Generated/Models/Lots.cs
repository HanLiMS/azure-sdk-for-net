// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of listing lot summary.
    /// </summary>
    public partial class Lots
    {
        /// <summary>
        /// Initializes a new instance of the Lots class.
        /// </summary>
        public Lots()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Lots class.
        /// </summary>
        /// <param name="value">The list of lot summary.</param>
        public Lots(IList<LotSummary> value = default(IList<LotSummary>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of lot summary.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<LotSummary> Value { get; private set; }

    }
}
