using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api;

public class WeatherFactData {

    [JsonPropertyName("temp")]
    public int Temperature { get; set; }

    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }

    [JsonPropertyName("obs_time")]
    public int ObsTime { get; set; }

    [JsonPropertyName("cloudness")]
    public float Cloudness { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    //[JsonPropertyName("icon")]
    //public string Icon { get; set; }

    //[JsonPropertyName("condition")]
    //public string Condition { get; set; }

    //[JsonPropertyName("season")]
    //public string Season { get; set; }

    //[JsonPropertyName("daytime")]
    //public string Daytime { get; set; }

}
