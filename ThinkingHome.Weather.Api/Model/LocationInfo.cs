using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Информация о местоположении
/// </summary>
public class LocationInfo
{
    /// <summary>
    /// Широта
    /// </summary>
    [JsonPropertyName("lat")]
    public float Latitude { get; set; }

    /// <summary>
    /// Долгота
    /// </summary>
    [JsonPropertyName("lon")]
    public float Longitude { get; set; }

    /// <summary>
    /// Информация о часовом поясе
    /// </summary>
    [JsonPropertyName("tzinfo")]
    public TimeZoneInfo TimeZone { get; set; }

    /// <summary>
    /// Норма давления для данной координаты (в мм рт. ст.)
    /// </summary>
    [JsonPropertyName("def_pressure_mm")]
    public int DefPressureMm { get; set; }

    /// <summary>
    /// Норма давления для данной координаты (в гектопаскалях)
    /// </summary>
    [JsonPropertyName("def_pressure_pa")]
    public int DefPressurePa { get; set; }

    /// <summary>
    /// Страница населенного пункта на сайте <see href="https://yandex.ru/pogoda">Яндекс Погоды</see>
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
