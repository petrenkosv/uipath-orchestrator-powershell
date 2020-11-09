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
    /// Defines values for
    /// SetDefaultStoreForResourceTypeParametersResourceType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SetDefaultStoreForResourceTypeParametersResourceType
    {
        [EnumMember(Value = "AssetCredential")]
        AssetCredential,
        [EnumMember(Value = "RobotCredential")]
        RobotCredential,
        [EnumMember(Value = "BucketCredential")]
        BucketCredential,
        [EnumMember(Value = "Secrets")]
        Secrets
    }
    internal static class SetDefaultStoreForResourceTypeParametersResourceTypeEnumExtension
    {
        internal static string ToSerializedValue(this SetDefaultStoreForResourceTypeParametersResourceType? value)
        {
            return value == null ? null : ((SetDefaultStoreForResourceTypeParametersResourceType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SetDefaultStoreForResourceTypeParametersResourceType value)
        {
            switch( value )
            {
                case SetDefaultStoreForResourceTypeParametersResourceType.AssetCredential:
                    return "AssetCredential";
                case SetDefaultStoreForResourceTypeParametersResourceType.RobotCredential:
                    return "RobotCredential";
                case SetDefaultStoreForResourceTypeParametersResourceType.BucketCredential:
                    return "BucketCredential";
                case SetDefaultStoreForResourceTypeParametersResourceType.Secrets:
                    return "Secrets";
            }
            return null;
        }

        internal static SetDefaultStoreForResourceTypeParametersResourceType? ParseSetDefaultStoreForResourceTypeParametersResourceType(this string value)
        {
            switch( value )
            {
                case "AssetCredential":
                    return SetDefaultStoreForResourceTypeParametersResourceType.AssetCredential;
                case "RobotCredential":
                    return SetDefaultStoreForResourceTypeParametersResourceType.RobotCredential;
                case "BucketCredential":
                    return SetDefaultStoreForResourceTypeParametersResourceType.BucketCredential;
                case "Secrets":
                    return SetDefaultStoreForResourceTypeParametersResourceType.Secrets;
            }
            return null;
        }
    }
}
