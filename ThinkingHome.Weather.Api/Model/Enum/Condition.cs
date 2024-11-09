using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThinkingHome.Weather.Api.Model.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Condition
    {
        [JsonStringEnumMemberName("clear")]
        Clear,
        [JsonStringEnumMemberName("partly-cloudy")]
        PartlyCloudy,
        [JsonStringEnumMemberName("cloudy")]
        Cloudy,
        [JsonStringEnumMemberName("overcast")]
        Overcast,
        [JsonStringEnumMemberName("light-rain")]
        LightRain,
        [JsonStringEnumMemberName("rain")]
        Rain,
        [JsonStringEnumMemberName("heavy-rain")]
        HeavyRain,
        [JsonStringEnumMemberName("showers")]
        Showers,
        [JsonStringEnumMemberName("wet-snow")]
        WetSnow,
        [JsonStringEnumMemberName("light-snow")]
        LightSnow,
        [JsonStringEnumMemberName("snow")]
        Snow,
        [JsonStringEnumMemberName("snow-showers")]
        SnowShowers,
        [JsonStringEnumMemberName("hail")]
        Hail,
        [JsonStringEnumMemberName("thunderstorm")]
        Thunderstorm,
        [JsonStringEnumMemberName("thunderstorm-with-rain")]
        ThunderstormWithRain,
        [JsonStringEnumMemberName("thunderstorm-with-hail")]
        ThunderstormWithHail
    }
}
