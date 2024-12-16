namespace ThinkingHome.Weather.Api;

/// <summary>
/// Представляет ошибку, которая происходит, если нет действительных ключей доступа к API
/// (например, на всех переданных ключах превышен лимит запросов)
/// </summary>
public class NoValidApiKeysException : Exception
{
    /// <summary>
    /// Создает экземпляр исключения
    /// </summary>
    public NoValidApiKeysException()
        : base("No valid keys to make request to Yandex Weather") { }
}
