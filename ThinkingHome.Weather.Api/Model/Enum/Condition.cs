using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Enum;

/// <summary>
/// Погодные условия
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Condition
{
    /// <summary>
    /// Ясно
    /// </summary>
    [JsonStringEnumMemberName("clear")] Clear,

    /// <summary>
    /// Малооблачно
    /// </summary>
    [JsonStringEnumMemberName("partly-cloudy")]
    PartlyCloudy,

    /// <summary>
    /// Облачно с прояснениями
    /// </summary>
    [JsonStringEnumMemberName("cloudy")] Cloudy,

    /// <summary>
    /// Пасмурно
    /// </summary>
    [JsonStringEnumMemberName("overcast")] Overcast,

    /// <summary>
    /// Небольшой дождь
    /// </summary>
    [JsonStringEnumMemberName("light-rain")]
    LightRain,

    /// <summary>
    /// Дождь
    /// </summary>
    [JsonStringEnumMemberName("rain")] Rain,

    /// <summary>
    /// Сильный дождь
    /// </summary>
    [JsonStringEnumMemberName("heavy-rain")]
    HeavyRain,

    /// <summary>
    /// Ливень
    /// </summary>
    [JsonStringEnumMemberName("showers")] Showers,

    /// <summary>
    /// Дождь со снегом
    /// </summary>
    [JsonStringEnumMemberName("wet-snow")] WetSnow,

    /// <summary>
    /// Небольшой снег
    /// </summary>
    [JsonStringEnumMemberName("light-snow")]
    LightSnow,

    /// <summary>
    /// Снег
    /// </summary>
    [JsonStringEnumMemberName("snow")] Snow,

    /// <summary>
    /// Снегопад
    /// </summary>
    [JsonStringEnumMemberName("snow-showers")]
    SnowShowers,

    /// <summary>
    /// Град
    /// </summary>
    [JsonStringEnumMemberName("hail")] Hail,

    /// <summary>
    /// Гроза
    /// </summary>
    [JsonStringEnumMemberName("thunderstorm")]
    Thunderstorm,

    /// <summary>
    /// Дождь с грозой
    /// </summary>
    [JsonStringEnumMemberName("thunderstorm-with-rain")]
    ThunderstormWithRain,

    /// <summary>
    /// Гроза с градом
    /// </summary>
    [JsonStringEnumMemberName("thunderstorm-with-hail")]
    ThunderstormWithHail
}
