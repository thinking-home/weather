using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model;

public class TimeZoneInfo
{
    [JsonPropertyName("offset")]
    public int Offset { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("abbr")]
    public string Abbr { get; set; }
    
    [JsonPropertyName("dst")]
    public bool Dst { get; set; }
}