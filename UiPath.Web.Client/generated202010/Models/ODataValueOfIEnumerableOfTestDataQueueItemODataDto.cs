// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataValueOfIEnumerableOfTestDataQueueItemODataDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfTestDataQueueItemODataDto class.
        /// </summary>
        public ODataValueOfIEnumerableOfTestDataQueueItemODataDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfTestDataQueueItemODataDto class.
        /// </summary>
        public ODataValueOfIEnumerableOfTestDataQueueItemODataDto(IList<TestDataQueueItemODataDto> value = default(IList<TestDataQueueItemODataDto>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<TestDataQueueItemODataDto> Value { get; set; }

    }
}
