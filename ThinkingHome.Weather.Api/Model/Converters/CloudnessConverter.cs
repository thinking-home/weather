using System.Text.Json;
using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model.Converters;

public class CloudnessConverter : JsonConverter<Cloudness>
{
    public override Cloudness Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = Convert.ToInt32(reader.GetSingle() * 100);
        switch (value)
        {
            case 0:
                return Cloudness.Clear;
            case 25:
                return Cloudness.PartlyCloudy;
            case 50:
                return Cloudness.Cloudy;
            case 75:
                return Cloudness.PartlyOvercast;
            case 100:
                return Cloudness.Overcast;
            default:
                throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, Cloudness value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case Cloudness.Clear:
                writer.WriteNumberValue(0);
                break;
            case Cloudness.PartlyCloudy:
                writer.WriteNumberValue(0.25);
                break;
            case Cloudness.Cloudy:
                writer.WriteNumberValue(0.50);
                break;
            case Cloudness.PartlyOvercast:
                writer.WriteNumberValue(0.75);
                break;
            case Cloudness.Overcast:
                writer.WriteNumberValue(1);
                break;
        }
    }
}
