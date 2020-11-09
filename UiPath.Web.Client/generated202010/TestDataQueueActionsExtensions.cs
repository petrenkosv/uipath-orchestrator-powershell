// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TestDataQueueActions.
    /// </summary>
    public static partial class TestDataQueueActionsExtensions
    {
            /// <summary>
            /// Add a new test data queue item
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Create.
            ///
            /// Responses:
            /// 201 Returns the added test data queue item
            /// 403 If the caller doesn't have permissions to create test data queue items
            /// 409 If the test data queue item content violates the content JSON schema
            /// set on the queue
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// QueueName: the test data queue name; Content: the item content
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestDataQueueItemDto AddItem(this ITestDataQueueActions operations, TestDataQueueAddItemDto body = default(TestDataQueueAddItemDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.AddItemAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add a new test data queue item
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Create.
            ///
            /// Responses:
            /// 201 Returns the added test data queue item
            /// 403 If the caller doesn't have permissions to create test data queue items
            /// 409 If the test data queue item content violates the content JSON schema
            /// set on the queue
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// QueueName: the test data queue name; Content: the item content
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestDataQueueItemDto> AddItemAsync(this ITestDataQueueActions operations, TestDataQueueAddItemDto body = default(TestDataQueueAddItemDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddItemWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Bulk adds an array of data queue items
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Create.
            ///
            /// Responses:
            /// 200 Returns the number of items added
            /// 403 If the caller doesn't have permissions to create test data queue items
            /// 409 If the test data queue items violates the content JSON schema set on
            /// the queue
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// QueueName: the test data queue name; Items: an array of item content
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static int? BulkAddItems(this ITestDataQueueActions operations, TestDataQueueBulkAddItemsDto body = default(TestDataQueueBulkAddItemsDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.BulkAddItemsAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Bulk adds an array of data queue items
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Create.
            ///
            /// Responses:
            /// 200 Returns the number of items added
            /// 403 If the caller doesn't have permissions to create test data queue items
            /// 409 If the test data queue items violates the content JSON schema set on
            /// the queue
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// QueueName: the test data queue name; Items: an array of item content
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<int?> BulkAddItemsAsync(this ITestDataQueueActions operations, TestDataQueueBulkAddItemsDto body = default(TestDataQueueBulkAddItemsDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BulkAddItemsWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete all items from a test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Delete.
            ///
            /// Responses:
            /// 202 All items from the test data queue were scheduled for deletion
            /// 403 If the caller doesn't have permissions to delete test data queue items
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueName'>
            /// The name of the test data queue
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void DeleteAllItems(this ITestDataQueueActions operations, string queueName = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.DeleteAllItemsAsync(queueName, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete all items from a test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Delete.
            ///
            /// Responses:
            /// 202 All items from the test data queue were scheduled for deletion
            /// 403 If the caller doesn't have permissions to delete test data queue items
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueName'>
            /// The name of the test data queue
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAllItemsAsync(this ITestDataQueueActions operations, string queueName = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAllItemsWithHttpMessagesAsync(queueName, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete specific test data queue items
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Delete.
            ///
            /// Responses:
            /// 204 Deleted the test data queue items
            /// 403 If the caller doesn't have permissions to delete test data queue items
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The Ids of the test data queue items
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void DeleteItems(this ITestDataQueueActions operations, IList<long?> body = default(IList<long?>), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.DeleteItemsAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete specific test data queue items
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Delete.
            ///
            /// Responses:
            /// 204 Deleted the test data queue items
            /// 403 If the caller doesn't have permissions to delete test data queue items
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The Ids of the test data queue items
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteItemsAsync(this ITestDataQueueActions operations, IList<long?> body = default(IList<long?>), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteItemsWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the next unconsumed test data queue item
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.View.
            ///
            /// Responses:
            /// 200 Returns the next unconsumed test data queue item
            /// 204 If there are no unconsumed test data queue items in the queue
            /// 403 If the caller doesn't have permissions to view test data queue items
            /// 404 If the test data queue does not exist
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// QueueName:the test data queue name; SetConsumed: Whether to set the item's
            /// IsConsumed flag as true or false
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestDataQueueItemDto GetNextItem(this ITestDataQueueActions operations, TestDataQueueGetNextItemDto body = default(TestDataQueueGetNextItemDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetNextItemAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the next unconsumed test data queue item
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.View.
            ///
            /// Responses:
            /// 200 Returns the next unconsumed test data queue item
            /// 204 If there are no unconsumed test data queue items in the queue
            /// 403 If the caller doesn't have permissions to view test data queue items
            /// 404 If the test data queue does not exist
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// QueueName:the test data queue name; SetConsumed: Whether to set the item's
            /// IsConsumed flag as true or false
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestDataQueueItemDto> GetNextItemAsync(this ITestDataQueueActions operations, TestDataQueueGetNextItemDto body = default(TestDataQueueGetNextItemDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNextItemWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set the IsConsumed flag for all items from a test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Edit.
            ///
            /// Responses:
            /// 202 All items from the test data queue were scheduled for setting the
            /// IsConsumed flag
            /// 403 If the caller doesn't have permissions to edit test data queue items
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// QueueName: the name of the test data queue; IsConsumed: the value to be set
            /// on the items IsConsumed flag
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void SetAllItemsConsumed(this ITestDataQueueActions operations, TestDataQueueSetAllItemsConsumedDto body = default(TestDataQueueSetAllItemsConsumedDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.SetAllItemsConsumedAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set the IsConsumed flag for all items from a test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Edit.
            ///
            /// Responses:
            /// 202 All items from the test data queue were scheduled for setting the
            /// IsConsumed flag
            /// 403 If the caller doesn't have permissions to edit test data queue items
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// QueueName: the name of the test data queue; IsConsumed: the value to be set
            /// on the items IsConsumed flag
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetAllItemsConsumedAsync(this ITestDataQueueActions operations, TestDataQueueSetAllItemsConsumedDto body = default(TestDataQueueSetAllItemsConsumedDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetAllItemsConsumedWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Set the IsConsumed flag for specific test data queue items
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Edit.
            ///
            /// Responses:
            /// 200 If the operation succeeded
            /// 403 If the caller doesn't have permissions to edit test data queue items
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// ItemIds: the list of item ids for which to set the IsConsumed flag;
            /// IsConsumed: the value to be set on the items IsConsumed flag
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void SetItemsConsumed(this ITestDataQueueActions operations, TestDataQueueSetItemsConsumedDto body = default(TestDataQueueSetItemsConsumedDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.SetItemsConsumedAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set the IsConsumed flag for specific test data queue items
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueueItems.Edit.
            ///
            /// Responses:
            /// 200 If the operation succeeded
            /// 403 If the caller doesn't have permissions to edit test data queue items
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// ItemIds: the list of item ids for which to set the IsConsumed flag;
            /// IsConsumed: the value to be set on the items IsConsumed flag
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetItemsConsumedAsync(this ITestDataQueueActions operations, TestDataQueueSetItemsConsumedDto body = default(TestDataQueueSetItemsConsumedDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetItemsConsumedWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
