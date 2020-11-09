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
    /// FoldersNavigation operations.
    /// </summary>
    public partial interface IFoldersNavigation
    {
        /// <summary>
        /// Returns the folders the current user has access to.
        /// The response will be a list of folders; the hierarchy can be
        /// reconstructed
        /// using the ParentId properties. From the root to the folders the
        /// user has
        /// actually been assigned to, the folders will be marked as
        /// non-selectable
        /// and only the paths to the assigned-to folders will be included.
        /// From the assigned-to folders down to the leaves, the nodes will be
        /// marked as
        /// selectable and their children lists fully populated.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Forbidden or
        /// Forbidden.Read.
        ///
        /// Requires authentication.
        /// </remarks>
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
        Task<HttpOperationResponse<IList<ExtendedFolderDto>>> GetAllFoldersForCurrentUserWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a page of the user-folder assignments for the input user,
        /// including the roles for each folder.
        /// The response also includes the folders assigned to the directory
        /// groups of the user.
        /// The distinction between the folders assigned directly to the user
        /// and the ones assigned to one of his groups
        /// can be made via the User field of the response.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Forbidden or
        /// Forbidden.Read.
        ///
        /// Required permissions: (Units.View - Gets roles from all folders)
        /// and (SubFolders.View - Gets roles only from folders where caller
        /// has SubFolders.View permission) and (Users.View and Roles.View).
        /// </remarks>
        /// <param name='username'>
        /// User name
        /// </param>
        /// <param name='skip'>
        /// </param>
        /// <param name='take'>
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
        Task<HttpOperationResponse<UserRoleAssignmentsDto>> GetAllRolesForUserWithHttpMessagesAsync(string username = default(string), int? skip = default(int?), int? take = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a subset (paginated) of direct children for a given folder,
        /// which are accessible to the current user.
        /// To ease a folder tree structure navigation design, the list of
        /// ancestors for the given folder is also returned.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Forbidden or
        /// Forbidden.Read.
        ///
        /// Requires authentication.
        /// </remarks>
        /// <param name='skip'>
        /// </param>
        /// <param name='take'>
        /// </param>
        /// <param name='folderId'>
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
        Task<HttpOperationResponse<FolderNavigationContextDto>> GetFolderNavigationContextForCurrentUserWithHttpMessagesAsync(int? skip = default(int?), int? take = default(int?), long? folderId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a filtered subset (paginated) of the folders the current
        /// user has access to.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Forbidden or
        /// Forbidden.Read.
        ///
        /// Requires authentication.
        /// </remarks>
        /// <param name='skip'>
        /// </param>
        /// <param name='take'>
        /// </param>
        /// <param name='searchText'>
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
        Task<HttpOperationResponse<PageResultDtoOfFolderDto>> GetFoldersForCurrentUserWithHttpMessagesAsync(int? skip = default(int?), int? take = default(int?), string searchText = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
