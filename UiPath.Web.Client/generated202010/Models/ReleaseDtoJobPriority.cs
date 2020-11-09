// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ReleaseDtoJobPriority.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReleaseDtoJobPriority
    {
        [EnumMember(Value = "Low")]
        Low,
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "High")]
        High
    }
    internal static class ReleaseDtoJobPriorityEnumExtension
    {
        internal static string ToSerializedValue(this ReleaseDtoJobPriority? value)
        {
            return value == null ? null : ((ReleaseDtoJobPriority)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ReleaseDtoJobPriority value)
        {
            switch( value )
            {
                case ReleaseDtoJobPriority.Low:
                    return "Low";
                case ReleaseDtoJobPriority.Normal:
                    return "Normal";
                case ReleaseDtoJobPriority.High:
                    return "High";
            }
            return null;
        }

        internal static ReleaseDtoJobPriority? ParseReleaseDtoJobPriority(this string value)
        {
            switch( value )
            {
                case "Low":
                    return ReleaseDtoJobPriority.Low;
                case "Normal":
                    return ReleaseDtoJobPriority.Normal;
                case "High":
                    return ReleaseDtoJobPriority.High;
            }
            return null;
        }
    }
}
