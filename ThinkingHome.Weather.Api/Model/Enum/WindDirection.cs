using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThinkingHome.Weather.Api.Model.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindDirection
    {
        [JsonStringEnumMemberName("nw")]
        NW,
        [JsonStringEnumMemberName("n")]
        N,
        [JsonStringEnumMemberName("ne")]
        NE,
        [JsonStringEnumMemberName("e")]
        E,
        [JsonStringEnumMemberName("se")]
        SE,
        [JsonStringEnumMemberName("s")]
        S,
        [JsonStringEnumMemberName("sw")]
        SW,
        [JsonStringEnumMemberName("w")]
        W,
        [JsonStringEnumMemberName("c")]
        Calm
    }
}
