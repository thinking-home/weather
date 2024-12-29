using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;

namespace ThinkingHome.Weather.Api.Model.Enum;

/// <summary>
/// Облачность
/// </summary>
[JsonConverter(typeof(CloudnessConverter))]
public enum Cloudness
{
    /// <summary>
    /// Ясно
    /// </summary>
    Clear,

    /// <summary>
    /// Малооблачно
    /// </summary>
    PartlyCloudy,

    /// <summary>
    /// Облачно с прояснениями
    /// </summary>
    Cloudy,

    /// <summary>
    /// Облачно
    /// </summary>
    PartlyOvercast,

    /// <summary>
    /// Пасмурно
    /// </summary>
    Overcast
}
