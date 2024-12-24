using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Прогноз по времени суток
/// </summary>
public class DayPartsWeatherData
{
    /// <summary>
    /// Утро (6:00-11:59)
    /// </summary>
    [JsonPropertyName("morning")]
    public DayPartWeatherData Morning { get; set; }

    /// <summary>
    /// День (12:00-17:00)
    /// </summary>
    [JsonPropertyName("day")]
    public DayPartWeatherData Day { get; set; }

    /// <summary>
    /// Вечер (18:00-21:59)
    /// </summary>
    [JsonPropertyName("evening")]
    public DayPartWeatherData Evening { get; set; }

    /// <summary>
    /// Ночь (0:00-5:59)
    /// </summary>
    [JsonPropertyName("night")]
    public DayPartWeatherData Night { get; set; }

    /// <summary>
    /// Темное время суток (0:00-5:59)
    /// </summary>
    [JsonPropertyName("night_short")]
    public DayPartShortWeatherData NightShort { get; set; }

    /// <summary>
    /// Светлое время суток (6:00-21:59)
    /// </summary>
    [JsonPropertyName("day_short")]
    public DayPartShortWeatherData DayShort { get; set; }
}
