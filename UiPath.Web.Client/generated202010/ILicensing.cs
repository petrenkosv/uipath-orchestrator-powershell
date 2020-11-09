// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Licensing operations.
    /// </summary>
    public partial interface ILicensing
    {
        /// <summary>
        /// Acquire license units
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Administration or
        /// Administration.Write.
        ///
        /// Requires authentication.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<LicenseResultDto>> AcquireWithHttpMessagesAsync(ConsumptionLicenseDto body = default(ConsumptionLicenseDto), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Release acquired license units
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Administration or
        /// Administration.Write.
        ///
        /// Requires authentication.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<LicenseResultDto>> ReleaseWithHttpMessagesAsync(ConsumptionLicenseDto body = default(ConsumptionLicenseDto), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
