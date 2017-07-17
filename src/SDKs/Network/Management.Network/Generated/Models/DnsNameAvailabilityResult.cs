// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response for the CheckDnsNameAvailability API service call.
    /// </summary>
    public partial class DnsNameAvailabilityResult
    {
        /// <summary>
        /// Initializes a new instance of the DnsNameAvailabilityResult class.
        /// </summary>
        public DnsNameAvailabilityResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DnsNameAvailabilityResult class.
        /// </summary>
        /// <param name="available">Domain availability (True/False).</param>
        public DnsNameAvailabilityResult(bool? available = default(bool?))
        {
            Available = available;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets domain availability (True/False).
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool? Available { get; set; }

    }
}