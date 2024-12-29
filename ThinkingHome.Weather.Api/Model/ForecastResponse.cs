using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Информация о погоде в заданной точке
/// </summary>
public class ForecastResponse
{
    /// <summary>
    /// Время, в которое был сделан запрос
    /// </summary>
    [JsonConverter(typeof(UnixDateTimeConverter))]
    [JsonPropertyName("now")]
    public DateTime Now { get; set; }

    /// <summary>
    /// Информация о местоположении
    /// </summary>
    [JsonPropertyName("info")]
    public LocationInfo Location { get; set; }

    /// <summary>
    /// Информация о текущей погоде
    /// </summary>
    [JsonPropertyName("fact")]
    public WeatherFactData Fact { get; set; }

    /// <summary>
    /// Прогноз на ближайшие дни
    /// </summary>
    [JsonPropertyName("forecasts")]
    public ForecastData[] Forecast { get; set; }
}
