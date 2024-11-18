using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Daytime
{
    [JsonStringEnumMemberName("d")] Day,
    [JsonStringEnumMemberName("n")] Night
}
