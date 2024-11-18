using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Enum;

public enum MoonPhase
{
    [JsonStringEnumMemberName("moon-code-0")]
    FullMoon = 0,

    [JsonStringEnumMemberName("moon-code-1")]
    WaningMoon1of4 = 1,

    [JsonStringEnumMemberName("moon-code-2")]
    WaningMoon2of4 = 2,

    [JsonStringEnumMemberName("moon-code-3")]
    WaningMoon3of4 = 3,

    [JsonStringEnumMemberName("moon-code-4")]
    LastQuarter = 4,

    [JsonStringEnumMemberName("moon-code-5")]
    WaningMoon5of8 = 5,

    [JsonStringEnumMemberName("moon-code-6")]
    WaningMoon6of8 = 6,

    [JsonStringEnumMemberName("moon-code-7")]
    WaningMoon7of8 = 7,

    [JsonStringEnumMemberName("moon-code-8")]
    NewMoon = 8,

    [JsonStringEnumMemberName("moon-code-9")]
    GrowingMoon1of4 = 9,

    [JsonStringEnumMemberName("moon-code-10")]
    GrowingMoon2of4 = 10,

    [JsonStringEnumMemberName("moon-code-11")]
    GrowingMoon3of4 = 11,

    [JsonStringEnumMemberName("moon-code-12")]
    FirstQuarter = 12,

    [JsonStringEnumMemberName("moon-code-13")]
    GrowingMoon5of8 = 13,

    [JsonStringEnumMemberName("moon-code-14")]
    GrowingMoon6of8 = 14,

    [JsonStringEnumMemberName("moon-code-15")]
    GrowingMoon7of8 = 15
}
