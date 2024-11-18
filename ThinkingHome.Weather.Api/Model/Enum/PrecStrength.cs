using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;

namespace ThinkingHome.Weather.Api.Model.Enum;

[JsonConverter(typeof(PrecStrengthConverter))]
public enum PrecStrength
{
    Clear,
    Light,
    Normal,
    Heavy,
    VeryHeavy
}
