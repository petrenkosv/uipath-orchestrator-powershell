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

    public partial class UsersImportUsersParameters
    {
        /// <summary>
        /// Initializes a new instance of the UsersImportUsersParameters class.
        /// </summary>
        public UsersImportUsersParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsersImportUsersParameters class.
        /// </summary>
        public UsersImportUsersParameters(IList<long?> organizationUnitIds, string group = default(string), string domain = default(string), IList<string> rolesList = default(IList<string>))
        {
            Group = group;
            Domain = domain;
            RolesList = rolesList;
            OrganizationUnitIds = organizationUnitIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rolesList")]
        public IList<string> RolesList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationUnitIds")]
        public IList<long?> OrganizationUnitIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OrganizationUnitIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrganizationUnitIds");
            }
        }
    }
}
