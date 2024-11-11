using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

public class WeatherFactData {

    [JsonPropertyName("temp")]
    public int Temperature { get; set; }

    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }

    [JsonConverter(typeof(UnixDateTimeConverter))]
    [JsonPropertyName("obs_time")]
    public DateTime ObsTime { get; set; }

    [JsonPropertyName("cloudness")]
    public Cloudness Cloudness { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("season")]
    public Season Season { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("daytime")]
    public Daytime Daytime { get; set; }

    [JsonPropertyName("condition")]
    public Condition Condition { get; set; }

    [JsonPropertyName("is_thunder")]
    public bool IsThunder { get; set; }

    [JsonPropertyName("polar")]
    public bool Polar { get; set; }

    [JsonPropertyName("prec_strength")]
    public PrecStrength PrecStrength { get; set; }

    [JsonPropertyName("prec_type")]
    public PrecType PrecType { get; set; }

    [JsonPropertyName("pressure_mm")]
    public int? PressureMm { get; set; }

    [JsonPropertyName("pressure_pa")]
    public int? PressurePa { get; set; }

    [JsonPropertyName("uv_index")]
    public int UvIndex { get; set; }

    [JsonPropertyName("wind_angle")]
    public float WindAngle { get; set; }

    [JsonPropertyName("wind_dir")]
    public WindDirection WindDirection { get; set; }

    [JsonPropertyName("wind_gust")]
    public float WindGust { get; set; }

    [JsonPropertyName("wind_speed")]
    public float WindSpeed { get; set; }
}
