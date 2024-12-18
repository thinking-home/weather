using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Прогноз погоды на день
/// </summary>
public class ForecastData
{
    /// <summary>
    /// Начало дня
    /// </summary>
    [JsonConverter(typeof(UnixDateTimeConverter))]
    [JsonPropertyName("date_ts")]
    public DateTime Date { get; set; }

    /// <summary>
    /// Номер недели в году
    /// </summary>
    [JsonPropertyName("week")] public int Week { get; set; }

    /// <summary>
    /// Время восхода
    /// </summary>
    [JsonPropertyName("sunrise")] public string Sunrise { get; set; }

    /// <summary>
    /// Время заката
    /// </summary>
    [JsonPropertyName("sunset")] public string Sunset { get; set; }

    /// <summary>
    /// Время начала восхода
    /// </summary>
    [JsonPropertyName("rise_begin")] public string RiseBegin { get; set; }

    /// <summary>
    /// Время окончания заката
    /// </summary>
    [JsonPropertyName("set_end")] public string SetEnd { get; set; }

    /// <summary>
    /// Фаза луны
    /// </summary>
    [JsonPropertyName("moon_code")] public MoonPhase MoonPhase { get; set; }

    /// <summary>
    /// Прогнос погоды по времени суток 
    /// </summary>
    [JsonPropertyName("parts")] public DayPartsWeatherData Parts { get; set; }

    /// <summary>
    /// Прогноз погоды по часам
    /// </summary>
    [JsonPropertyName("hours")] public HourWeatherData[] Hours { get; set; }
}
