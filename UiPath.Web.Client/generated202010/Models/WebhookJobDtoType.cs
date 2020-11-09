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
    /// Defines values for WebhookJobDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookJobDtoType
    {
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Attended")]
        Attended
    }
    internal static class WebhookJobDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookJobDtoType? value)
        {
            return value == null ? null : ((WebhookJobDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookJobDtoType value)
        {
            switch( value )
            {
                case WebhookJobDtoType.Unattended:
                    return "Unattended";
                case WebhookJobDtoType.Attended:
                    return "Attended";
            }
            return null;
        }

        internal static WebhookJobDtoType? ParseWebhookJobDtoType(this string value)
        {
            switch( value )
            {
                case "Unattended":
                    return WebhookJobDtoType.Unattended;
                case "Attended":
                    return WebhookJobDtoType.Attended;
            }
            return null;
        }
    }
}
