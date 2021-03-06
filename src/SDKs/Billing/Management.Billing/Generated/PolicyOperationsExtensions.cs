// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PolicyOperations.
    /// </summary>
    public static partial class PolicyOperationsExtensions
    {
            /// <summary>
            /// The policy for a given billingAccountName and billingProfileName.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            public static Policy GetByBillingProfile(this IPolicyOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.GetByBillingProfileAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The policy for a given billingAccountName and billingProfileName.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Policy> GetByBillingProfileAsync(this IPolicyOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update a policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update policy operation.
            /// </param>
            public static Policy Update(this IPolicyOperations operations, string billingAccountName, string billingProfileName, Policy parameters)
            {
                return operations.UpdateAsync(billingAccountName, billingProfileName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update a policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update policy operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Policy> UpdateAsync(this IPolicyOperations operations, string billingAccountName, string billingProfileName, Policy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(billingAccountName, billingProfileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
