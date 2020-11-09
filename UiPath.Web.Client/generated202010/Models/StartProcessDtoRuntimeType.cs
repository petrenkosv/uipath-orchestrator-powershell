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
    /// Defines values for StartProcessDtoRuntimeType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StartProcessDtoRuntimeType
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Studio")]
        Studio,
        [EnumMember(Value = "Development")]
        Development,
        [EnumMember(Value = "StudioX")]
        StudioX,
        [EnumMember(Value = "Headless")]
        Headless,
        [EnumMember(Value = "StudioPro")]
        StudioPro,
        [EnumMember(Value = "TestAutomation")]
        TestAutomation
    }
    internal static class StartProcessDtoRuntimeTypeEnumExtension
    {
        internal static string ToSerializedValue(this StartProcessDtoRuntimeType? value)
        {
            return value == null ? null : ((StartProcessDtoRuntimeType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StartProcessDtoRuntimeType value)
        {
            switch( value )
            {
                case StartProcessDtoRuntimeType.NonProduction:
                    return "NonProduction";
                case StartProcessDtoRuntimeType.Attended:
                    return "Attended";
                case StartProcessDtoRuntimeType.Unattended:
                    return "Unattended";
                case StartProcessDtoRuntimeType.Studio:
                    return "Studio";
                case StartProcessDtoRuntimeType.Development:
                    return "Development";
                case StartProcessDtoRuntimeType.StudioX:
                    return "StudioX";
                case StartProcessDtoRuntimeType.Headless:
                    return "Headless";
                case StartProcessDtoRuntimeType.StudioPro:
                    return "StudioPro";
                case StartProcessDtoRuntimeType.TestAutomation:
                    return "TestAutomation";
            }
            return null;
        }

        internal static StartProcessDtoRuntimeType? ParseStartProcessDtoRuntimeType(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return StartProcessDtoRuntimeType.NonProduction;
                case "Attended":
                    return StartProcessDtoRuntimeType.Attended;
                case "Unattended":
                    return StartProcessDtoRuntimeType.Unattended;
                case "Studio":
                    return StartProcessDtoRuntimeType.Studio;
                case "Development":
                    return StartProcessDtoRuntimeType.Development;
                case "StudioX":
                    return StartProcessDtoRuntimeType.StudioX;
                case "Headless":
                    return StartProcessDtoRuntimeType.Headless;
                case "StudioPro":
                    return StartProcessDtoRuntimeType.StudioPro;
                case "TestAutomation":
                    return StartProcessDtoRuntimeType.TestAutomation;
            }
            return null;
        }
    }
}
