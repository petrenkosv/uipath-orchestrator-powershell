// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An event triggered by a robot Orchestrator activity
    /// </summary>
    public partial class CustomEventDto
    {
        /// <summary>
        /// Initializes a new instance of the CustomEventDto class.
        /// </summary>
        public CustomEventDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomEventDto class.
        /// </summary>
        public CustomEventDto(string type, string eventId, System.DateTime timestamp, IDictionary<string, object> eventData = default(IDictionary<string, object>), int? tenantId = default(int?), long? organizationUnitId = default(long?), long? userId = default(long?))
        {
            Type = type;
            EventId = eventId;
            Timestamp = timestamp;
            EventData = eventData;
            TenantId = tenantId;
            OrganizationUnitId = organizationUnitId;
            UserId = userId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EventId")]
        public string EventId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Timestamp")]
        public System.DateTime Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EventData")]
        public IDictionary<string, object> EventData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TenantId")]
        public int? TenantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationUnitId")]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (EventId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EventId");
            }
            if (EventId != null)
            {
                if (EventId.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "EventId", 50);
                }
                if (EventId.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "EventId", 0);
                }
            }
        }
    }
}
