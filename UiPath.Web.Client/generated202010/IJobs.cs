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
    /// Jobs operations.
    /// </summary>
    public partial interface IJobs
    {
        /// <summary>
        /// Gets Jobs.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Jobs or Jobs.Read.
        ///
        /// Required permissions: Jobs.View.
        /// </remarks>
        /// <param name='mandatoryPermissions'>
        /// If in a cross-folder scenario, these represent the additional
        /// permissions
        /// required in the folders the data is retrieved from; all permissions
        /// in this set must be met
        /// </param>
        /// <param name='atLeastOnePermissions'>
        /// If in a cross-folder scenario, these represent the additional
        /// permissions
        /// required in the folders the data is retrieved from; at least one
        /// permission in this set must be met
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='top'>
        /// Limits the number of items returned from a collection. The maximum
        /// value is 1000.
        /// </param>
        /// <param name='skip'>
        /// Excludes the specified number of items of the queried collection
        /// from the result.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfJobDto>> GetWithHttpMessagesAsync(IList<string> mandatoryPermissions = default(IList<string>), IList<string> atLeastOnePermissions = default(IList<string>), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a single job.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Jobs or Jobs.Read.
        ///
        /// Required permissions: Jobs.View.
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse<JobDto>> GetByIdWithHttpMessagesAsync(long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels or terminates the specified job.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
        ///
        /// Required permissions: Jobs.Edit.
        /// </remarks>
        /// <param name='key'>
        /// The specified job's Id.
        /// </param>
        /// <param name='body'>
        /// Strategy - States whether a job should be soft stopped or killed
        /// immediately.
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse> StopJobByIdWithHttpMessagesAsync(long key, JobsStopJobParameters body = default(JobsStopJobParameters), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Restarts the specified job.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
        ///
        /// Required permissions: Jobs.Create.
        /// </remarks>
        /// <param name='body'>
        /// The specified job id.
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse<JobDto>> RestartJobWithHttpMessagesAsync(JobsRestartJobParameters body = default(JobsRestartJobParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resumes the specified job.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
        ///
        /// Required permissions: Jobs.Edit.
        /// </remarks>
        /// <param name='body'>
        /// The specified job key.
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse<JobDto>> ResumeJobWithHttpMessagesAsync(JobsResumeJobParameters body = default(JobsResumeJobParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a new job and sets it in Pending state for each robot based on
        /// the input parameters and notifies the respective robots about the
        /// pending job.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
        ///
        /// Required permissions: Jobs.Create.
        /// </remarks>
        /// <param name='body'>
        /// StartInfo - The information required to register the new jobs.
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfJobDto>> StartJobsWithHttpMessagesAsync(JobsStartJobsParameters body = default(JobsStartJobsParameters), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels or terminates the specified jobs.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
        ///
        /// Required permissions: Jobs.Edit.
        /// </remarks>
        /// <param name='body'>
        /// JobIds - The ids for the jobs to be canceled or terminated;
        /// Strategy - States whether a job should be soft stopped or killed
        /// immediately.
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse> StopJobsWithHttpMessagesAsync(JobsStopJobsParameters body = default(JobsStopJobsParameters), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
