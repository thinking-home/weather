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
        clear,
        //partly-сloudy,
        cloudy,
        overcast,
        //light-rain,
        rain,
        //heavy-rain,
        showers,
        //wet-snow,
        //light-snow,
        snow,
        //snow-showers,
        hail,
        thunderstorm,
        //thunderstorm-with-rain,
        //thunderstorm-with-hail
    }
}
