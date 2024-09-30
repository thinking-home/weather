using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api;

public class WeatherFactData {

    [JsonPropertyName("temp")]
    public int Temperature { get; set; }

    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }
}