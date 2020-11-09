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
    /// Defines values for SearchContext.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchContext
    {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Users")]
        Users,
        [EnumMember(Value = "Groups")]
        Groups
    }
    internal static class SearchContextEnumExtension
    {
        internal static string ToSerializedValue(this SearchContext? value)
        {
            return value == null ? null : ((SearchContext)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SearchContext value)
        {
            switch( value )
            {
                case SearchContext.All:
                    return "All";
                case SearchContext.Users:
                    return "Users";
                case SearchContext.Groups:
                    return "Groups";
            }
            return null;
        }

        internal static SearchContext? ParseSearchContext(this string value)
        {
            switch( value )
            {
                case "All":
                    return SearchContext.All;
                case "Users":
                    return SearchContext.Users;
                case "Groups":
                    return SearchContext.Groups;
            }
            return null;
        }
    }
}
