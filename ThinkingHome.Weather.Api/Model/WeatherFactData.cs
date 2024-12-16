using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Информация о текущей погоде
/// </summary>
public class WeatherFactData : IWeatherData
{
    /// <summary>
    /// Ощущаемая температура (°C)
    /// </summary>
    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }

    /// <summary>
    /// Время замера погодных данных
    /// </summary>
    [JsonConverter(typeof(UnixDateTimeConverter))]
    [JsonPropertyName("obs_time")]
    public DateTime ObsTime { get; set; }

    /// <summary>
    /// Время года
    /// </summary>
    [JsonPropertyName("season")]
    public Season Season { get; set; }

    /// <summary>
    /// Код иконки погоды. Иконка доступна по адресу
    /// <code>https://yastatic.net/weather/i/icons/funky/dark/&lt;значение-из-поля-icon&gt;.svg</code>
    /// <see href="https://yandex.ru/dev/weather/doc/ru/concepts/icons">
    /// Список доступных иконок</see>
    /// </summary>
    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Светлое или темное время суток
    /// </summary>
    [JsonPropertyName("daytime")]
    public Daytime Daytime { get; set; }

    /// <summary>
    /// Признак грозы
    /// </summary>
    [JsonPropertyName("is_thunder")]
    public bool IsThunder { get; set; }

    /// <summary>
    /// Признак того, что время суток, указанное в поле <c>Daytime</c>,
    /// является полярным
    /// </summary>
    [JsonPropertyName("polar")]
    public bool Polar { get; set; }

    /// <summary>
    /// Давление (в мм рт. ст.)
    /// </summary>
    [JsonPropertyName("pressure_mm")]
    public int? PressureMm { get; set; }

    /// <summary>
    /// Давление (в гектопаскалях)
    /// </summary>
    [JsonPropertyName("pressure_pa")]
    public int? PressurePa { get; set; }

    [JsonPropertyName("temp")] public int Temperature { get; set; }

    [JsonPropertyName("cloudness")] public Cloudness Cloudness { get; set; }

    [JsonPropertyName("humidity")] public int Humidity { get; set; }

    [JsonPropertyName("condition")] public Condition Condition { get; set; }

    [JsonPropertyName("prec_strength")] public PrecStrength PrecStrength { get; set; }

    [JsonPropertyName("prec_type")] public PrecType PrecType { get; set; }

    [JsonPropertyName("uv_index")] public int UvIndex { get; set; }

    [JsonPropertyName("wind_angle")] public float WindAngle { get; set; }

    [JsonPropertyName("wind_dir")] public WindDirection WindDirection { get; set; }

    [JsonPropertyName("wind_gust")] public float WindGust { get; set; }

    [JsonPropertyName("wind_speed")] public float WindSpeed { get; set; }
}
