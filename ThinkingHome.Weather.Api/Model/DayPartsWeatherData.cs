using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model;

public class DayPartsWeatherData
{
    [JsonPropertyName("day")] public DayPartWeatherData Day { get; set; }

    [JsonPropertyName("evening")] public DayPartWeatherData Evening { get; set; }

    [JsonPropertyName("morning")] public DayPartWeatherData Morning { get; set; }

    [JsonPropertyName("night")] public DayPartWeatherData Night { get; set; }

    [JsonPropertyName("night_short")] public DayPartShortWeatherData NightShort { get; set; }

    [JsonPropertyName("day_short")] public DayPartShortWeatherData DayShort { get; set; }
}
