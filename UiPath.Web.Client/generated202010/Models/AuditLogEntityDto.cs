// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores audit information about any action performed in Orchestrator.
    /// </summary>
    public partial class AuditLogEntityDto
    {
        /// <summary>
        /// Initializes a new instance of the AuditLogEntityDto class.
        /// </summary>
        public AuditLogEntityDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuditLogEntityDto class.
        /// </summary>
        /// <param name="auditLogId">Business audit entry that triggered the
        /// changes</param>
        /// <param name="customData">Data about the old/new/included
        /// values</param>
        /// <param name="entityId">The Id of the referred entity</param>
        /// <param name="entityName">The name of the entity the auditLog refers
        /// to</param>
        /// <param name="action">The action (created, updated, deleted etc).
        /// Possible values include: 'Unknown', 'Create', 'Update', 'Delete',
        /// 'StartJob', 'StopJob', 'Associate', 'Upload', 'ChangeStatus',
        /// 'Import', 'ChangePassword', 'Register', 'Toggle', 'ResetPassword',
        /// 'PasswordResetAttempt', 'Download', 'Acknowledge', 'Activate',
        /// 'Assign', 'BulkUpload', 'UpdateFeature', 'ResumeJob', 'Start',
        /// 'End', 'Skip', 'Unassign', 'Deactivate', 'CreateBlobFileSas',
        /// 'DeleteBlobFile', 'Move', 'Set', 'StartDelete', 'ExploreStart',
        /// 'ExploreEnd', 'Save', 'Convert', 'Forward'</param>
        public AuditLogEntityDto(long? auditLogId = default(long?), string customData = default(string), long? entityId = default(long?), string entityName = default(string), AuditLogEntityDtoAction? action = default(AuditLogEntityDtoAction?), long? id = default(long?))
        {
            AuditLogId = auditLogId;
            CustomData = customData;
            EntityId = entityId;
            EntityName = entityName;
            Action = action;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets business audit entry that triggered the changes
        /// </summary>
        [JsonProperty(PropertyName = "AuditLogId")]
        public long? AuditLogId { get; set; }

        /// <summary>
        /// Gets or sets data about the old/new/included values
        /// </summary>
        [JsonProperty(PropertyName = "CustomData")]
        public string CustomData { get; set; }

        /// <summary>
        /// Gets or sets the Id of the referred entity
        /// </summary>
        [JsonProperty(PropertyName = "EntityId")]
        public long? EntityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity the auditLog refers to
        /// </summary>
        [JsonProperty(PropertyName = "EntityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// Gets or sets the action (created, updated, deleted etc). Possible
        /// values include: 'Unknown', 'Create', 'Update', 'Delete',
        /// 'StartJob', 'StopJob', 'Associate', 'Upload', 'ChangeStatus',
        /// 'Import', 'ChangePassword', 'Register', 'Toggle', 'ResetPassword',
        /// 'PasswordResetAttempt', 'Download', 'Acknowledge', 'Activate',
        /// 'Assign', 'BulkUpload', 'UpdateFeature', 'ResumeJob', 'Start',
        /// 'End', 'Skip', 'Unassign', 'Deactivate', 'CreateBlobFileSas',
        /// 'DeleteBlobFile', 'Move', 'Set', 'StartDelete', 'ExploreStart',
        /// 'ExploreEnd', 'Save', 'Convert', 'Forward'
        /// </summary>
        [JsonProperty(PropertyName = "Action")]
        public AuditLogEntityDtoAction? Action { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
