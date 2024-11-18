using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

public interface IWeatherData
{
    int Temperature { get; set; }
    Cloudness Cloudness { get; set; }
    int Humidity { get; set; }
    Condition Condition { get; set; }
    PrecStrength PrecStrength { get; set; }
    PrecType PrecType { get; set; }
    int UvIndex { get; set; }
    float WindAngle { get; set; }
    WindDirection WindDirection { get; set; }
    float WindGust { get; set; }
    float WindSpeed { get; set; }
}
