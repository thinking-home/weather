namespace ThinkingHome.Weather.Api;

public class NoValidAPIKeysException : Exception
{
    public NoValidAPIKeysException()
        : base("No valid keys to make request to Yandex Weather") { }
}
