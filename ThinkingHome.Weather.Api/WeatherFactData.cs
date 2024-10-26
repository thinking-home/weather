using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api;

public class WeatherFactData {

    [JsonPropertyName("temp")]
    public int Temperature { get; set; }

    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }

    [JsonConverter(typeof(UnixDateTimeConverter))]
    [JsonPropertyName("obs_time")]
    public DateTime ObsTime { get; set; }

    [JsonPropertyName("cloudness")]
    public float Cloudness { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("season")]
    public Season Season { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("daytime")]
    public Daytime Daytime { get; set; }

    [JsonPropertyName("condition")]
    public string Condition { get; set; }

    [JsonPropertyName("is_thunder")]
    public bool Is_thunder { get; set; }

    [JsonPropertyName("polar")]
    public bool Polar { get; set; }

    [JsonPropertyName("prec_strength")]
    public float Prec_strength { get; set; }

    [JsonPropertyName("prec_type")]
    public Prec_type Prec_type { get; set; }

    [JsonPropertyName("pressure_mm")]
    public int Pressure_mm { get; set; }

    [JsonPropertyName("pressure_pa")]
    public int Pressure_pa { get; set; }

    [JsonPropertyName("uv_index")]
    public int Uv_index { get; set; }

    [JsonPropertyName("wind_angle")]
    public float Wind_angle { get; set; }

    [JsonPropertyName("wind_dir")]
    public Wind_dir Wind_dir { get; set; }

    [JsonPropertyName("wind_gust")]
    public float Wind_gust { get; set; }

    [JsonPropertyName("wind_speed")]
    public float Wind_speed { get; set; }
}
