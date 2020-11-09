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

    public partial class MachineFolderDto
    {
        /// <summary>
        /// Initializes a new instance of the MachineFolderDto class.
        /// </summary>
        public MachineFolderDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MachineFolderDto class.
        /// </summary>
        /// <param name="name">The name of the Machine a Robot is hosted
        /// on.</param>
        /// <param name="licenseKey">The key is automatically generated from
        /// the server for the Robot machine.
        /// &lt;para /&gt;For the robot to work, the same key must exist on
        /// both the robot and Orchestrator.
        /// &lt;para /&gt;All robots on a machine must have the same license
        /// key in order to register correctly.</param>
        /// <param name="type">The type of the Machine (Standard / Template).
        /// Possible values include: 'Standard', 'Template'</param>
        /// <param name="scope">The scope of the Machine (Default / Shared / PW
        /// / Cloud). Possible values include: 'Default', 'Shared',
        /// 'PersonalWorkspace', 'Cloud'</param>
        /// <param name="nonProductionSlots">Number of NonProduction slots to
        /// be reserved at runtime</param>
        /// <param name="unattendedSlots">Number of Unattended slots to be
        /// reserved at runtime</param>
        /// <param name="headlessSlots">Number of Headless slots to be reserved
        /// at runtime</param>
        /// <param name="testAutomationSlots">Number of TestAutomation slots to
        /// be reserved at runtime</param>
        /// <param name="key">An immutable unique identifier that is preserved
        /// during tenant migration</param>
        /// <param name="robotVersions">The versions of the Robots hosted on
        /// the Machine.</param>
        public MachineFolderDto(string name, bool? isAssignedToFolder = default(bool?), string licenseKey = default(string), string description = default(string), MachineDtoType? type = default(MachineDtoType?), MachineDtoScope? scope = default(MachineDtoScope?), int? nonProductionSlots = default(int?), int? unattendedSlots = default(int?), int? headlessSlots = default(int?), int? testAutomationSlots = default(int?), System.Guid? key = default(System.Guid?), IList<MachinesRobotVersionDto> robotVersions = default(IList<MachinesRobotVersionDto>), long? id = default(long?))
        {
            IsAssignedToFolder = isAssignedToFolder;
            LicenseKey = licenseKey;
            Name = name;
            Description = description;
            Type = type;
            Scope = scope;
            NonProductionSlots = nonProductionSlots;
            UnattendedSlots = unattendedSlots;
            HeadlessSlots = headlessSlots;
            TestAutomationSlots = testAutomationSlots;
            Key = key;
            RobotVersions = robotVersions;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAssignedToFolder")]
        public bool? IsAssignedToFolder { get; set; }

        /// <summary>
        /// Gets or sets the key is automatically generated from the server for
        /// the Robot machine.
        /// &amp;lt;para /&amp;gt;For the robot to work, the same key must
        /// exist on both the robot and Orchestrator.
        /// &amp;lt;para /&amp;gt;All robots on a machine must have the same
        /// license key in order to register correctly.
        /// </summary>
        [JsonProperty(PropertyName = "LicenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Gets or sets the name of the Machine a Robot is hosted on.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the Machine (Standard / Template).
        /// Possible values include: 'Standard', 'Template'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public MachineDtoType? Type { get; set; }

        /// <summary>
        /// Gets or sets the scope of the Machine (Default / Shared / PW /
        /// Cloud). Possible values include: 'Default', 'Shared',
        /// 'PersonalWorkspace', 'Cloud'
        /// </summary>
        [JsonProperty(PropertyName = "Scope")]
        public MachineDtoScope? Scope { get; set; }

        /// <summary>
        /// Gets or sets number of NonProduction slots to be reserved at
        /// runtime
        /// </summary>
        [JsonProperty(PropertyName = "NonProductionSlots")]
        public int? NonProductionSlots { get; set; }

        /// <summary>
        /// Gets or sets number of Unattended slots to be reserved at runtime
        /// </summary>
        [JsonProperty(PropertyName = "UnattendedSlots")]
        public int? UnattendedSlots { get; set; }

        /// <summary>
        /// Gets or sets number of Headless slots to be reserved at runtime
        /// </summary>
        [JsonProperty(PropertyName = "HeadlessSlots")]
        public int? HeadlessSlots { get; set; }

        /// <summary>
        /// Gets or sets number of TestAutomation slots to be reserved at
        /// runtime
        /// </summary>
        [JsonProperty(PropertyName = "TestAutomationSlots")]
        public int? TestAutomationSlots { get; set; }

        /// <summary>
        /// Gets or sets an immutable unique identifier that is preserved
        /// during tenant migration
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public System.Guid? Key { get; set; }

        /// <summary>
        /// Gets or sets the versions of the Robots hosted on the Machine.
        /// </summary>
        [JsonProperty(PropertyName = "RobotVersions")]
        public IList<MachinesRobotVersionDto> RobotVersions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (LicenseKey != null)
            {
                if (LicenseKey.Length > 255)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "LicenseKey", 255);
                }
                if (LicenseKey.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "LicenseKey", 0);
                }
            }
            if (Name != null)
            {
                if (Name.Length > 450)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 450);
                }
                if (Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 500)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 500);
                }
                if (Description.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Description", 0);
                }
            }
        }
    }
}
