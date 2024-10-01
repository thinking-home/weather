using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api;

public class ForecastResponse
{
    [JsonPropertyName("fact")]
    public WeatherFactData Fact { get; set; }
}
