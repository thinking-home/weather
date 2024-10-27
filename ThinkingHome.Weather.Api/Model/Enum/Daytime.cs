using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThinkingHome.Weather.Api.Model.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Daytime
    {
        [JsonStringEnumMemberName("d")]
        Day,
        [JsonStringEnumMemberName("n")]
        Night
    }
}
