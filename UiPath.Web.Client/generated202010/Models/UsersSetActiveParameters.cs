// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UsersSetActiveParameters
    {
        /// <summary>
        /// Initializes a new instance of the UsersSetActiveParameters class.
        /// </summary>
        public UsersSetActiveParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsersSetActiveParameters class.
        /// </summary>
        public UsersSetActiveParameters(bool active)
        {
            Active = active;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
