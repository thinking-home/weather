using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThinkingHome.Weather.Api.Model.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Season
    {
        [JsonStringEnumMemberName("summer")]
        Summer,
        [JsonStringEnumMemberName("autumn")]
        Autumn,
        [JsonStringEnumMemberName("winter")]
        Winter,
        [JsonStringEnumMemberName("spring")]
        Spring
    }
}
