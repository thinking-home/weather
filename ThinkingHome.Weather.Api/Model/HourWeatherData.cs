using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model;

public class HourWeatherData
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    [JsonPropertyName("hour")]
    public int Hour { get; set; }
    
}