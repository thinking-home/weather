using System.Text.Json;
using System.Text.Json.Serialization;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model.Converters;

public class PrecStrengthConverter : JsonConverter<PrecStrength>
{
    public override PrecStrength Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        int value = Convert.ToInt32(reader.GetSingle()*100);
        switch (value)
        {
            case 0:
                return PrecStrength.Clear;
            case 25:
                return PrecStrength.Light;
            case 50:
                return PrecStrength.Normal;
            case 75:
                return PrecStrength.Heavy;
            case 100:
                return PrecStrength.VeryHeavy;
            default:
                throw new JsonException();
        }
        
    }

    public override void Write(Utf8JsonWriter writer, PrecStrength value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case PrecStrength.Clear:
                writer.WriteNumberValue(0);
                break;
            case PrecStrength.Light:
                writer.WriteNumberValue(0.25);
                break;
            case PrecStrength.Normal:
                writer.WriteNumberValue(0.50);
                break;
            case PrecStrength.Heavy:
                writer.WriteNumberValue(0.75);
                break;
            case PrecStrength.VeryHeavy:
                writer.WriteNumberValue(1);
                break;
        }
    }
}