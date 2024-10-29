using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model;

public class LocationInfo
{
    [JsonPropertyName("lat")]
    public float Latitude { get; set; }
    
    [JsonPropertyName("lon")]
    public float Longitude { get; set; }

    [JsonPropertyName("tzinfo")]
    public TimeZoneInfo TimeZone { get; set; }
    
    [JsonPropertyName("def_pressure_mm")]
    public int DefPressureMm { get; set; }
    
    [JsonPropertyName("def_pressure_pa")]
    public int DefPressurePa { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; }
}