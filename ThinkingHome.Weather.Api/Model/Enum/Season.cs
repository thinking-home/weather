using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Enum;

/// <summary>
/// Время года
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Season
{
    /// <summary>
    /// Лето
    /// </summary>
    [JsonStringEnumMemberName("summer")] Summer,

    /// <summary>
    /// Осень
    /// </summary>
    [JsonStringEnumMemberName("autumn")] Autumn,

    /// <summary>
    /// Зима
    /// </summary>
    [JsonStringEnumMemberName("winter")] Winter,

    /// <summary>
    /// Весна
    /// </summary>
    [JsonStringEnumMemberName("spring")] Spring
}
