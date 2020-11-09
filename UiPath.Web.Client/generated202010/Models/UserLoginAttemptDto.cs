// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserLoginAttemptDto
    {
        /// <summary>
        /// Initializes a new instance of the UserLoginAttemptDto class.
        /// </summary>
        public UserLoginAttemptDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserLoginAttemptDto class.
        /// </summary>
        /// <param name="creationTime">The date and time when the action was
        /// performed.</param>
        /// <param name="clientIpAddress">Client IP Address</param>
        /// <param name="clientName">Client name</param>
        /// <param name="browserInfo">Browser Information</param>
        /// <param name="result">The login's attempt result. Possible values
        /// include: 'Success', 'InvalidUserNameOrEmailAddress',
        /// 'InvalidPassword', 'UserIsNotActive', 'InvalidTenancyName',
        /// 'TenantIsNotActive', 'UserEmailIsNotConfirmed',
        /// 'UnknownExternalLogin', 'LockedOut',
        /// 'UserPhoneNumberIsNotConfirmed'</param>
        /// <param name="userId">The user that authenticated</param>
        public UserLoginAttemptDto(System.DateTime? creationTime = default(System.DateTime?), string clientIpAddress = default(string), string clientName = default(string), string browserInfo = default(string), UserLoginAttemptDtoResult? result = default(UserLoginAttemptDtoResult?), long? userId = default(long?), long? id = default(long?))
        {
            CreationTime = creationTime;
            ClientIpAddress = clientIpAddress;
            ClientName = clientName;
            BrowserInfo = browserInfo;
            Result = result;
            UserId = userId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the date and time when the action was performed.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets client IP Address
        /// </summary>
        [JsonProperty(PropertyName = "ClientIpAddress")]
        public string ClientIpAddress { get; set; }

        /// <summary>
        /// Gets or sets client name
        /// </summary>
        [JsonProperty(PropertyName = "ClientName")]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets browser Information
        /// </summary>
        [JsonProperty(PropertyName = "BrowserInfo")]
        public string BrowserInfo { get; set; }

        /// <summary>
        /// Gets or sets the login's attempt result. Possible values include:
        /// 'Success', 'InvalidUserNameOrEmailAddress', 'InvalidPassword',
        /// 'UserIsNotActive', 'InvalidTenancyName', 'TenantIsNotActive',
        /// 'UserEmailIsNotConfirmed', 'UnknownExternalLogin', 'LockedOut',
        /// 'UserPhoneNumberIsNotConfirmed'
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public UserLoginAttemptDtoResult? Result { get; set; }

        /// <summary>
        /// Gets or sets the user that authenticated
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
