using System.Text.Json;
using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Converters;

internal class UnixDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var unixTime = reader.GetInt64();
        return DateTimeOffset.FromUnixTimeSeconds(unixTime).LocalDateTime;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        var unixTime = new DateTimeOffset(value).ToUnixTimeSeconds();
        writer.WriteNumberValue(unixTime);
    }
}
