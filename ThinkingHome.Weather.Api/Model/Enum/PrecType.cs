namespace ThinkingHome.Weather.Api.Model.Enum;

/// <summary>
/// Тип осадков
/// </summary>
public enum PrecType
{
    /// <summary>
    /// Нет осадков
    /// </summary>
    Clear = 0,

    /// <summary>
    /// Дождь
    /// </summary>
    Rain = 1,

    /// <summary>
    /// Дождь со снегом
    /// </summary>
    RainWithSnow = 2,

    /// <summary>
    /// Снег
    /// </summary>
    Snow = 3,

    /// <summary>
    /// Град
    /// </summary>
    Hail = 4
}
