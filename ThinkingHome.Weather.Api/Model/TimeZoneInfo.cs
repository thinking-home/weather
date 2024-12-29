using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Информация о часовом поясе
/// </summary>
public class TimeZoneInfo
{
    /// <summary>
    /// Смещение в секундах от UTC
    /// </summary>
    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    /// <summary>
    /// Название часового пояса
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Сокращенное название часового пояса
    /// </summary>
    [JsonPropertyName("abbr")]
    public string Abbr { get; set; }

    /// <summary>
    /// Признак летнего времени
    /// </summary>
    [JsonPropertyName("dst")]
    public bool Dst { get; set; }
}
