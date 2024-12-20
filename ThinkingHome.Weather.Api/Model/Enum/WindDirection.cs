using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Enum;

/// <summary>
/// Направление ветра
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WindDirection
{
    /// <summary>
    /// Северо-западный ветер
    /// </summary>
    [JsonStringEnumMemberName("nw")] NW,

    /// <summary>
    /// Северный ветер
    /// </summary>
    [JsonStringEnumMemberName("n")] N,

    /// <summary>
    /// Северо-восточный ветер
    /// </summary>
    [JsonStringEnumMemberName("ne")] NE,

    /// <summary>
    /// Восточный ветер
    /// </summary>
    [JsonStringEnumMemberName("e")] E,

    /// <summary>
    /// Юго-восточный ветер
    /// </summary>
    [JsonStringEnumMemberName("se")] SE,

    /// <summary>
    /// Южный ветер
    /// </summary>
    [JsonStringEnumMemberName("s")] S,

    /// <summary>
    /// Юго-западный ветер
    /// </summary>
    [JsonStringEnumMemberName("sw")] SW,

    /// <summary>
    /// Западный ветер
    /// </summary>
    [JsonStringEnumMemberName("w")] W,

    /// <summary>
    /// Штиль
    /// </summary>
    [JsonStringEnumMemberName("c")] Calm
}
