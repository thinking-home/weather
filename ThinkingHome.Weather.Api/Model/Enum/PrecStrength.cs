using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;

namespace ThinkingHome.Weather.Api.Model.Enum;

/// <summary>
/// Сила осадков
/// </summary>
[JsonConverter(typeof(PrecStrengthConverter))]
public enum PrecStrength
{
    /// <summary>
    /// Без осадков
    /// </summary>
    Clear,

    /// <summary>
    /// Слабый дождь/слабый снег
    /// </summary>
    Light,

    /// <summary>
    /// Дождь/снег
    /// </summary>
    Normal,

    /// <summary>
    /// Сильный дождь/сильный снег
    /// </summary>
    Heavy,

    /// <summary>
    /// Сильный ливень/очень сильный снег
    /// </summary>
    VeryHeavy
}
