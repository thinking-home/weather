using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

public class ForecastData
{
    [JsonConverter(typeof(UnixDateTimeConverter))]
    [JsonPropertyName("date_ts")]
    public DateTime Date { get; set; }

    [JsonPropertyName("week")] public int Week { get; set; }

    [JsonPropertyName("sunrise")] public string Sunrise { get; set; }

    [JsonPropertyName("sunset")] public string Sunset { get; set; }

    [JsonPropertyName("rise_begin")] public string RiseBegin { get; set; }

    [JsonPropertyName("set_end")] public string SetEnd { get; set; }

    [JsonPropertyName("moon_code")] public MoonPhase MoonPhase { get; set; }

    [JsonPropertyName("parts")] public DayPartsWeatherData Parts { get; set; }

    [JsonPropertyName("hours")] public HourWeatherData[] Hours { get; set; }
}
