using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Season
{
    [JsonStringEnumMemberName("summer")] Summer,
    [JsonStringEnumMemberName("autumn")] Autumn,
    [JsonStringEnumMemberName("winter")] Winter,
    [JsonStringEnumMemberName("spring")] Spring
}
