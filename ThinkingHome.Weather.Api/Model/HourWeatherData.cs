using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Прогноз на час
/// </summary>
public class HourWeatherData : IWeatherData
{
    /// <summary>
    /// Значение часа, для которого дается прогноз (0-23), локальное время
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    [JsonPropertyName("hour")]
    public int Hour { get; set; }

    /// <summary>
    /// Время начала часа
    /// </summary>
    [JsonConverter(typeof(UnixDateTimeConverter))]
    [JsonPropertyName("hour_ts")]
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Ощущаемая температура (°C)
    /// </summary>
    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }

    /// <summary>
    /// Код иконки погодных условий с учетом времени суток. Иконка доступна по адресу
    /// <code>https://yastatic.net/weather/i/icons/funky/dark/&lt;значение-из-поля-icon&gt;.svg</code>
    /// <see href="https://yandex.ru/dev/weather/doc/ru/concepts/icons">
    /// Список доступных иконок</see>
    /// </summary>
    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Признак грозы
    /// </summary>
    [JsonPropertyName("is_thunder")]
    public bool IsThunder { get; set; }

    /// <summary>
    /// Прогнозируемый период осадков (в минутах)
    /// </summary>
    [JsonPropertyName("prec_period")]
    public int PrecPeriod { get; set; }

    [JsonPropertyName("cloudness")] public Cloudness Cloudness { get; set; }

    [JsonPropertyName("condition")] public Condition Condition { get; set; }

    [JsonPropertyName("humidity")] public int Humidity { get; set; }

    [JsonPropertyName("prec_strength")] public PrecStrength PrecStrength { get; set; }

    [JsonPropertyName("prec_type")] public PrecType PrecType { get; set; }

    [JsonPropertyName("temp")] public int Temperature { get; set; }

    [JsonPropertyName("uv_index")] public int UvIndex { get; set; }

    [JsonPropertyName("wind_angle")] public float WindAngle { get; set; }

    [JsonPropertyName("wind_dir")] public WindDirection WindDirection { get; set; }

    [JsonPropertyName("wind_gust")] public float WindGust { get; set; }

    [JsonPropertyName("wind_speed")] public float WindSpeed { get; set; }
}
