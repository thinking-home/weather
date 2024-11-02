using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Converters;

namespace ThinkingHome.Weather.Api.Model.Enum;

[JsonConverter(typeof(CloudnessConverter))] 
public enum Cloudness
{
    Clear,
    PartlyCloudy, 
    Cloudy,
    PartlyOvercast,
    Overcast
}