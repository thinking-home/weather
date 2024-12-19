using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Прогноз погоды на светлое/темное время суток
/// </summary>
public class DayPartShortWeatherData : IWeatherData
{
    /// <summary>
    /// Время суток
    /// </summary>
    [JsonPropertyName("daytime")]
    public Daytime Daytime { get; set; }

    /// <summary>
    /// Часы, которые входят в период
    /// </summary>
    [JsonConverter(typeof(SourceConverter))]
    [JsonPropertyName("_source")]
    public int[] Sourse { get; set; }

    /// <summary>
    /// Код иконки погодных условий с учетом времени суток. Иконка доступна по адресу
    /// <code>https://yastatic.net/weather/i/icons/funky/dark/&lt;значение-из-поля-icon&gt;.svg</code>
    /// <see href="https://yandex.ru/dev/weather/doc/ru/concepts/icons">
    /// Список доступных иконок</see>
    /// </summary>
    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Признак того, что время суток, указанное в поле <c>Daytime</c>,
    /// является полярным
    /// </summary>
    [JsonPropertyName("polar")]
    public bool Polar { get; set; }

    /// <summary>
    ///  Количество свежего снега (в мм). Вычисляется на основе значения поля <c>PrecMm</c>
    /// </summary>
    [JsonPropertyName("fresh_snow_mm")]
    public float FreshSnowMm { get; set; }

    /// <summary>
    /// Прогнозируемое количество осадков (в мм)
    /// </summary>
    [JsonPropertyName("prec_mm")]
    public float PrecMm { get; set; }

    /// <summary>
    /// Прогнозируемый период осадков (в минутах)
    /// </summary>
    [JsonPropertyName("prec_period")]
    public int PrecPeriod { get; set; }

    /// <summary>
    /// Вероятность выпадения осадков (в процентах)
    /// </summary>
    [JsonPropertyName("prec_prob")]
    public int PrecProb { get; set; }


    /// <summary>
    /// Ощущаемая температура (°C)
    /// </summary>
    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }

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
