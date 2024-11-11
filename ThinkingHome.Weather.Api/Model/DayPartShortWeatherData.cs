using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

public class DayPartShortWeatherData
{
    [JsonPropertyName("daytime")]
    public Daytime Daytime { get; set; }

    [JsonConverter(typeof(SourceConverter))]
    [JsonPropertyName("_source")]
    public int[] Sourse { get; set; }
    
    [JsonPropertyName("cloudness")]
    public Cloudness Cloudness { get; set; }
    
    [JsonPropertyName("condition")]
    public Condition Condition { get; set; }
    
    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }
    
    [JsonPropertyName("icon")]
    public string Icon { get; set; }
    
    [JsonPropertyName("polar")]
    public bool Polar { get; set; }
    
    [JsonPropertyName("fresh_snow_mm")]
    public float FreshSnowMm { get; set; }
    
    [JsonPropertyName("prec_mm")]
    public float PrecMm { get; set; }
    
    [JsonPropertyName("prec_period")]
    public int PrecPeriod { get; set; }
    
    [JsonPropertyName("prec_strength")]
    public PrecStrength PrecStrength { get; set; }
    
    [JsonPropertyName("prec_type")]
    public PrecType PrecType { get; set; }
    
    [JsonPropertyName("prec_prob")]
    public int PrecProb { get; set; }
    
    [JsonPropertyName("temp")]
    public int Temperature { get; set; }

    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }
    
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