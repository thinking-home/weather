using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Enum;

/// <summary>
/// Время суток
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Daytime
{
    /// <summary>
    /// День
    /// </summary>
    [JsonStringEnumMemberName("d")] Day,

    /// <summary>
    /// Ночь
    /// </summary>
    [JsonStringEnumMemberName("n")] Night
}
