using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Прогноз погоды по времени суток (утро/день/вечер/ночь)
/// </summary>
public class DayPartWeatherData
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
    /// Облачность
    /// </summary>
    [JsonPropertyName("cloudness")]
    public Cloudness Cloudness { get; set; }

    /// <summary>
    /// Описание погодных условий
    /// </summary>
    [JsonPropertyName("condition")]
    public Condition Condition { get; set; }

    /// <summary>
    /// Влажность воздуха (в процентах)
    /// </summary>
    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

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
    /// Прогнозируемый период осадков (в минутах)
    /// </summary>
    [JsonPropertyName("prec_period")]
    public int PrecPeriod { get; set; }

    /// <summary>
    /// Сила осадков
    /// </summary>
    [JsonPropertyName("prec_strength")]
    public PrecStrength PrecStrength { get; set; }

    /// <summary>
    /// Тип осадков
    /// </summary>
    [JsonPropertyName("prec_type")]
    public PrecType PrecType { get; set; }

    /// <summary>
    /// Средняя температура для времени суток (°C)
    /// </summary>
    [JsonPropertyName("temp_avg")]
    public int TempAverage { get; set; }

    /// <summary>
    /// Максимальная температура для времени суток (°C)
    /// </summary>
    [JsonPropertyName("temp_max")]
    public int TempMax { get; set; }

    /// <summary>
    /// Минимальная температура для времени суток (°C)
    /// </summary>
    [JsonPropertyName("temp_min")]
    public int TempMin { get; set; }

    /// <summary>
    /// Ощущаемая температура (°C)
    /// </summary>
    [JsonPropertyName("feels_like")]
    public int FeelsLike { get; set; }

    /// <summary>
    /// Ультрафиолетовый индекс
    /// </summary>
    [JsonPropertyName("uv_index")]
    public int UvIndex { get; set; }

    /// <summary>
    /// Направление ветра (в градусах)
    /// </summary>
    [JsonPropertyName("wind_angle")]
    public float WindAngle { get; set; }

    /// <summary>
    /// Направление ветра
    /// </summary>
    [JsonPropertyName("wind_dir")]
    public WindDirection WindDirection { get; set; }

    /// <summary>
    /// Скорость порывов ветра (в м/с)
    /// </summary>
    [JsonPropertyName("wind_gust")]
    public float WindGust { get; set; }

    /// <summary>
    /// Скорость ветра (в м/с)
    /// </summary>
    [JsonPropertyName("wind_speed")]
    public float WindSpeed { get; set; }
}
