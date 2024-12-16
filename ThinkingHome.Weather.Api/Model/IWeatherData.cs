using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Api.Model;

/// <summary>
/// Интерфейс, представляющий собой информацию о погодных условиях в некоторый период времени
/// </summary>
public interface IWeatherData
{
    /// <summary>
    /// Температура (в C°)
    /// </summary>
    int Temperature { get; set; }
    /// <summary>
    /// Облачность
    /// </summary>
    Cloudness Cloudness { get; set; }
    /// <summary>
    /// Влажность воздуха (в процентах)
    /// </summary>
    int Humidity { get; set; }
    /// <summary>
    /// Описание погодных условий
    /// </summary>
    Condition Condition { get; set; }
    /// <summary>
    /// Сила осадков
    /// </summary>
    PrecStrength PrecStrength { get; set; }
    /// <summary>
    /// Тип осадков
    /// </summary>
    PrecType PrecType { get; set; }
    
    /// <summary>
    /// Ультрафиолетовый индекс
    /// </summary>
    int UvIndex { get; set; }
    
    /// <summary>
    /// Направление ветра (в градусах)
    /// </summary>
    float WindAngle { get; set; }
    /// <summary>
    /// Направление ветра
    /// </summary>
    WindDirection WindDirection { get; set; }
    /// <summary>
    /// Скорость порывов ветра (в м/с)
    /// </summary>
    float WindGust { get; set; }
    /// <summary>
    /// Скорость ветра (в м/с)
    /// </summary>
    float WindSpeed { get; set; }
}
