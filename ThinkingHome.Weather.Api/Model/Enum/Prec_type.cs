using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThinkingHome.Weather.Api.Model.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Prec_type
    {
        clear = 0,
        rain = 1,
        rainWithSnow = 2,
        snow = 3,
        hail = 4
    }
}
