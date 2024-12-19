using System.Text.Json;
using System.Text.Json.Serialization;

namespace ThinkingHome.Weather.Api.Model.Converters;

internal class SourceConverter : JsonConverter<int[]>
{
    public override int[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        var valueArray = value.Split(',').Select(x => int.Parse(x)).ToArray();
        return valueArray;
    }

    public override void Write(Utf8JsonWriter writer, int[] value, JsonSerializerOptions options)
    {
        var str = string.Join(',', value);
        writer.WriteStringValue(str);
    }
}
