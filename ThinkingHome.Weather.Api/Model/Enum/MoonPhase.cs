using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Enum;

/// <summary>
/// Фаза луны
/// </summary>
/// <remarks>
/// Для фаз луны указано направление изменения (возрастания/убывания) и процент, насколько изменение уже выполнено.
/// </remarks>
public enum MoonPhase
{
    /// <summary>
    /// Полнолуние
    /// </summary>
    [JsonStringEnumMemberName("moon-code-0")]
    FullMoon = 0,

    /// <summary>
    /// Убывающая луна 12.5%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-1")]
    WaningMoon1of4 = 1,

    /// <summary>
    /// Убывающая луна 25%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-2")]
    WaningMoon2of4 = 2,

    /// <summary>
    /// Убывающая луна 37.5%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-3")]
    WaningMoon3of4 = 3,

    /// <summary>
    /// Последняя четверть (убывающая луна 50%)
    /// </summary>
    [JsonStringEnumMemberName("moon-code-4")]
    LastQuarter = 4,

    /// <summary>
    /// Убывающая луна 62.5%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-5")]
    WaningMoon5of8 = 5,

    /// <summary>
    /// Убывающая луна 75%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-6")]
    WaningMoon6of8 = 6,

    /// <summary>
    /// Убывающая луна 87.5%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-7")]
    WaningMoon7of8 = 7,

    /// <summary>
    /// Новолуние 
    /// </summary>
    [JsonStringEnumMemberName("moon-code-8")]
    NewMoon = 8,

    /// <summary>
    /// Растущая луна 12.5%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-9")]
    GrowingMoon1of4 = 9,

    /// <summary>
    /// Растущая луна 25%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-10")]
    GrowingMoon2of4 = 10,

    /// <summary>
    /// Растущая луна 37.5%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-11")]
    GrowingMoon3of4 = 11,

    /// <summary>
    /// Первая четверть (растущая луна 50%)
    /// </summary>
    [JsonStringEnumMemberName("moon-code-12")]
    FirstQuarter = 12,

    /// <summary>
    /// Растущая луна 62.5%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-13")]
    GrowingMoon5of8 = 13,

    /// <summary>
    /// Растущая луна 75%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-14")]
    GrowingMoon6of8 = 14,

    /// <summary>
    /// Растущая луна 87.5%
    /// </summary>
    [JsonStringEnumMemberName("moon-code-15")]
    GrowingMoon7of8 = 15
}
