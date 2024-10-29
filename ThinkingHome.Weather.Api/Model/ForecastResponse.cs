using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;

namespace ThinkingHome.Weather.Api.Model;

public class ForecastResponse
{
    [JsonConverter(typeof(UnixDateTimeConverter))]    
    [JsonPropertyName("now")]
    public DateTime Now { get; set; }
    
    [JsonPropertyName("fact")]
    public WeatherFactData Fact { get; set; }
    
    [JsonPropertyName("info")]
    public LocationInfo Info { get; set; }
    
    [JsonPropertyName("forecasts")]
    public ForecastData[] Forecast { get; set; }
    
}
